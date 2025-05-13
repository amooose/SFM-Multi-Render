namespace SFM_MultiRender
{
    partial class optionsForm
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
            this.launchOptionsTextbox = new System.Windows.Forms.TextBox();
            this.mentQButton8 = new MentQ.MentQButton();
            this.mentQInfoBox3 = new MentQ.MentQInfoBox();
            this.exitButton = new MentQ.MentQButton();
            this.sfmExeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // launchOptionsTextbox
            // 
            this.launchOptionsTextbox.Location = new System.Drawing.Point(12, 114);
            this.launchOptionsTextbox.Multiline = true;
            this.launchOptionsTextbox.Name = "launchOptionsTextbox";
            this.launchOptionsTextbox.Size = new System.Drawing.Size(628, 96);
            this.launchOptionsTextbox.TabIndex = 0;
            // 
            // mentQButton8
            // 
            this.mentQButton8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mentQButton8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton8.ForeColor = System.Drawing.Color.White;
            this.mentQButton8.isSquare = false;
            this.mentQButton8.Location = new System.Drawing.Point(247, 289);
            this.mentQButton8.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton8.Name = "mentQButton8";
            this.mentQButton8.Size = new System.Drawing.Size(135, 44);
            this.mentQButton8.TabIndex = 19;
            this.mentQButton8.Text = "OK";
            this.mentQButton8.Underline = true;
            this.mentQButton8.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton8.UnderlineSize = 4;
            this.mentQButton8.UseVisualStyleBackColor = false;
            this.mentQButton8.yPosAdjust = 0;
            this.mentQButton8.Click += new System.EventHandler(this.mentQButton8_Click);
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
            this.mentQInfoBox3.Location = new System.Drawing.Point(0, -4);
            this.mentQInfoBox3.Margin = new System.Windows.Forms.Padding(4);
            this.mentQInfoBox3.Name = "mentQInfoBox3";
            this.mentQInfoBox3.Size = new System.Drawing.Size(795, 74);
            this.mentQInfoBox3.TabIndex = 22;
            this.mentQInfoBox3.Text = "      SFM Launch Args";
            this.mentQInfoBox3.Title = "";
            this.mentQInfoBox3.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBox3.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBox3.UnderlineSize = 4;
            this.mentQInfoBox3.yPosAdjust = 7;
            this.mentQInfoBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mentQInfoBox3_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.isSquare = true;
            this.exitButton.Location = new System.Drawing.Point(601, -4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 49);
            this.exitButton.TabIndex = 33;
            this.exitButton.Text = "x";
            this.exitButton.Underline = true;
            this.exitButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.exitButton.UnderlineSize = 4;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.yPosAdjust = -5;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sfmExeTextbox
            // 
            this.sfmExeTextbox.Location = new System.Drawing.Point(12, 244);
            this.sfmExeTextbox.Multiline = true;
            this.sfmExeTextbox.Name = "sfmExeTextbox";
            this.sfmExeTextbox.Size = new System.Drawing.Size(628, 38);
            this.sfmExeTextbox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "SFM .exe path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "SFM Launch arguments";
            // 
            // optionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sfmExeTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mentQInfoBox3);
            this.Controls.Add(this.mentQButton8);
            this.Controls.Add(this.launchOptionsTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "optionsForm";
            this.Text = "optionsForm";
            this.Load += new System.EventHandler(this.optionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MentQ.MentQButton mentQButton8;
        public System.Windows.Forms.TextBox launchOptionsTextbox;
        private MentQ.MentQInfoBox mentQInfoBox3;
        private MentQ.MentQButton exitButton;
        public System.Windows.Forms.TextBox sfmExeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}