using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionPasswordManager.Forms;

namespace EncryptionPasswordManager
{
    public class FormManager
    {
        private Form _currentForm;

        public void ShowForm(Form form)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }

            _currentForm = form;

            _currentForm.Show();
        }

        public DialogResult DialogWithResult(Form dialog)
        {
            if(_currentForm != null)
            {
                _currentForm.Close();
            }

            _currentForm = dialog;

            return _currentForm.ShowDialog();
        }

        public void CloseCurrentForm()
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }
        }
    }

}
