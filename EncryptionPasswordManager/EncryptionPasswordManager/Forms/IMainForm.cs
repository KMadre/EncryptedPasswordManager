using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionPasswordManager.Forms
{
    public interface IMainForm
    {
        void Close();
        void PopulateData(List<PasswordItem> populateViewList);
        event EventHandler AddNewPasswordEvent;
        event EventHandler RemovePasswordEvent;
        event EventHandler CreateQuickEncryptedEvent;
        event EventHandler CopyPasswordEvent;
        event EventHandler ViewPasswordEvent;

    }
}
