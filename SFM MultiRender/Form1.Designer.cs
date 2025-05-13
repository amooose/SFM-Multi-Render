namespace SFM_MultiRender
{
    partial class SFM_MultiRender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFM_MultiRender));
            this.sessionLayoutList = new System.Windows.Forms.FlowLayoutPanel();
            this.debugtxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sessionCountVisual = new MentQ.MentQEllipticalProgress();
            this.mentQButton7 = new MentQ.MentQButton();
            this.mentQButton6 = new MentQ.MentQButton();
            this.mentQButton3 = new MentQ.MentQButton();
            this.mentQButton5 = new MentQ.MentQButton();
            this.mentQButton4 = new MentQ.MentQButton();
            this.mentQGroupBox1 = new MentQ.MentQGroupBox();
            this.mentQButton2 = new MentQ.MentQButton();
            this.mentQButton1 = new MentQ.MentQButton();
            this.globalFrameEnd = new System.Windows.Forms.TextBox();
            this.globalFrameStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mentQButton8 = new MentQ.MentQButton();
            this.exitButton = new MentQ.MentQButton();
            this.minimizeButton = new MentQ.MentQButton();
            this.mentQInfoBox3 = new MentQ.MentQInfoBox();
            this.mentQGroupBox1.SuspendLayout();
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
            this.sessionLayoutList.Size = new System.Drawing.Size(470, 587);
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
            this.debugtxt.TextChanged += new System.EventHandler(this.debugtxt_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 714);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 28;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sessionCountVisual
            // 
            this.sessionCountVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.sessionCountVisual.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionCountVisual.ForeColor = System.Drawing.Color.Black;
            this.sessionCountVisual.HatchBrushSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sessionCountVisual.HatchBrushStyle = System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal;
            this.sessionCountVisual.Location = new System.Drawing.Point(442, 71);
            this.sessionCountVisual.Maximum = 10;
            this.sessionCountVisual.Name = "sessionCountVisual";
            this.sessionCountVisual.Size = new System.Drawing.Size(40, 43);
            this.sessionCountVisual.TabIndex = 31;
            this.sessionCountVisual.UseHatchBrush = false;
            // 
            // mentQButton7
            // 
            this.mentQButton7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mentQButton7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton7.ForeColor = System.Drawing.Color.White;
            this.mentQButton7.isSquare = false;
            this.mentQButton7.Location = new System.Drawing.Point(489, 706);
            this.mentQButton7.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton7.Name = "mentQButton7";
            this.mentQButton7.Size = new System.Drawing.Size(167, 72);
            this.mentQButton7.TabIndex = 30;
            this.mentQButton7.Text = "Launch";
            this.mentQButton7.Underline = true;
            this.mentQButton7.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton7.UnderlineSize = 4;
            this.mentQButton7.UseVisualStyleBackColor = false;
            this.mentQButton7.yPosAdjust = -5;
            this.mentQButton7.Click += new System.EventHandler(this.launch_Click);
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
            // mentQButton5
            // 
            this.mentQButton5.BackColor = System.Drawing.Color.IndianRed;
            this.mentQButton5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton5.ForeColor = System.Drawing.Color.White;
            this.mentQButton5.isSquare = false;
            this.mentQButton5.Location = new System.Drawing.Point(89, 709);
            this.mentQButton5.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton5.Name = "mentQButton5";
            this.mentQButton5.Size = new System.Drawing.Size(69, 54);
            this.mentQButton5.TabIndex = 23;
            this.mentQButton5.Text = "-";
            this.mentQButton5.Underline = true;
            this.mentQButton5.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton5.UnderlineSize = 4;
            this.mentQButton5.UseVisualStyleBackColor = false;
            this.mentQButton5.yPosAdjust = -5;
            this.mentQButton5.Click += new System.EventHandler(this.removeSession_Click);
            // 
            // mentQButton4
            // 
            this.mentQButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQButton4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton4.ForeColor = System.Drawing.Color.White;
            this.mentQButton4.isSquare = false;
            this.mentQButton4.Location = new System.Drawing.Point(12, 709);
            this.mentQButton4.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton4.Name = "mentQButton4";
            this.mentQButton4.Size = new System.Drawing.Size(69, 54);
            this.mentQButton4.TabIndex = 22;
            this.mentQButton4.Text = "+";
            this.mentQButton4.Underline = true;
            this.mentQButton4.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton4.UnderlineSize = 4;
            this.mentQButton4.UseVisualStyleBackColor = false;
            this.mentQButton4.yPosAdjust = -5;
            this.mentQButton4.Click += new System.EventHandler(this.addSession_Click);
            // 
            // mentQGroupBox1
            // 
            this.mentQGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mentQGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mentQGroupBox1.Closable = false;
            this.mentQGroupBox1.Closed = false;
            this.mentQGroupBox1.Controls.Add(this.mentQButton2);
            this.mentQGroupBox1.Controls.Add(this.mentQButton1);
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
            // mentQButton2
            // 
            this.mentQButton2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mentQButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton2.ForeColor = System.Drawing.Color.White;
            this.mentQButton2.isSquare = false;
            this.mentQButton2.Location = new System.Drawing.Point(17, 185);
            this.mentQButton2.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton2.Name = "mentQButton2";
            this.mentQButton2.Size = new System.Drawing.Size(133, 54);
            this.mentQButton2.TabIndex = 17;
            this.mentQButton2.Text = " Distribute\r\nAll Frames";
            this.mentQButton2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mentQButton2.Underline = true;
            this.mentQButton2.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton2.UnderlineSize = 4;
            this.mentQButton2.UseVisualStyleBackColor = false;
            this.mentQButton2.yPosAdjust = 0;
            this.mentQButton2.Click += new System.EventHandler(this.distributeFramesButton_Click);
            // 
            // mentQButton1
            // 
            this.mentQButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mentQButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton1.ForeColor = System.Drawing.Color.White;
            this.mentQButton1.isSquare = false;
            this.mentQButton1.Location = new System.Drawing.Point(17, 52);
            this.mentQButton1.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton1.Name = "mentQButton1";
            this.mentQButton1.Size = new System.Drawing.Size(133, 54);
            this.mentQButton1.TabIndex = 16;
            this.mentQButton1.Text = "       All use\r\nSession 1 Path";
            this.mentQButton1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mentQButton1.Underline = true;
            this.mentQButton1.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton1.UnderlineSize = 4;
            this.mentQButton1.UseVisualStyleBackColor = false;
            this.mentQButton1.yPosAdjust = 0;
            this.mentQButton1.Click += new System.EventHandler(this.dupeSession1Paths_Click);
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
            // mentQButton8
            // 
            this.mentQButton8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mentQButton8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton8.ForeColor = System.Drawing.Color.White;
            this.mentQButton8.isSquare = false;
            this.mentQButton8.Location = new System.Drawing.Point(384, 728);
            this.mentQButton8.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton8.Name = "mentQButton8";
            this.mentQButton8.Size = new System.Drawing.Size(98, 50);
            this.mentQButton8.TabIndex = 18;
            this.mentQButton8.Text = "SFM Launch\r\n   Options";
            this.mentQButton8.Underline = true;
            this.mentQButton8.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton8.UnderlineSize = 4;
            this.mentQButton8.UseVisualStyleBackColor = false;
            this.mentQButton8.yPosAdjust = 0;
            this.mentQButton8.Click += new System.EventHandler(this.sfmOptions_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.isSquare = true;
            this.exitButton.Location = new System.Drawing.Point(613, -1);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 49);
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
            this.minimizeButton.Location = new System.Drawing.Point(560, -1);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(54, 49);
            this.minimizeButton.TabIndex = 33;
            this.minimizeButton.Text = "‒";
            this.minimizeButton.Underline = true;
            this.minimizeButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.minimizeButton.UnderlineSize = 4;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.yPosAdjust = -5;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // mentQInfoBox3
            // 
            this.mentQInfoBox3.AntiAliasImage = true;
            this.mentQInfoBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQInfoBox3.BackgroundImage = global::SFM_MultiRender.Properties.Resources.sfm_multi;
            this.mentQInfoBox3.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.Scaled;
            this.mentQInfoBox3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQInfoBox3.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBox3.ImageContainer = false;
            this.mentQInfoBox3.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBox3.ImageTransparency = 255;
            this.mentQInfoBox3.isCenter = false;
            this.mentQInfoBox3.isClickable = false;
            this.mentQInfoBox3.Location = new System.Drawing.Point(0, -5);
            this.mentQInfoBox3.Margin = new System.Windows.Forms.Padding(4);
            this.mentQInfoBox3.Name = "mentQInfoBox3";
            this.mentQInfoBox3.Size = new System.Drawing.Size(795, 74);
            this.mentQInfoBox3.TabIndex = 21;
            this.mentQInfoBox3.Text = "      SFM Multi-Render v1.0";
            this.mentQInfoBox3.Title = "";
            this.mentQInfoBox3.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBox3.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBox3.UnderlineSize = 4;
            this.mentQInfoBox3.yPosAdjust = 7;
            this.mentQInfoBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mentQInfoBox3_MouseDown);
            // 
            // SFM_MultiRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 796);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mentQButton8);
            this.Controls.Add(this.sessionCountVisual);
            this.Controls.Add(this.mentQButton7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mentQButton6);
            this.Controls.Add(this.mentQButton3);
            this.Controls.Add(this.mentQButton5);
            this.Controls.Add(this.mentQButton4);
            this.Controls.Add(this.mentQInfoBox3);
            this.Controls.Add(this.mentQGroupBox1);
            this.Controls.Add(this.debugtxt);
            this.Controls.Add(this.sessionLayoutList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SFM_MultiRender";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 3, 2);
            this.Text = "       SFM Multi-Render 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mentQGroupBox1.ResumeLayout(false);
            this.mentQGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox globalFrameEnd;
        private System.Windows.Forms.TextBox globalFrameStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MentQ.MentQButton mentQButton1;
        private MentQ.MentQButton mentQButton2;
        private MentQ.MentQGroupBox mentQGroupBox1;
        private MentQ.MentQInfoBox mentQInfoBox3;
        private MentQ.MentQButton mentQButton4;
        private MentQ.MentQButton mentQButton5;
        private MentQ.MentQButton mentQButton3;
        private MentQ.MentQButton mentQButton6;
        private System.Windows.Forms.Button button3;
        private MentQ.MentQButton mentQButton7;
        private MentQ.MentQEllipticalProgress sessionCountVisual;
        private MentQ.MentQButton mentQButton8;
        private MentQ.MentQButton exitButton;
        private MentQ.MentQButton minimizeButton;
        public System.Windows.Forms.FlowLayoutPanel sessionLayoutList;
        public System.Windows.Forms.TextBox debugtxt;
    }
}

