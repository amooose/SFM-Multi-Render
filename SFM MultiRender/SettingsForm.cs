using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SFM_MultiRender
{
    public partial class settingsForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public settingsForm()
        {
            InitializeComponent();
            mentQButton1.Text = Properties.Settings.Default.rememberSessions ? "Remember Sessions [Enabled]" :
                "Remember Sessions [Disabled]";
        }

        private void launchOptionsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            MessageBox.Show("Reset Done.");
        }

        private void mentQButton1_Click(object sender, EventArgs e)
        {
            windowHider windowHider = new windowHider();
            windowHider.restoreSFMWindowPostion(windowHider.stockInstallBackup);
            MessageBox.Show("Position Reset Done.");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(settingsPos, "Restores main window to STOCK install position." +
                "\nUseful if you somehow have an invisible window still.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Properties.Settings.Default.Save();
        }

        private void mentQInfoBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mentQButton1_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.rememberSessions = !Properties.Settings.Default.rememberSessions;
            Properties.Settings.Default.Save();
            mentQButton1.Text = Properties.Settings.Default.rememberSessions ? "Remember Sessions [Enabled]" :
                "Remember Sessions [Disabled]";
            
        }
    }
}
