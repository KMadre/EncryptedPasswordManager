namespace EncryptionPasswordManager.Forms
{
    partial class PasswordCreationForm
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
            this.PWDetailGroup = new System.Windows.Forms.GroupBox();
            this.DoublePasswordText = new System.Windows.Forms.TextBox();
            this.doublePasswordCb = new System.Windows.Forms.CheckBox();
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AESRb = new System.Windows.Forms.RadioButton();
            this.HashingRB = new System.Windows.Forms.RadioButton();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailGroup = new System.Windows.Forms.GroupBox();
            this.GenIvBtn = new System.Windows.Forms.Button();
            this.AesIvTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genAesBtn = new System.Windows.Forms.Button();
            this.AesKeyTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.noChoiceRB = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.charInfoTextLbl = new System.Windows.Forms.Label();
            this.charInfoLbl = new System.Windows.Forms.Label();
            this.PWDetailGroup.SuspendLayout();
            this.DetailGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PWDetailGroup
            // 
            this.PWDetailGroup.Controls.Add(this.charInfoLbl);
            this.PWDetailGroup.Controls.Add(this.charInfoTextLbl);
            this.PWDetailGroup.Controls.Add(this.trackBar1);
            this.PWDetailGroup.Controls.Add(this.noChoiceRB);
            this.PWDetailGroup.Controls.Add(this.DoublePasswordText);
            this.PWDetailGroup.Controls.Add(this.doublePasswordCb);
            this.PWDetailGroup.Controls.Add(this.LinkTextBox);
            this.PWDetailGroup.Controls.Add(this.label4);
            this.PWDetailGroup.Controls.Add(this.AESRb);
            this.PWDetailGroup.Controls.Add(this.HashingRB);
            this.PWDetailGroup.Controls.Add(this.PasswordTextBox);
            this.PWDetailGroup.Controls.Add(this.UsernameTextBox);
            this.PWDetailGroup.Controls.Add(this.label2);
            this.PWDetailGroup.Controls.Add(this.label1);
            this.PWDetailGroup.Location = new System.Drawing.Point(12, 12);
            this.PWDetailGroup.Name = "PWDetailGroup";
            this.PWDetailGroup.Size = new System.Drawing.Size(421, 202);
            this.PWDetailGroup.TabIndex = 0;
            this.PWDetailGroup.TabStop = false;
            this.PWDetailGroup.Text = "PassWord Details";
            // 
            // DoublePasswordText
            // 
            this.DoublePasswordText.Enabled = false;
            this.DoublePasswordText.Location = new System.Drawing.Point(184, 174);
            this.DoublePasswordText.Name = "DoublePasswordText";
            this.DoublePasswordText.Size = new System.Drawing.Size(231, 20);
            this.DoublePasswordText.TabIndex = 9;
            // 
            // doublePasswordCb
            // 
            this.doublePasswordCb.AutoSize = true;
            this.doublePasswordCb.Location = new System.Drawing.Point(10, 176);
            this.doublePasswordCb.Name = "doublePasswordCb";
            this.doublePasswordCb.Size = new System.Drawing.Size(179, 17);
            this.doublePasswordCb.TabIndex = 8;
            this.doublePasswordCb.Text = "Use 2nd password for protection";
            this.doublePasswordCb.UseVisualStyleBackColor = true;
            this.doublePasswordCb.CheckedChanged += new System.EventHandler(this.doublePasswordCb_CheckedChanged);
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Location = new System.Drawing.Point(69, 149);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(346, 20);
            this.LinkTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link";
            // 
            // AESRb
            // 
            this.AESRb.AccessibleDescription = "Use Reversible Encryption";
            this.AESRb.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.AESRb.AutoSize = true;
            this.AESRb.Location = new System.Drawing.Point(10, 118);
            this.AESRb.Name = "AESRb";
            this.AESRb.Size = new System.Drawing.Size(121, 17);
            this.AESRb.TabIndex = 5;
            this.AESRb.TabStop = true;
            this.AESRb.Text = "Use AES Encryption";
            this.AESRb.UseVisualStyleBackColor = true;
            this.AESRb.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // HashingRB
            // 
            this.HashingRB.AccessibleDescription = "One-way encryption";
            this.HashingRB.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.HashingRB.AutoSize = true;
            this.HashingRB.Checked = true;
            this.HashingRB.Location = new System.Drawing.Point(10, 95);
            this.HashingRB.Name = "HashingRB";
            this.HashingRB.Size = new System.Drawing.Size(86, 17);
            this.HashingRB.TabIndex = 4;
            this.HashingRB.TabStop = true;
            this.HashingRB.Text = "Use Hashing";
            this.HashingRB.UseMnemonic = false;
            this.HashingRB.UseVisualStyleBackColor = true;
            this.HashingRB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(69, 49);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(346, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(69, 20);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(346, 20);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // DetailGroup
            // 
            this.DetailGroup.Controls.Add(this.GenIvBtn);
            this.DetailGroup.Controls.Add(this.AesIvTxt);
            this.DetailGroup.Controls.Add(this.label6);
            this.DetailGroup.Controls.Add(this.genAesBtn);
            this.DetailGroup.Controls.Add(this.AesKeyTxt);
            this.DetailGroup.Controls.Add(this.label3);
            this.DetailGroup.Location = new System.Drawing.Point(12, 220);
            this.DetailGroup.Name = "DetailGroup";
            this.DetailGroup.Size = new System.Drawing.Size(421, 168);
            this.DetailGroup.TabIndex = 1;
            this.DetailGroup.TabStop = false;
            this.DetailGroup.Text = "Detailed Options";
            // 
            // GenIvBtn
            // 
            this.GenIvBtn.Enabled = false;
            this.GenIvBtn.Location = new System.Drawing.Point(330, 87);
            this.GenIvBtn.Name = "GenIvBtn";
            this.GenIvBtn.Size = new System.Drawing.Size(75, 23);
            this.GenIvBtn.TabIndex = 5;
            this.GenIvBtn.Text = "Generate";
            this.GenIvBtn.UseVisualStyleBackColor = true;
            this.GenIvBtn.Click += new System.EventHandler(this.GenIvBtn_Click);
            // 
            // AesIvTxt
            // 
            this.AesIvTxt.Enabled = false;
            this.AesIvTxt.Location = new System.Drawing.Point(7, 87);
            this.AesIvTxt.Name = "AesIvTxt";
            this.AesIvTxt.Size = new System.Drawing.Size(317, 20);
            this.AesIvTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "AES Encryption Iv";
            // 
            // genAesBtn
            // 
            this.genAesBtn.Enabled = false;
            this.genAesBtn.Location = new System.Drawing.Point(330, 35);
            this.genAesBtn.Name = "genAesBtn";
            this.genAesBtn.Size = new System.Drawing.Size(75, 23);
            this.genAesBtn.TabIndex = 2;
            this.genAesBtn.Text = "Generate";
            this.genAesBtn.UseVisualStyleBackColor = true;
            this.genAesBtn.Click += new System.EventHandler(this.genAesBtn_Click);
            // 
            // AesKeyTxt
            // 
            this.AesKeyTxt.Enabled = false;
            this.AesKeyTxt.Location = new System.Drawing.Point(7, 37);
            this.AesKeyTxt.Name = "AesKeyTxt";
            this.AesKeyTxt.Size = new System.Drawing.Size(317, 20);
            this.AesKeyTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "AES Encryption Key";
            // 
            // Confirm_Btn
            // 
            this.Confirm_Btn.Location = new System.Drawing.Point(358, 397);
            this.Confirm_Btn.Name = "Confirm_Btn";
            this.Confirm_Btn.Size = new System.Drawing.Size(75, 23);
            this.Confirm_Btn.TabIndex = 2;
            this.Confirm_Btn.Text = "Confirm";
            this.Confirm_Btn.UseVisualStyleBackColor = true;
            this.Confirm_Btn.Click += new System.EventHandler(this.Confirm_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(12, 397);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Btn.TabIndex = 3;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // noChoiceRB
            // 
            this.noChoiceRB.AutoSize = true;
            this.noChoiceRB.Location = new System.Drawing.Point(10, 72);
            this.noChoiceRB.Name = "noChoiceRB";
            this.noChoiceRB.Size = new System.Drawing.Size(92, 17);
            this.noChoiceRB.TabIndex = 10;
            this.noChoiceRB.TabStop = true;
            this.noChoiceRB.Text = "No Encryption";
            this.noChoiceRB.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(137, 98);
            this.trackBar1.Maximum = 32;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(278, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // charInfoTextLbl
            // 
            this.charInfoTextLbl.AutoSize = true;
            this.charInfoTextLbl.Location = new System.Drawing.Point(144, 76);
            this.charInfoTextLbl.Name = "charInfoTextLbl";
            this.charInfoTextLbl.Size = new System.Drawing.Size(118, 13);
            this.charInfoTextLbl.TabIndex = 12;
            this.charInfoTextLbl.Text = "How Many Characters?";
            // 
            // charInfoLbl
            // 
            this.charInfoLbl.AutoSize = true;
            this.charInfoLbl.Location = new System.Drawing.Point(369, 76);
            this.charInfoLbl.Name = "charInfoLbl";
            this.charInfoLbl.Size = new System.Drawing.Size(13, 13);
            this.charInfoLbl.TabIndex = 13;
            this.charInfoLbl.Text = "8";
            // 
            // PasswordCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 432);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Confirm_Btn);
            this.Controls.Add(this.DetailGroup);
            this.Controls.Add(this.PWDetailGroup);
            this.MaximumSize = new System.Drawing.Size(461, 471);
            this.MinimumSize = new System.Drawing.Size(461, 471);
            this.Name = "PasswordCreationForm";
            this.Text = "PasswordCreationForm";
            this.PWDetailGroup.ResumeLayout(false);
            this.PWDetailGroup.PerformLayout();
            this.DetailGroup.ResumeLayout(false);
            this.DetailGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PWDetailGroup;
        private System.Windows.Forms.GroupBox DetailGroup;
        private System.Windows.Forms.Button Confirm_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.RadioButton AESRb;
        private System.Windows.Forms.RadioButton HashingRB;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenIvBtn;
        private System.Windows.Forms.TextBox AesIvTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button genAesBtn;
        private System.Windows.Forms.TextBox AesKeyTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DoublePasswordText;
        private System.Windows.Forms.CheckBox doublePasswordCb;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton noChoiceRB;
        private System.Windows.Forms.Label charInfoLbl;
        private System.Windows.Forms.Label charInfoTextLbl;
    }
}