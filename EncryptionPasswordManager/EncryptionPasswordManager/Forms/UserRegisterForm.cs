using EncryptionPasswordManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionPasswordManager.Forms
{
    public partial class UserRegisterForm : Form
    {
        PasswordItemModel _model;
        public UserRegisterForm(PasswordItemModel model)
        {
            InitializeComponent();
            _model = model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerifyInputLegal())
            {
                _model.RegisterAccount(userTxtBx.Text, passTxtBx.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool VerifyInputLegal()
        {
            if(userTxtBx.Text == String.Empty)
            {
                MessageBox.Show("Username may not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(passTxtBx.Text != conPassTxtBx.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(passTxtBx.Text == String.Empty || conPassTxtBx.Text == String.Empty)
            {
                MessageBox.Show("Password may not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
