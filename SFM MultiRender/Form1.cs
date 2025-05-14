
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SFM_MultiRender
{

    public partial class SFM_MultiRender : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static int SESSION_TOTAL = 0;

        public SFM_MultiRender()
        {
            InitializeComponent();

        }
        public bool autoHideCheckboxStatus
        {
            get => autoHideCheckbox.Checked;
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


        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Bottom;
        }

        static void FakeMinimizeWindowByTitle(string windowTitle)
        {
            IntPtr hWnd = FindWindow(null, windowTitle);

            if (hWnd == IntPtr.Zero)
            {
                Console.WriteLine("Window not found.");
                return;
            }

            // Get current size
            if (GetWindowRect(hWnd, out RECT rect))
            {
                int width = rect.Right - rect.Left;
                int height = rect.Bottom - rect.Top;

                // Move it just below the primary screen
                int offscreenY = Screen.PrimaryScreen.WorkingArea.Bottom + 100;

                MoveWindow(hWnd, rect.Left, offscreenY, width, height, true);
                Console.WriteLine("Window moved off-screen.");
            }
            else
            {
                Console.WriteLine("Failed to get window rect.");
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

        private void mentQInfoBox3_MouseDown(object sender, MouseEventArgs e)
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
            if (Properties.Settings.Default.sfmExe == "")
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
            SessionManager sessionManager = new SessionManager();
            await sessionManager.launchSessions(sessionLayoutList.Controls);
            setControls(true);
            
            statusModule.Text = "Done!";
            statusModule.BackColor = SystemColors.Highlight;

        }

        private void sfmOptions_Click(object sender, EventArgs e)
        {
            optionsForm optionsFormDialog = new optionsForm();
            optionsFormDialog.ShowDialog(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void debugtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
