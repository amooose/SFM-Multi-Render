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
            this.posToolTip = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exitButton = new MentQ.MentQButton();
            this.mentQInfoBox3 = new MentQ.MentQInfoBox();
            this.SuspendLayout();
            // 
            // launchOptionsButton
            // 
            this.launchOptionsButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.launchOptionsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchOptionsButton.ForeColor = System.Drawing.Color.White;
            this.launchOptionsButton.isSquare = false;
            this.launchOptionsButton.Location = new System.Drawing.Point(13, 82);
            this.launchOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.launchOptionsButton.Name = "launchOptionsButton";
            this.launchOptionsButton.Size = new System.Drawing.Size(214, 46);
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
            this.settingsPos.Location = new System.Drawing.Point(13, 145);
            this.settingsPos.Margin = new System.Windows.Forms.Padding(4);
            this.settingsPos.Name = "settingsPos";
            this.settingsPos.Size = new System.Drawing.Size(214, 46);
            this.settingsPos.TabIndex = 20;
            this.settingsPos.Text = "      Reset SFM window\r\npostion registry to default";
            this.settingsPos.Underline = true;
            this.settingsPos.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.settingsPos.UnderlineSize = 4;
            this.settingsPos.UseVisualStyleBackColor = false;
            this.settingsPos.yPosAdjust = 0;
            this.settingsPos.Click += new System.EventHandler(this.mentQButton1_Click);
            // 
            // posToolTip
            // 
            this.posToolTip.AutoSize = true;
            this.posToolTip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.posToolTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posToolTip.Location = new System.Drawing.Point(234, 161);
            this.posToolTip.Name = "posToolTip";
            this.posToolTip.Size = new System.Drawing.Size(16, 18);
            this.posToolTip.TabIndex = 21;
            this.posToolTip.Text = "?";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 61);
            this.flowLayoutPanel1.TabIndex = 22;
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
            this.mentQInfoBox3.BackgroundImage = global::SFM_MultiRender.Properties.Resources.sfm_multi;
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
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(473, 241);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mentQInfoBox3);
            this.Controls.Add(this.posToolTip);
            this.Controls.Add(this.settingsPos);
            this.Controls.Add(this.launchOptionsButton);
            this.Controls.Add(this.flowLayoutPanel1);
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
        private System.Windows.Forms.Label posToolTip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MentQ.MentQButton exitButton;
        private MentQ.MentQInfoBox mentQInfoBox3;
    }
}