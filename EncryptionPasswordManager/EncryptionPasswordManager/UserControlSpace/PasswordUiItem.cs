using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EncryptionPasswordManager.UserControlSpace
{
    public partial class PasswordUiItem : UserControl
    {
        public PasswordUiItem()
        {
            InitializeComponent();
        }

        public string Password
        {
            get { return PasswordField.Text; }
            set { PasswordField.Text = value; }
        }

        public string Username
        {
            get { return UsernameField.Text;}
            set { UsernameField.Text = value;}
        }

        public bool isHashed
        {
            get { return isHashedCb.Checked; }
            set { isHashedCb.Checked = value;}
        }

        public string Link
        {
            get { return linkLabel.Text; }
            set { linkLabel.Text = value; }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Link.Contains("https://www."))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = Link,
                    UseShellExecute = true
                });
            }else if (Link.Contains("www."))
            {
                String temp = Link;
                String fullLink = "https://";
                fullLink = fullLink + temp;

                Process.Start(new ProcessStartInfo
                {
                    FileName = fullLink,
                    UseShellExecute = true
                });
            }
            else
            {
                String temp = Link;
                String fullLink = "https://www.";
                fullLink = fullLink + temp;

                Process.Start(new ProcessStartInfo
                {
                    FileName = fullLink,
                    UseShellExecute = true
                });
            }
        }

        private void CopyPasswordBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Password);
        }

        private void CopyUsernameBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Username);
        }
    }
}
