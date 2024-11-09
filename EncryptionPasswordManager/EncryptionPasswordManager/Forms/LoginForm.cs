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
using EncryptionPasswordManager.Presenter;

namespace EncryptionPasswordManager.Forms
{
    public partial class LoginForm : Form, ILoginForm
    {
        public LoginForm(PasswordItemModel model)
        {
            InitializeComponent();
            var presenter = new LoginPresenter(this, model);
        }

        public string Username
        {
            get { return usernameTb.Text; }
            set { usernameTb.Text = value; }
        }
        
        public string Password
        {
            get { return passwordTb.Text; }
            set { passwordTb.Text = value; }
        }

        public event EventHandler LoginAttempted;
        public event EventHandler CancelClicked;

        public void Cancel()
        {
            this.Close();
            Application.Exit();
        }

        public void Success()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            LoginAttempted.Invoke(this, new EventArgs());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelClicked.Invoke(this, new EventArgs());
        }
    }
}
