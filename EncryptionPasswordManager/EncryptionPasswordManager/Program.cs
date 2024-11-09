using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using EncryptionPasswordManager.Forms;
using EncryptionPasswordManager.Model;

namespace EncryptionPasswordManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var formManager = new FormManager();
            PasswordItemModel _model = new PasswordItemModel();
            using (Form logIn = new LoginForm(_model))
            {
                if(formManager.DialogWithResult(logIn) == DialogResult.OK)
                {
                    formManager.ShowForm(new MainForm(_model));
                    Application.Run();
                }
            }
        }
    }
}
