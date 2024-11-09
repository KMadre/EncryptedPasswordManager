using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionPasswordManager.Util;

namespace EncryptionPasswordManager.Forms
{
    public partial class PopupPasswordForm : Form
    {
        private string hash;
        public PopupPasswordForm(string passwordHash)
        {
            InitializeComponent();
            hash = passwordHash;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(Sha256.Encrypt256(this.passwordTb.Text) == hash)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error! Password is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
