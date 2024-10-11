using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EncryptionPasswordManager.Forms;

namespace EncryptionPasswordManager.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginForm _form;

        public LoginPresenter(ILoginForm form)
        {
            _form = form;
            _form.LoginAttempted += AttemptLogin;
            _form.CancelClicked += HandleCancel;
        }

        private void AttemptLogin(object sender, EventArgs e)
        {
            string user = _form.Username;
            string password = _form.Password;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                return;
            }

            if(ConfirmCreds(user, password))
            {
                _form.Success();
            }
        }

        private void HandleCancel(object sender, EventArgs e)
        {
            _form.Cancel();
        }

        private bool ConfirmCreds(string user, string password)
        {
            return true;
        }
    }
}
