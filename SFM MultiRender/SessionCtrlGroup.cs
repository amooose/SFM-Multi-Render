using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFM_MultiRender
{
    public partial class SessionCtrlGroup : UserControl
    {
        
        public SessionCtrlGroup()
        {
            InitializeComponent();
        }

        private void SessionCtrlGroup_Load(object sender, EventArgs e)
        {

        }

        public string sessionNameValue
        {
            get => sessionGroupBox.Text;
            set => sessionGroupBox.Text = value;
        }
        public string projectFileValue
        {
            get => projectFile.Text;
            set => projectFile.Text = value;
        }
        public string outputDirValue
        {
            get => outputDir.Text;
            set => outputDir.Text = value;
        }
        public string startFrameValue
        {
            get => startFrame.Text;
            set => startFrame.Text = value;
        }
        public string endFrameValue
        {
            get => endFrame.Text;
            set => endFrame.Text = value;
        }
        private void mentQGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
