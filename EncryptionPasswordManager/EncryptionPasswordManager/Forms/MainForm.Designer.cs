namespace EncryptionPasswordManager.Forms
{
    partial class MainForm
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
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.QuickEncryptBtn = new System.Windows.Forms.Button();
            this.DelPassBtn = new System.Windows.Forms.Button();
            this.NewPassBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordPanel.AutoScroll = true;
            this.PasswordPanel.AutoSize = true;
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PasswordPanel.Location = new System.Drawing.Point(218, 12);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(570, 426);
            this.PasswordPanel.TabIndex = 1;
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoSize = true;
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.QuickEncryptBtn);
            this.ControlPanel.Controls.Add(this.DelPassBtn);
            this.ControlPanel.Controls.Add(this.NewPassBtn);
            this.ControlPanel.Controls.Add(this.SearchBtn);
            this.ControlPanel.Controls.Add(this.SearchTextBox);
            this.ControlPanel.Location = new System.Drawing.Point(12, 12);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(200, 426);
            this.ControlPanel.TabIndex = 2;
            // 
            // QuickEncryptBtn
            // 
            this.QuickEncryptBtn.Location = new System.Drawing.Point(3, 109);
            this.QuickEncryptBtn.Name = "QuickEncryptBtn";
            this.QuickEncryptBtn.Size = new System.Drawing.Size(194, 23);
            this.QuickEncryptBtn.TabIndex = 4;
            this.QuickEncryptBtn.Text = "Quick Encrypt";
            this.QuickEncryptBtn.UseVisualStyleBackColor = true;
            this.QuickEncryptBtn.Click += new System.EventHandler(this.QuickEncryptBtn_Click);
            // 
            // DelPassBtn
            // 
            this.DelPassBtn.Location = new System.Drawing.Point(3, 80);
            this.DelPassBtn.Name = "DelPassBtn";
            this.DelPassBtn.Size = new System.Drawing.Size(194, 23);
            this.DelPassBtn.TabIndex = 3;
            this.DelPassBtn.Text = "Delete Password";
            this.DelPassBtn.UseVisualStyleBackColor = true;
            this.DelPassBtn.Click += new System.EventHandler(this.DelPassBtn_Click);
            // 
            // NewPassBtn
            // 
            this.NewPassBtn.Location = new System.Drawing.Point(3, 51);
            this.NewPassBtn.Name = "NewPassBtn";
            this.NewPassBtn.Size = new System.Drawing.Size(194, 23);
            this.NewPassBtn.TabIndex = 2;
            this.NewPassBtn.Text = "Make New Password";
            this.NewPassBtn.UseVisualStyleBackColor = true;
            this.NewPassBtn.Click += new System.EventHandler(this.NewPassBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(147, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(50, 20);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(3, 25);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(144, 20);
            this.SearchTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search For Link";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.PasswordPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button QuickEncryptBtn;
        private System.Windows.Forms.Button DelPassBtn;
        private System.Windows.Forms.Button NewPassBtn;
        private System.Windows.Forms.Label label1;
    }
}