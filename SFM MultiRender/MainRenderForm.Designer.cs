namespace SFM_MultiRender
{
    partial class SFM_MultiRenderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFM_MultiRenderForm));
            this.sessionLayoutList = new System.Windows.Forms.FlowLayoutPanel();
            this.debugtxt = new System.Windows.Forms.TextBox();
            this.debugButton = new System.Windows.Forms.Button();
            this.sessionCountVisual = new MentQ.MentQEllipticalProgress();
            this.launchButton = new MentQ.MentQButton();
            this.mentQButton6 = new MentQ.MentQButton();
            this.mentQButton3 = new MentQ.MentQButton();
            this.removeSessionButton = new MentQ.MentQButton();
            this.addSessionButton = new MentQ.MentQButton();
            this.mentQGroupBox1 = new MentQ.MentQGroupBox();
            this.dupeButton2 = new MentQ.MentQButton();
            this.dupeButton1 = new MentQ.MentQButton();
            this.globalFrameEnd = new System.Windows.Forms.TextBox();
            this.globalFrameStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.launchOptionsButton = new MentQ.MentQButton();
            this.exitButton = new MentQ.MentQButton();
            this.minimizeButton = new MentQ.MentQButton();
            this.statusModule = new MentQ.MentQNotification();
            this.autoHideCheckbox = new MentQ.MentQCheckBox();
            this.creditLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainFormHeader = new MentQ.MentQInfoBox();
            this.mentQButton1 = new MentQ.MentQButton();
            this.mentQGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionLayoutList
            // 
            this.sessionLayoutList.AutoScroll = true;
            this.sessionLayoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sessionLayoutList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sessionLayoutList.Location = new System.Drawing.Point(12, 116);
            this.sessionLayoutList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sessionLayoutList.Name = "sessionLayoutList";
            this.sessionLayoutList.Size = new System.Drawing.Size(470, 582);
            this.sessionLayoutList.TabIndex = 0;
            // 
            // debugtxt
            // 
            this.debugtxt.Location = new System.Drawing.Point(488, 116);
            this.debugtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugtxt.Multiline = true;
            this.debugtxt.Name = "debugtxt";
            this.debugtxt.Size = new System.Drawing.Size(168, 320);
            this.debugtxt.TabIndex = 7;
            this.debugtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.debugtxt_KeyDown);
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(275, 710);
            this.debugButton.Margin = new System.Windows.Forms.Padding(4);
            this.debugButton.Name = "debugButton";
            this.debugButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.debugButton.Size = new System.Drawing.Size(100, 28);
            this.debugButton.TabIndex = 28;
            this.debugButton.Text = "debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Visible = false;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // sessionCountVisual
            // 
            this.sessionCountVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.sessionCountVisual.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionCountVisual.ForeColor = System.Drawing.Color.Black;
            this.sessionCountVisual.HatchBrushSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sessionCountVisual.HatchBrushStyle = System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal;
            this.sessionCountVisual.Location = new System.Drawing.Point(443, 71);
            this.sessionCountVisual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sessionCountVisual.Maximum = 10;
            this.sessionCountVisual.Name = "sessionCountVisual";
            this.sessionCountVisual.Size = new System.Drawing.Size(40, 43);
            this.sessionCountVisual.TabIndex = 31;
            this.sessionCountVisual.UseHatchBrush = false;
            this.sessionCountVisual.Visible = false;
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.launchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.ForeColor = System.Drawing.Color.White;
            this.launchButton.isSquare = false;
            this.launchButton.Location = new System.Drawing.Point(489, 706);
            this.launchButton.Margin = new System.Windows.Forms.Padding(4);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(167, 71);
            this.launchButton.TabIndex = 30;
            this.launchButton.Text = "Launch";
            this.launchButton.Underline = true;
            this.launchButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.launchButton.UnderlineSize = 4;
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.yPosAdjust = -5;
            this.launchButton.Click += new System.EventHandler(this.launch_Click);
            // 
            // mentQButton6
            // 
            this.mentQButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mentQButton6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton6.ForeColor = System.Drawing.Color.White;
            this.mentQButton6.isSquare = true;
            this.mentQButton6.Location = new System.Drawing.Point(665, -1);
            this.mentQButton6.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton6.Name = "mentQButton6";
            this.mentQButton6.Size = new System.Drawing.Size(57, 49);
            this.mentQButton6.TabIndex = 25;
            this.mentQButton6.Text = "‒";
            this.mentQButton6.Underline = true;
            this.mentQButton6.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton6.UnderlineSize = 4;
            this.mentQButton6.UseVisualStyleBackColor = false;
            this.mentQButton6.yPosAdjust = -5;
            // 
            // mentQButton3
            // 
            this.mentQButton3.BackColor = System.Drawing.Color.IndianRed;
            this.mentQButton3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton3.ForeColor = System.Drawing.Color.White;
            this.mentQButton3.isSquare = true;
            this.mentQButton3.Location = new System.Drawing.Point(723, -1);
            this.mentQButton3.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton3.Name = "mentQButton3";
            this.mentQButton3.Size = new System.Drawing.Size(57, 49);
            this.mentQButton3.TabIndex = 24;
            this.mentQButton3.Text = "x";
            this.mentQButton3.Underline = true;
            this.mentQButton3.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton3.UnderlineSize = 4;
            this.mentQButton3.UseVisualStyleBackColor = false;
            this.mentQButton3.yPosAdjust = -5;
            // 
            // removeSessionButton
            // 
            this.removeSessionButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeSessionButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSessionButton.ForeColor = System.Drawing.Color.White;
            this.removeSessionButton.isSquare = false;
            this.removeSessionButton.Location = new System.Drawing.Point(89, 709);
            this.removeSessionButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeSessionButton.Name = "removeSessionButton";
            this.removeSessionButton.Size = new System.Drawing.Size(69, 54);
            this.removeSessionButton.TabIndex = 23;
            this.removeSessionButton.Text = "-";
            this.removeSessionButton.Underline = true;
            this.removeSessionButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.removeSessionButton.UnderlineSize = 4;
            this.removeSessionButton.UseVisualStyleBackColor = false;
            this.removeSessionButton.yPosAdjust = -5;
            this.removeSessionButton.Click += new System.EventHandler(this.removeSession_Click);
            // 
            // addSessionButton
            // 
            this.addSessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.addSessionButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSessionButton.ForeColor = System.Drawing.Color.White;
            this.addSessionButton.isSquare = false;
            this.addSessionButton.Location = new System.Drawing.Point(12, 709);
            this.addSessionButton.Margin = new System.Windows.Forms.Padding(4);
            this.addSessionButton.Name = "addSessionButton";
            this.addSessionButton.Size = new System.Drawing.Size(69, 54);
            this.addSessionButton.TabIndex = 22;
            this.addSessionButton.Text = "+";
            this.addSessionButton.Underline = true;
            this.addSessionButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.addSessionButton.UnderlineSize = 4;
            this.addSessionButton.UseVisualStyleBackColor = false;
            this.addSessionButton.yPosAdjust = -5;
            this.addSessionButton.Click += new System.EventHandler(this.addSession_Click);
            // 
            // mentQGroupBox1
            // 
            this.mentQGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mentQGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mentQGroupBox1.Closable = false;
            this.mentQGroupBox1.Closed = false;
            this.mentQGroupBox1.Controls.Add(this.dupeButton2);
            this.mentQGroupBox1.Controls.Add(this.dupeButton1);
            this.mentQGroupBox1.Controls.Add(this.globalFrameEnd);
            this.mentQGroupBox1.Controls.Add(this.globalFrameStart);
            this.mentQGroupBox1.Controls.Add(this.label1);
            this.mentQGroupBox1.Controls.Add(this.label2);
            this.mentQGroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.mentQGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mentQGroupBox1.Icon = null;
            this.mentQGroupBox1.Location = new System.Drawing.Point(489, 442);
            this.mentQGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.mentQGroupBox1.Name = "mentQGroupBox1";
            this.mentQGroupBox1.Size = new System.Drawing.Size(168, 256);
            this.mentQGroupBox1.TabIndex = 18;
            this.mentQGroupBox1.Text = "Duplication";
            this.mentQGroupBox1.UpperColor = System.Drawing.Color.Empty;
            // 
            // dupeButton2
            // 
            this.dupeButton2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dupeButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dupeButton2.ForeColor = System.Drawing.Color.White;
            this.dupeButton2.isSquare = false;
            this.dupeButton2.Location = new System.Drawing.Point(17, 185);
            this.dupeButton2.Margin = new System.Windows.Forms.Padding(4);
            this.dupeButton2.Name = "dupeButton2";
            this.dupeButton2.Size = new System.Drawing.Size(133, 54);
            this.dupeButton2.TabIndex = 17;
            this.dupeButton2.Text = " Distribute\r\nAll Frames";
            this.dupeButton2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.dupeButton2.Underline = true;
            this.dupeButton2.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dupeButton2.UnderlineSize = 4;
            this.dupeButton2.UseVisualStyleBackColor = false;
            this.dupeButton2.yPosAdjust = 0;
            this.dupeButton2.Click += new System.EventHandler(this.distributeFramesButton_Click);
            // 
            // dupeButton1
            // 
            this.dupeButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dupeButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dupeButton1.ForeColor = System.Drawing.Color.White;
            this.dupeButton1.isSquare = false;
            this.dupeButton1.Location = new System.Drawing.Point(17, 52);
            this.dupeButton1.Margin = new System.Windows.Forms.Padding(4);
            this.dupeButton1.Name = "dupeButton1";
            this.dupeButton1.Size = new System.Drawing.Size(133, 54);
            this.dupeButton1.TabIndex = 16;
            this.dupeButton1.Text = "       All use\r\nSession 1 Path";
            this.dupeButton1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.dupeButton1.Underline = true;
            this.dupeButton1.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dupeButton1.UnderlineSize = 4;
            this.dupeButton1.UseVisualStyleBackColor = false;
            this.dupeButton1.yPosAdjust = 0;
            this.dupeButton1.Click += new System.EventHandler(this.dupeSession1Paths_Click);
            // 
            // globalFrameEnd
            // 
            this.globalFrameEnd.Location = new System.Drawing.Point(60, 151);
            this.globalFrameEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.globalFrameEnd.Name = "globalFrameEnd";
            this.globalFrameEnd.Size = new System.Drawing.Size(87, 26);
            this.globalFrameEnd.TabIndex = 3;
            this.globalFrameEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.globalFrameEnd_KeyPress);
            // 
            // globalFrameStart
            // 
            this.globalFrameStart.Location = new System.Drawing.Point(60, 123);
            this.globalFrameStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.globalFrameStart.Name = "globalFrameStart";
            this.globalFrameStart.Size = new System.Drawing.Size(87, 26);
            this.globalFrameStart.TabIndex = 4;
            this.globalFrameStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.globalFrameStart_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "End";
            // 
            // launchOptionsButton
            // 
            this.launchOptionsButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.launchOptionsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchOptionsButton.ForeColor = System.Drawing.Color.White;
            this.launchOptionsButton.isSquare = false;
            this.launchOptionsButton.Location = new System.Drawing.Point(383, 729);
            this.launchOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.launchOptionsButton.Name = "launchOptionsButton";
            this.launchOptionsButton.Size = new System.Drawing.Size(99, 50);
            this.launchOptionsButton.TabIndex = 18;
            this.launchOptionsButton.Text = "SFM Launch\r\n   Options";
            this.launchOptionsButton.Underline = true;
            this.launchOptionsButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.launchOptionsButton.UnderlineSize = 4;
            this.launchOptionsButton.UseVisualStyleBackColor = false;
            this.launchOptionsButton.yPosAdjust = 0;
            this.launchOptionsButton.Click += new System.EventHandler(this.sfmOptions_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.isSquare = true;
            this.exitButton.Location = new System.Drawing.Point(621, -1);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(53, 49);
            this.exitButton.TabIndex = 32;
            this.exitButton.Text = "x";
            this.exitButton.Underline = true;
            this.exitButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.exitButton.UnderlineSize = 4;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.yPosAdjust = -5;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.isSquare = true;
            this.minimizeButton.Location = new System.Drawing.Point(572, -1);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(53, 49);
            this.minimizeButton.TabIndex = 33;
            this.minimizeButton.Text = "‒";
            this.minimizeButton.Underline = true;
            this.minimizeButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.minimizeButton.UnderlineSize = 4;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.yPosAdjust = -5;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // statusModule
            // 
            this.statusModule.BackColor = System.Drawing.Color.Green;
            this.statusModule.EffectColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.statusModule.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusModule.ForeColor = System.Drawing.Color.White;
            this.statusModule.Location = new System.Drawing.Point(12, 76);
            this.statusModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusModule.Name = "statusModule";
            this.statusModule.Size = new System.Drawing.Size(147, 33);
            this.statusModule.Style = MentQ.Styles.Outlined;
            this.statusModule.TabIndex = 34;
            this.statusModule.Text = "Rendering! ";
            this.statusModule.TextAlignment = MentQ.MentQNotification.TextAlign.Center;
            this.statusModule.UnderlineSize = 6;
            this.statusModule.UseWaitCursor = true;
            this.statusModule.Visible = false;
            // 
            // autoHideCheckbox
            // 
            this.autoHideCheckbox.AutoSize = true;
            this.autoHideCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.autoHideCheckbox.Font = new System.Drawing.Font("Verdana", 7F);
            this.autoHideCheckbox.ForeColor = System.Drawing.Color.Black;
            this.autoHideCheckbox.Location = new System.Drawing.Point(491, 785);
            this.autoHideCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoHideCheckbox.Name = "autoHideCheckbox";
            this.autoHideCheckbox.Size = new System.Drawing.Size(166, 14);
            this.autoHideCheckbox.TabIndex = 35;
            this.autoHideCheckbox.Text = "Auto-hide SFM Sessions";
            this.autoHideCheckbox.UseVisualStyleBackColor = false;
            this.autoHideCheckbox.CheckedChanged += new System.EventHandler(this.autoHideCheckbox_CheckedChanged);
            // 
            // creditLabel
            // 
            this.creditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.creditLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.White;
            this.creditLabel.Location = new System.Drawing.Point(72, 6);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(137, 18);
            this.creditLabel.TabIndex = 36;
            this.creditLabel.Text = "an0nymooose\'s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SFM_MultiRender.Properties.Resources.gear;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(620, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // mainFormHeader
            // 
            this.mainFormHeader.AntiAliasImage = true;
            this.mainFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mainFormHeader.BackgroundImage = global::SFM_MultiRender.Properties.Resources.sfmicon;
            this.mainFormHeader.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.Scaled;
            this.mainFormHeader.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormHeader.ForeColor = System.Drawing.Color.White;
            this.mainFormHeader.ImageContainer = false;
            this.mainFormHeader.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainFormHeader.ImageTransparency = 255;
            this.mainFormHeader.isCenter = false;
            this.mainFormHeader.isClickable = false;
            this.mainFormHeader.Location = new System.Drawing.Point(0, -5);
            this.mainFormHeader.Margin = new System.Windows.Forms.Padding(4);
            this.mainFormHeader.Name = "mainFormHeader";
            this.mainFormHeader.Size = new System.Drawing.Size(795, 74);
            this.mainFormHeader.TabIndex = 21;
            this.mainFormHeader.Text = "      SFM Multi-Render v1.0";
            this.mainFormHeader.Title = "";
            this.mainFormHeader.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mainFormHeader.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mainFormHeader.UnderlineSize = 4;
            this.mainFormHeader.yPosAdjust = 7;
            this.mainFormHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainRenderFormHeader_MouseDown);
            // 
            // mentQButton1
            // 
            this.mentQButton1.BackColor = System.Drawing.Color.IndianRed;
            this.mentQButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton1.ForeColor = System.Drawing.Color.White;
            this.mentQButton1.isSquare = false;
            this.mentQButton1.Location = new System.Drawing.Point(166, 734);
            this.mentQButton1.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton1.Name = "mentQButton1";
            this.mentQButton1.Size = new System.Drawing.Size(82, 29);
            this.mentQButton1.TabIndex = 38;
            this.mentQButton1.Text = "Clear all";
            this.mentQButton1.Underline = true;
            this.mentQButton1.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton1.UnderlineSize = 4;
            this.mentQButton1.UseVisualStyleBackColor = false;
            this.mentQButton1.yPosAdjust = 0;
            this.mentQButton1.Click += new System.EventHandler(this.mentQButton1_Click);
            // 
            // SFM_MultiRenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(672, 811);
            this.Controls.Add(this.mentQButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.autoHideCheckbox);
            this.Controls.Add(this.statusModule);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.launchOptionsButton);
            this.Controls.Add(this.sessionCountVisual);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.mentQButton6);
            this.Controls.Add(this.mentQButton3);
            this.Controls.Add(this.removeSessionButton);
            this.Controls.Add(this.addSessionButton);
            this.Controls.Add(this.mainFormHeader);
            this.Controls.Add(this.mentQGroupBox1);
            this.Controls.Add(this.debugtxt);
            this.Controls.Add(this.sessionLayoutList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SFM_MultiRenderForm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 3, 2);
            this.Text = "       SFM Multi-Render 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SFM_MultiRender_KeyDown);
            this.mentQGroupBox1.ResumeLayout(false);
            this.mentQGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox globalFrameEnd;
        private System.Windows.Forms.TextBox globalFrameStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MentQ.MentQButton dupeButton1;
        private MentQ.MentQButton dupeButton2;
        private MentQ.MentQGroupBox mentQGroupBox1;
        private MentQ.MentQInfoBox mainFormHeader;
        private MentQ.MentQButton addSessionButton;
        private MentQ.MentQButton removeSessionButton;
        private MentQ.MentQButton mentQButton3;
        private MentQ.MentQButton mentQButton6;
        private System.Windows.Forms.Button debugButton;
        private MentQ.MentQButton launchButton;
        private MentQ.MentQEllipticalProgress sessionCountVisual;
        private MentQ.MentQButton launchOptionsButton;
        private MentQ.MentQButton exitButton;
        private MentQ.MentQButton minimizeButton;
        public System.Windows.Forms.FlowLayoutPanel sessionLayoutList;
        public System.Windows.Forms.TextBox debugtxt;
        public MentQ.MentQCheckBox autoHideCheckbox;
        public MentQ.MentQNotification statusModule;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MentQ.MentQButton mentQButton1;
    }
}

