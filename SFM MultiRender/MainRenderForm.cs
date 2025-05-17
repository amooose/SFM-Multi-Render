using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SFM_MultiRender.Properties;
using System.Collections.Specialized;


namespace SFM_MultiRender
{

    public partial class SFM_MultiRenderForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static int SESSION_TOTAL = 0;
        windowHider windowHider = new windowHider();
        SessionManager sessionManager;
        public SFM_MultiRenderForm()
        {
            InitializeComponent();
            
        }

        private void AddNewSessionCtrlGroup()
        {
            var controlGroup = new SessionCtrlGroup();
            controlGroup.sessionNameValue = "Session " + (SESSION_TOTAL + 1).ToString();
            SESSION_TOTAL++;
            if (SESSION_TOTAL % 2 == 0)
            {
                controlGroup.BackColor = Color.Silver;
            }
            sessionLayoutList.Controls.Add(controlGroup);
            
            sessionCountVisual.Value = SESSION_TOTAL > 10 ? 10 : SESSION_TOTAL;
            sessionCountVisual.Text = SESSION_TOTAL.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // stop the 1st session from being highlighted for no reason
            this.BeginInvoke((MethodInvoker)delegate {
                mainFormHeader.Focus();
                sessionManager = new SessionManager();
            });
            if (Settings.Default.autoHideSFM)
            {
                autoHideCheckbox.Checked = true;
            }
                //TODO: reload last settings
                if (Settings.Default.firstBoot || (!Settings.Default.firstBoot && Settings.Default.sfmGoodWindowPos.Equals("")))
            {
                windowHider.firstRunBackupKey();
                Settings.Default.firstBoot = false;

            }
            if (Settings.Default.rememberSessions && Settings.Default.savedSessionData != null)
            {
               loadSessions();
            }
             
        }

        private void globalFrameEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void globalFrameStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static List<(int Start, int End)> SplitRange(int start, int end, int sessionAmount)
        {
            int total = end - start + 1;
            int baseSize = total / sessionAmount;
            int remainder = total % sessionAmount;
            var result = new List<(int Start, int End)>();
            int currentStart = start;

            for (int i = 0; i < sessionAmount; i++)
            {
                int size = baseSize + (i == sessionAmount - 1 ? remainder : 0);
                int currentEnd = currentStart + size - 1;
                if (i > 0)
                {
                    result.Add((currentStart - 1, currentEnd));
                }
                else
                {
                    result.Add((currentStart, currentEnd));
                }
                currentStart = currentEnd + 1;
            }
            return result;
        }


        private void dupeSession1Paths_Click(object sender, EventArgs e)
        {
            if (SESSION_TOTAL < 2) { return; }
            SessionCtrlGroup session1 = (SessionCtrlGroup)sessionLayoutList.Controls[0];
            string s1projectFile = session1.projectFileValue;
            string s1outputDir = session1.outputDirValue;
            foreach (SessionCtrlGroup session in sessionLayoutList.Controls)
            {
                session.projectFileValue = s1projectFile;
                session.outputDirValue = s1outputDir;
            }
        }


        private void distributeFramesButton_Click(object sender, EventArgs e)
        {
            int start, end;
            Int32.TryParse(globalFrameStart.Text, out start);
            Int32.TryParse(globalFrameEnd.Text, out end);
            if (globalFrameStart.Text == "" || globalFrameEnd.Text == ""
                || SESSION_TOTAL < 1 || start >= end)
            {
                MessageBox.Show("Invalid start/end frames or empty session list");
                return;
            }
            if (SESSION_TOTAL > (end - start) + 1)
            {
                MessageBox.Show("Total Sessions should be more than total frames.");
                return;
            }
            var range = SplitRange(start, end, SESSION_TOTAL);
            int i = 0;
            foreach ((int a, int b) in range)
            {
                SessionCtrlGroup session = (SessionCtrlGroup)sessionLayoutList.Controls[i];
                session.startFrameValue = a.ToString();
                session.endFrameValue = b.ToString();
                i++;
            }
        }

        private void addSession_Click(object sender, EventArgs e)
        {
            sessionCountVisual.Show();
            AddNewSessionCtrlGroup();
        }

        private void removeSession_Click(object sender, EventArgs e)
        {
            if (SESSION_TOTAL == 0) { return; }
            if (SESSION_TOTAL == 1) { sessionCountVisual.Hide(); }
            sessionLayoutList.Controls.RemoveAt(SESSION_TOTAL - 1);
            SESSION_TOTAL -= 1;
            if (SESSION_TOTAL <= 10)
            {
                sessionCountVisual.Value = SESSION_TOTAL;
            }
            sessionCountVisual.Text = SESSION_TOTAL.ToString();
        }

        private void mainRenderFormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        private bool preLaunchCheck()
        {
            if (SESSION_TOTAL == 0)
            {
                MessageBox.Show("No sessions!");
                return false;
            }
            if (Settings.Default.sfmExe == "")
            {
                MessageBox.Show("Exe path missing!");
                return false;
            }
            bool passed = true;
            foreach (SessionCtrlGroup session in sessionLayoutList.Controls)
            {
                if(session.projectFileValue.Length==0 || session.outputDirValue.Length == 0
                    || session.startFrameValue.Length == 0 || session.endFrameValue.Length == 0)
                {
                    passed = false;
                }
            }
            if (!passed)
            {
                MessageBox.Show("Each session needs all settings filled out.");
                return false;
            }
            return true;
        }

        private void resetSessionProgress()
        {
            foreach (SessionCtrlGroup session in sessionLayoutList.Controls)
            {
                session.layoffProgressBar.Value = 0;
                session.layoffProgressBar.Text = "0%";
            }
        }

        public void setControls(bool val)
        {
            if (!val) { launchButton.BackColor = Color.LightSlateGray; }
            else { launchButton.BackColor = Color.MediumSeaGreen; }
            launchButton.Enabled = val;
            removeSessionButton.Enabled = val;
            addSessionButton.Enabled = val;
            dupeButton1.Enabled = val;
            dupeButton2.Enabled = val;
            launchOptionsButton.Enabled = val;
            abortAllButton.Visible = !val;
        }

        
        private async void launch_Click(object sender, EventArgs e)
        {
            if (!preLaunchCheck()){
                return;
            }
            this.TopMost = true;
            setControls(false);
            resetSessionProgress();
            statusModule.Text = "Rendering!";
            statusModule.BackColor = Color.Green;
            statusModule.Show();
            
            await sessionManager.launchSessions(sessionLayoutList.Controls);

            //Done
            setControls(true);
            this.TopMost = false;
            statusModule.Text = "Done!";
            statusModule.BackColor = SystemColors.Highlight;
            windowHider.restoreSFMWindowPostion("");

        }

        private void sfmOptions_Click(object sender, EventArgs e)
        {
            optionsForm optionsFormDialog = new optionsForm();
            optionsFormDialog.ShowDialog(this);
        }

        private void loadSessions()
        {
            StringCollection temp = Settings.Default.savedSessionData;
            int sessionCount = temp.Count /4; 
            if(sessionCount > 0) { sessionCountVisual.Show(); }
            
            for (int i = 0; i < sessionCount; i++)
            {
                AddNewSessionCtrlGroup();
            }
            foreach (SessionCtrlGroup session in sessionLayoutList.Controls)
            {
                session.startFrameValue=temp[0];
                session.endFrameValue = temp[1];
                session.projectFileValue = temp[2];
                session.outputDirValue = temp[3];
                for (int i = 0; i < 4; i++) temp.RemoveAt(0);
            }

        }
        private void saveSessions()
        {
            Settings.Default.savedSessionData = new System.Collections.Specialized.StringCollection();
            foreach (SessionCtrlGroup session in sessionLayoutList.Controls)
            {
                Settings.Default.savedSessionData.Add(session.startFrameValue);
                Settings.Default.savedSessionData.Add(session.endFrameValue);
                Settings.Default.savedSessionData.Add(session.projectFileValue);
                Settings.Default.savedSessionData.Add(session.outputDirValue);
            }
            Settings.Default.Save();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            windowHider.restoreSFMWindowPostion("");
            //lazy way to save, but itll do

            if (Settings.Default.rememberSessions) {  
                saveSessions(); 
            }
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void autoHideCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Settings.Default.minWarningSingle && autoHideCheckbox.Checked) {
                autoHideCheckbox.Checked = false;
                MessageBox.Show("This fake minimizes SFM when rendering, which involves moving it below the visible screen. " +
                    "SFM itself remembers window position however, so launching SFM normally next time it will be invisible.\n\n" +
                    "This program works around this issue by backing up the last known good position to restore it to, via it's registry key. " +
                    "After this program closes, or a render batch is complete, it will restore the key and fix this. " +
                    "If for whatever reason your SFM is still invisible, please consult the steam guide (it really shouldnt happen though)\n\n" +
                    "This messagebox is a one time notice, please click the checkbox again to enable.");
                Settings.Default.minWarningSingle = true;
            }
            if (autoHideCheckbox.Checked) { Settings.Default.autoHideSFM = true; }
            Settings.Default.Save();
        }

        private void SFM_MultiRender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                debugButton.Show();
            }
        }

        private void debugtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                debugButton.Show();
            }
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.minWarningSingle = false;
            windowHider windowHider = new windowHider();
            IntPtr a = (IntPtr)(1 << 4);
            MessageBox.Show(a.ToString());
        }



        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm settingsFormDialog = new settingsForm();
            settingsFormDialog.ShowDialog(this);
        }

        private void clearAllSessions_Click(object sender, EventArgs e)
        {
            sessionLayoutList.Controls.Clear();
            SESSION_TOTAL = 0;
            sessionCountVisual.Value = 0;
            sessionCountVisual.Hide();
        }

        private void abortAllButton_Click(object sender, EventArgs e)
        {
            sessionManager.abortAllNow();
        }
    }
}
