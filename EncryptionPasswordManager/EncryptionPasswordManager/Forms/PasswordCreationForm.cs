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
            passwordData.Password = PasswordTextBox.Text;
            passwordData.Username = UsernameTextBox.Text;
            passwordData.Key = AesKeyTxt.Text;
            passwordData.Iv = AesIvTxt.Text;
            passwordItem.PasswordData = passwordData;
            passwordItem.Link = LinkTextBox.Text;
            passwordItem.isHashed = HashingRB.Checked;
            passwordItem.isDoubleProtected = doublePasswordCb.Checked;
            passwordItem.DoublePassword = DoublePasswordText.Text;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HashingRB.Checked)
            {
                genAesBtn.Enabled = false;
                GenIvBtn.Enabled = false;
                AesKeyTxt.Enabled = false;
                AesIvTxt.Enabled = false;
            }else if(AESRb.Checked){
                genAesBtn.Enabled = true;
                GenIvBtn.Enabled = true;
                AesKeyTxt.Enabled = true;
                AesIvTxt.Enabled = true;
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
    }
}
