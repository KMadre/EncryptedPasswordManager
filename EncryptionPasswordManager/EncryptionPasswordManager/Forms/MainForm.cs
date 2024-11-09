using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EncryptionPasswordManager.Presenter;
using EncryptionPasswordManager.UserControlSpace;

namespace EncryptionPasswordManager.Forms
{
    public partial class MainForm : Form, IMainForm
    {

        MainPresenter mainPresenter;
        public MainForm()
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this);
        }

        public event EventHandler AddNewPasswordEvent;
        public event EventHandler RemovePasswordEvent;
        public event EventHandler CreateQuickEncryptedEvent;
        public event EventHandler CopyPasswordEvent;
        public event EventHandler ViewPasswordEvent;

        public void PopulateData(List<PasswordItem> populateViewList)
        {
            PasswordPanel.Controls.Clear();
            foreach (var item in populateViewList)
            {
                PasswordUiItem passwordUiItem = new PasswordUiItem();
                passwordUiItem.Username = item.PasswordData.Username;
                passwordUiItem.Password = item.PasswordData.Password;
                passwordUiItem.isHashed = item.isHashed;
                passwordUiItem.Link = item.Link;
                passwordUiItem.Dock = DockStyle.Top;
                PasswordPanel.Controls.Add(passwordUiItem);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            mainPresenter.ProcessQuery(SearchTextBox.Text);
        }

        private void NewPassBtn_Click(object sender, EventArgs e)
        {
            AddNewPasswordEvent.Invoke(this, new EventArgs());
        }

        private void DelPassBtn_Click(object sender, EventArgs e)
        {
            RemovePasswordEvent.Invoke(this, new EventArgs());
        }

        private void QuickEncryptBtn_Click(object sender, EventArgs e)
        {
            CreateQuickEncryptedEvent.Invoke(this, new EventArgs());
        }
    }
}
