namespace EncryptionPasswordManager.Forms
{
    partial class QuickEncryptForm
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.inputTxtBx = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.charNumLbl = new System.Windows.Forms.Label();
            this.charInfoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(54, 14);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(130, 13);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Enter password to encrypt";
            // 
            // inputTxtBx
            // 
            this.inputTxtBx.Location = new System.Drawing.Point(13, 30);
            this.inputTxtBx.Name = "inputTxtBx";
            this.inputTxtBx.Size = new System.Drawing.Size(209, 20);
            this.inputTxtBx.TabIndex = 1;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(79, 145);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Encrypt";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(47, 174);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(144, 13);
            this.infoLbl.TabIndex = 3;
            this.infoLbl.Text = "Password is in your Clipboard";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 90);
            this.trackBar1.Maximum = 32;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(209, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // charNumLbl
            // 
            this.charNumLbl.AutoSize = true;
            this.charNumLbl.Location = new System.Drawing.Point(10, 65);
            this.charNumLbl.Name = "charNumLbl";
            this.charNumLbl.Size = new System.Drawing.Size(116, 13);
            this.charNumLbl.TabIndex = 5;
            this.charNumLbl.Text = "How many characters?";
            // 
            // charInfoLbl
            // 
            this.charInfoLbl.AutoSize = true;
            this.charInfoLbl.Location = new System.Drawing.Point(187, 65);
            this.charInfoLbl.Name = "charInfoLbl";
            this.charInfoLbl.Size = new System.Drawing.Size(13, 13);
            this.charInfoLbl.TabIndex = 6;
            this.charInfoLbl.Text = "0";
            // 
            // QuickEncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.charInfoLbl);
            this.Controls.Add(this.charNumLbl);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.inputTxtBx);
            this.Controls.Add(this.TitleLbl);
            this.MaximumSize = new System.Drawing.Size(250, 250);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "QuickEncryptForm";
            this.Text = "QuickEncryptForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox inputTxtBx;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label charNumLbl;
        private System.Windows.Forms.Label charInfoLbl;
    }
}