using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionPasswordManager.Forms;
using EncryptionPasswordManager.Model;

namespace EncryptionPasswordManager.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginForm _form;
        private PasswordItemModel _model;

        public LoginPresenter(ILoginForm form, PasswordItemModel model)
        {
            _form = form;
            _form.LoginAttempted += AttemptLogin;
            _form.CancelClicked += HandleCancel;
            _model = model;

            IfNeededPromptRegister();
        }

        private void IfNeededPromptRegister()
        {
            if (!_model.UserMadeAccount())
            {
                UserRegisterForm form = new UserRegisterForm(_model);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    form.Close();
                    return;
                }
                else
                {
                    form.Close();
                    Environment.Exit(0);
                }
            }
        }

        private void AttemptLogin(object sender, EventArgs e)
        {
            string user = _form.Username;
            string password = _form.Password;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                return;
            }

            if(_model.AttemptLogin(user, password))
            {
                _form.Success();
            }
        }

        private void HandleCancel(object sender, EventArgs e)
        {
            _form.Cancel();
        }
    }
}
