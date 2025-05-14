namespace SFM_MultiRender
{
    partial class SessionCtrlGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startFrame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endFrame = new System.Windows.Forms.TextBox();
            this.projectFile = new System.Windows.Forms.TextBox();
            this.outputDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sessionGroupBox = new MentQ.MentQGroupBox();
            this.layoffProgressBar = new MentQ.MentQProgressBar();
            this.sessionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startFrame
            // 
            this.startFrame.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFrame.Location = new System.Drawing.Point(8, 60);
            this.startFrame.Name = "startFrame";
            this.startFrame.Size = new System.Drawing.Size(95, 25);
            this.startFrame.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Frame";
            // 
            // endFrame
            // 
            this.endFrame.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endFrame.Location = new System.Drawing.Point(8, 114);
            this.endFrame.Name = "endFrame";
            this.endFrame.Size = new System.Drawing.Size(95, 25);
            this.endFrame.TabIndex = 3;
            // 
            // projectFile
            // 
            this.projectFile.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectFile.Location = new System.Drawing.Point(126, 60);
            this.projectFile.Name = "projectFile";
            this.projectFile.Size = new System.Drawing.Size(264, 25);
            this.projectFile.TabIndex = 5;
            // 
            // outputDir
            // 
            this.outputDir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDir.Location = new System.Drawing.Point(126, 114);
            this.outputDir.Name = "outputDir";
            this.outputDir.Size = new System.Drawing.Size(264, 25);
            this.outputDir.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Project File .dmx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output Dir+Img Name";
            // 
            // sessionGroupBox
            // 
            this.sessionGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sessionGroupBox.Closable = false;
            this.sessionGroupBox.Closed = false;
            this.sessionGroupBox.Controls.Add(this.layoffProgressBar);
            this.sessionGroupBox.Controls.Add(this.startFrame);
            this.sessionGroupBox.Controls.Add(this.label5);
            this.sessionGroupBox.Controls.Add(this.label2);
            this.sessionGroupBox.Controls.Add(this.label4);
            this.sessionGroupBox.Controls.Add(this.endFrame);
            this.sessionGroupBox.Controls.Add(this.outputDir);
            this.sessionGroupBox.Controls.Add(this.projectFile);
            this.sessionGroupBox.Controls.Add(this.label3);
            this.sessionGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sessionGroupBox.Icon = null;
            this.sessionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.sessionGroupBox.Name = "sessionGroupBox";
            this.sessionGroupBox.Size = new System.Drawing.Size(409, 189);
            this.sessionGroupBox.TabIndex = 9;
            this.sessionGroupBox.Text = "Session";
            this.sessionGroupBox.UpperColor = System.Drawing.Color.Empty;
            this.sessionGroupBox.Click += new System.EventHandler(this.mentQGroupBox1_Click);
            // 
            // layoffProgressBar
            // 
            this.layoffProgressBar.AlternateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.layoffProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.layoffProgressBar.CornerRounding = 5;
            this.layoffProgressBar.DiagonalLines = false;
            this.layoffProgressBar.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.layoffProgressBar.ForeColor = System.Drawing.Color.White;
            this.layoffProgressBar.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.layoffProgressBar.Location = new System.Drawing.Point(8, 153);
            this.layoffProgressBar.Name = "layoffProgressBar";
            this.layoffProgressBar.Size = new System.Drawing.Size(382, 25);
            this.layoffProgressBar.TabIndex = 9;
            this.layoffProgressBar.Text = "0%";
            this.layoffProgressBar.Underline = false;
            this.layoffProgressBar.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.layoffProgressBar.UnderlineSize = 2;
            // 
            // SessionCtrlGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.sessionGroupBox);
            this.Name = "SessionCtrlGroup";
            this.Size = new System.Drawing.Size(408, 188);
            this.Load += new System.EventHandler(this.SessionCtrlGroup_Load);
            this.sessionGroupBox.ResumeLayout(false);
            this.sessionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox startFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endFrame;
        private System.Windows.Forms.TextBox projectFile;
        private System.Windows.Forms.TextBox outputDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MentQ.MentQGroupBox sessionGroupBox;
        public MentQ.MentQProgressBar layoffProgressBar;
    }
}
