namespace SFM_MultiRender
{
    partial class settingsForm
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
            this.components = new System.ComponentModel.Container();
            this.launchOptionsButton = new MentQ.MentQButton();
            this.settingsPos = new MentQ.MentQButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new MentQ.MentQButton();
            this.mentQInfoBox3 = new MentQ.MentQInfoBox();
            this.mentQButton1 = new MentQ.MentQButton();
            this.coreSeqCheckbox = new MentQ.MentQCheckBox();
            this.SuspendLayout();
            // 
            // launchOptionsButton
            // 
            this.launchOptionsButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.launchOptionsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchOptionsButton.ForeColor = System.Drawing.Color.White;
            this.launchOptionsButton.isSquare = false;
            this.launchOptionsButton.Location = new System.Drawing.Point(116, 82);
            this.launchOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.launchOptionsButton.Name = "launchOptionsButton";
            this.launchOptionsButton.Size = new System.Drawing.Size(227, 46);
            this.launchOptionsButton.TabIndex = 19;
            this.launchOptionsButton.Text = "Reset all MultiRender settings";
            this.launchOptionsButton.Underline = true;
            this.launchOptionsButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.launchOptionsButton.UnderlineSize = 4;
            this.launchOptionsButton.UseVisualStyleBackColor = false;
            this.launchOptionsButton.yPosAdjust = 0;
            this.launchOptionsButton.Click += new System.EventHandler(this.launchOptionsButton_Click);
            // 
            // settingsPos
            // 
            this.settingsPos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.settingsPos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsPos.ForeColor = System.Drawing.Color.White;
            this.settingsPos.isSquare = false;
            this.settingsPos.Location = new System.Drawing.Point(116, 145);
            this.settingsPos.Margin = new System.Windows.Forms.Padding(4);
            this.settingsPos.Name = "settingsPos";
            this.settingsPos.Size = new System.Drawing.Size(227, 46);
            this.settingsPos.TabIndex = 20;
            this.settingsPos.Text = "      Reset SFM window\r\npostion registry to default";
            this.settingsPos.Underline = true;
            this.settingsPos.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.settingsPos.UnderlineSize = 4;
            this.settingsPos.UseVisualStyleBackColor = false;
            this.settingsPos.yPosAdjust = 0;
            this.settingsPos.Click += new System.EventHandler(this.mentQButton1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.isSquare = true;
            this.exitButton.Location = new System.Drawing.Point(421, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 49);
            this.exitButton.TabIndex = 35;
            this.exitButton.Text = "x";
            this.exitButton.Underline = true;
            this.exitButton.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.exitButton.UnderlineSize = 4;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.yPosAdjust = -5;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mentQInfoBox3
            // 
            this.mentQInfoBox3.AntiAliasImage = true;
            this.mentQInfoBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.mentQInfoBox3.BackgroundImage = global::SFM_MultiRender.Properties.Resources.sfmicon;
            this.mentQInfoBox3.BackgroundImageLayout = MentQ.MentQInfoBox.Iconlayout.Scaled;
            this.mentQInfoBox3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQInfoBox3.ForeColor = System.Drawing.Color.White;
            this.mentQInfoBox3.ImageContainer = false;
            this.mentQInfoBox3.ImageContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mentQInfoBox3.ImageTransparency = 255;
            this.mentQInfoBox3.isCenter = false;
            this.mentQInfoBox3.isClickable = false;
            this.mentQInfoBox3.Location = new System.Drawing.Point(-2, 0);
            this.mentQInfoBox3.Margin = new System.Windows.Forms.Padding(4);
            this.mentQInfoBox3.Name = "mentQInfoBox3";
            this.mentQInfoBox3.Size = new System.Drawing.Size(480, 74);
            this.mentQInfoBox3.TabIndex = 34;
            this.mentQInfoBox3.Text = "      Settings";
            this.mentQInfoBox3.Title = "";
            this.mentQInfoBox3.Underline = MentQ.MentQInfoBox.UnderlineStyle.Full;
            this.mentQInfoBox3.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQInfoBox3.UnderlineSize = 4;
            this.mentQInfoBox3.yPosAdjust = 7;
            this.mentQInfoBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mentQInfoBox3_MouseDown);
            // 
            // mentQButton1
            // 
            this.mentQButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mentQButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentQButton1.ForeColor = System.Drawing.Color.White;
            this.mentQButton1.isSquare = false;
            this.mentQButton1.Location = new System.Drawing.Point(116, 208);
            this.mentQButton1.Margin = new System.Windows.Forms.Padding(4);
            this.mentQButton1.Name = "mentQButton1";
            this.mentQButton1.Size = new System.Drawing.Size(227, 46);
            this.mentQButton1.TabIndex = 36;
            this.mentQButton1.Text = "Remember Sessions [Disabled]";
            this.mentQButton1.Underline = true;
            this.mentQButton1.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mentQButton1.UnderlineSize = 4;
            this.mentQButton1.UseVisualStyleBackColor = false;
            this.mentQButton1.yPosAdjust = 0;
            this.mentQButton1.Click += new System.EventHandler(this.mentQButton1_Click_1);
            // 
            // coreSeqCheckbox
            // 
            this.coreSeqCheckbox.AutoSize = true;
            this.coreSeqCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.coreSeqCheckbox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coreSeqCheckbox.ForeColor = System.Drawing.Color.Black;
            this.coreSeqCheckbox.Location = new System.Drawing.Point(123, 275);
            this.coreSeqCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coreSeqCheckbox.Name = "coreSeqCheckbox";
            this.coreSeqCheckbox.Size = new System.Drawing.Size(213, 14);
            this.coreSeqCheckbox.TabIndex = 37;
            this.coreSeqCheckbox.Text = "Sequentially distribute cores";
            this.coreSeqCheckbox.UseVisualStyleBackColor = false;
            this.coreSeqCheckbox.CheckedChanged += new System.EventHandler(this.autoHideCheckbox_CheckedChanged);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(473, 310);
            this.Controls.Add(this.coreSeqCheckbox);
            this.Controls.Add(this.mentQButton1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mentQInfoBox3);
            this.Controls.Add(this.settingsPos);
            this.Controls.Add(this.launchOptionsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MentQ.MentQButton launchOptionsButton;
        private MentQ.MentQButton settingsPos;
        private System.Windows.Forms.ToolTip toolTip1;
        private MentQ.MentQButton exitButton;
        private MentQ.MentQInfoBox mentQInfoBox3;
        private MentQ.MentQButton mentQButton1;
        public MentQ.MentQCheckBox coreSeqCheckbox;
    }
}