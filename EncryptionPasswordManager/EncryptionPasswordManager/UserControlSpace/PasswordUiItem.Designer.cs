namespace EncryptionPasswordManager.UserControlSpace
{
    partial class PasswordUiItem
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
            this.UserLbl = new System.Windows.Forms.Label();
            this.UsernameField = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.CopyPasswordBtn = new System.Windows.Forms.Button();
            this.isHashedLbl = new System.Windows.Forms.Label();
            this.isHashedCb = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(9, 4);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(61, 13);
            this.UserLbl.TabIndex = 0;
            this.UserLbl.Text = "Username: ";
            // 
            // UsernameField
            // 
            this.UsernameField.AutoSize = true;
            this.UsernameField.Location = new System.Drawing.Point(72, 4);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(16, 13);
            this.UsernameField.TabIndex = 1;
            this.UsernameField.Text = "...";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Location = new System.Drawing.Point(9, 27);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(56, 13);
            this.PassLbl.TabIndex = 2;
            this.PassLbl.Text = "Password:";
            // 
            // PasswordField
            // 
            this.PasswordField.AutoSize = true;
            this.PasswordField.Location = new System.Drawing.Point(72, 27);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(16, 13);
            this.PasswordField.TabIndex = 3;
            this.PasswordField.Text = "...";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(111, 48);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(81, 13);
            this.linkLabel.TabIndex = 4;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Link to Website";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // CopyPasswordBtn
            // 
            this.CopyPasswordBtn.Location = new System.Drawing.Point(7, 43);
            this.CopyPasswordBtn.Name = "CopyPasswordBtn";
            this.CopyPasswordBtn.Size = new System.Drawing.Size(98, 23);
            this.CopyPasswordBtn.TabIndex = 5;
            this.CopyPasswordBtn.Text = "Copy Password";
            this.CopyPasswordBtn.UseVisualStyleBackColor = true;
            this.CopyPasswordBtn.Click += new System.EventHandler(this.CopyPasswordBtn_Click);
            // 
            // isHashedLbl
            // 
            this.isHashedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isHashedLbl.AutoSize = true;
            this.isHashedLbl.Location = new System.Drawing.Point(358, 48);
            this.isHashedLbl.Name = "isHashedLbl";
            this.isHashedLbl.Size = new System.Drawing.Size(47, 13);
            this.isHashedLbl.TabIndex = 6;
            this.isHashedLbl.Text = "Hashed:";
            // 
            // isHashedCb
            // 
            this.isHashedCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isHashedCb.AutoSize = true;
            this.isHashedCb.Enabled = false;
            this.isHashedCb.Location = new System.Drawing.Point(402, 48);
            this.isHashedCb.Name = "isHashedCb";
            this.isHashedCb.Size = new System.Drawing.Size(15, 14);
            this.isHashedCb.TabIndex = 7;
            this.isHashedCb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // PasswordUiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.isHashedCb);
            this.Controls.Add(this.isHashedLbl);
            this.Controls.Add(this.CopyPasswordBtn);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.groupBox1);
            this.Name = "PasswordUiItem";
            this.Size = new System.Drawing.Size(440, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label UsernameField;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label PasswordField;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Button CopyPasswordBtn;
        private System.Windows.Forms.Label isHashedLbl;
        private System.Windows.Forms.CheckBox isHashedCb;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
