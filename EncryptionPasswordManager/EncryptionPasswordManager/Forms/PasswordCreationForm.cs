using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionPasswordManager.Model;
using System.Security.Cryptography;
using EncryptionPasswordManager.Util;

namespace EncryptionPasswordManager.Forms
{
    public partial class PasswordCreationForm : Form
    {
        private PasswordItem passwordItem;
        private PasswordItemPasswordData passwordData;
        private PasswordItemModel model;
        public PasswordCreationForm(PasswordItemModel model)
        {
            InitializeComponent();
            this.model = model;
            passwordData = new PasswordItemPasswordData();
            passwordItem = new PasswordItem();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Confirm_Btn_Click(object sender, EventArgs e)
        {
            GrabUiData();

            model.AddToPasswordModel(passwordItem);
            DialogResult=DialogResult.OK;
            this.Close();
        }

        private void GrabUiData()
        {
            passwordData.Username = UsernameTextBox.Text;
            passwordData.Key = AesKeyTxt.Text;
            passwordData.Iv = AesIvTxt.Text;
            passwordItem.PasswordData = passwordData;
            passwordItem.Link = LinkTextBox.Text;
            passwordItem.isHashed = HashingRB.Checked;
            passwordItem.isDoubleProtected = doublePasswordCb.Checked;
            passwordItem.DoublePassword = DoublePasswordText.Text;

            passwordData.Password = ProcessPassword();
        }

        private String ProcessPassword()
        {
            if (HashingRB.Checked)
            {
                String result = Sha256.Encrypt256(PasswordTextBox.Text);
                return result.Substring(0, trackBar1.Value);
            }
            else if (AESRb.Checked)
            {
                String result = AesEncrypt.EncryptStringToBytes_Aes(PasswordTextBox.Text, Convert.FromBase64String(AesKeyTxt.Text), Convert.FromBase64String(AesIvTxt.Text));
                return result.Substring(0, trackBar1.Value);
            }
            else
            {
                return PasswordTextBox.Text;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HashingRB.Checked)
            {
                genAesBtn.Enabled = false;
                GenIvBtn.Enabled = false;
                AesKeyTxt.Enabled = false;
                AesIvTxt.Enabled = false;
                trackBar1.Enabled = true;
            }
            else if(AESRb.Checked){
                genAesBtn.Enabled = true;
                GenIvBtn.Enabled = true;
                AesKeyTxt.Enabled = true;
                AesIvTxt.Enabled = true;
                trackBar1.Enabled = true;
            }else if (noChoiceRB.Checked)
            {
                genAesBtn.Enabled = false;
                GenIvBtn.Enabled = false;
                AesKeyTxt.Enabled = false;
                AesIvTxt.Enabled = false;
                trackBar1.Enabled = false;
            }
        }

        private void doublePasswordCb_CheckedChanged(object sender, EventArgs e)
        {
            DoublePasswordText.Enabled = doublePasswordCb.Checked;
        }

        private void genAesBtn_Click(object sender, EventArgs e)
        {
            Aes aes = Aes.Create();
            aes.GenerateKey();

            AesKeyTxt.Text = Convert.ToBase64String(aes.Key);
        }

        private void GenIvBtn_Click(object sender, EventArgs e)
        {
            Aes aes = Aes.Create();
            aes.GenerateIV();

            AesIvTxt.Text = Convert.ToBase64String(aes.IV);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.charInfoLbl.Text = this.trackBar1.Value.ToString();
        }
    }
}
