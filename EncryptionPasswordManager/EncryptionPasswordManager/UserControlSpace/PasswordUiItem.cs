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
using EncryptionPasswordManager.Forms;

namespace EncryptionPasswordManager.UserControlSpace
{
    public partial class PasswordUiItem : UserControl
    {
        private bool _passwordShowing = false;
        private const string PASSWORD_HIDDEN_STRING = "Click to show password.";

        private string _password;

        public string Password
        {
            get { return PasswordField.Text; }
            set { _password = value; }
        }

        public string Username
        {
            get { return UsernameField.Text; }
            set { UsernameField.Text = value; }
        }

        public bool isHashed { get; set; }

        public bool isAes { get; set; }

        public bool hasSecondPassword { get; set; }

        public string secondPassword { get; set; }

        public string Link
        {
            get { return linkLabel.Text; }
            set { linkLabel.Text = value; }
        }

        public PasswordUiItem(string username, string password, bool isHashed, string link, string doublePassword, bool isDoublePassword, bool isAes, DockStyle top)
        {
            InitializeComponent();
            
            this._password = password;
            this.Username = username;
            this.Link = link;
            this.hasSecondPassword = isDoublePassword;
            this.secondPassword = doublePassword;
            this.isHashed = isHashed;
            this.isAes = isAes;
            this.Dock = top;
            
            SetUpUiStrings();
        }

        private void SetUpUiStrings()
        {
            this.PasswordField.Text = PASSWORD_HIDDEN_STRING;
            this.encryptionActualLbl.Text = GetCorrectEncryptionType();
            this.Update();
        }

        private string GetCorrectEncryptionType()
        {
            if (isHashed)
            {
                return "Sha256";
            }else if (isAes)
            {
                return "AES";
            }
            else
            {
                return "None";
            }
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
            if (hasSecondPassword)
            {
                if (SecondPasswordVerification())
                {
                    Clipboard.SetText(_password);
                }
            }
            else
            {
                Clipboard.SetText(_password);
            }
        }

        private void CopyUsernameBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Username);
        }

        private void PasswordField_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor= Cursors.Default;
        }

        private void PasswordField_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void PasswordField_MouseUp(object sender, MouseEventArgs e)
        {
            this.Password = this._password;
        }

        private void PasswordField_Click(object sender, EventArgs e)
        {
            if (_passwordShowing)
            {
                this.PasswordField.Text = PASSWORD_HIDDEN_STRING;
                _passwordShowing = !_passwordShowing;
            }
            else
            {
                if (hasSecondPassword)
                {
                    if (SecondPasswordVerification())
                    {
                        this.PasswordField.Text = _password;
                        _passwordShowing = !_passwordShowing;
                    }
                }
                else if(!hasSecondPassword)
                {
                    this.PasswordField.Text = _password;
                    _passwordShowing = !_passwordShowing;
                }
            }
        }

        private bool SecondPasswordVerification()
        {
            PopupPasswordForm form = new PopupPasswordForm(secondPassword);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    }
}
