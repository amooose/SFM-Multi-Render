using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFM_MultiRender
{
    public partial class optionsForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public optionsForm()
        {
            InitializeComponent();
            launchOptionsTextbox.Text = Properties.Settings.Default.launchArgs;
            sfmExeTextbox.Text = Properties.Settings.Default.sfmExe;
            launchOptionsTextbox.Select(launchOptionsTextbox.Text.Length, 0);

        }

        private void mentQButton8_Click(object sender, EventArgs e)
        {;
            Properties.Settings.Default.launchArgs = launchOptionsTextbox.Text;
            Properties.Settings.Default.sfmExe = sfmExeTextbox.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mentQInfoBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void optionsForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
