using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace EncryptionPasswordManager.Forms
{
    public interface ILoginForm
    {
        string Username { get; set; }
        string Password { get; set; }
        event EventHandler LoginAttempted;
        event EventHandler CancelClicked;

        void Success();
        void Cancel();
    }
}
