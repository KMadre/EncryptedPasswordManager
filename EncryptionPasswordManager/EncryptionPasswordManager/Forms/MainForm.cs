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
using EncryptionPasswordManager.UserControlSpace;

namespace EncryptionPasswordManager.Forms
{
    public partial class MainForm : Form, IMainForm
    {

        MainPresenter mainPresenter;
        public MainForm(PasswordItemModel model)
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this, model);
        }

        public event EventHandler AddNewPasswordEvent;
        public event EventHandler RemovePasswordEvent;
        public event EventHandler CreateQuickEncryptedEvent;
        public event EventHandler CopyPasswordEvent;
        public event EventHandler ViewPasswordEvent;

        public void PopulateData(List<SaveFileDataPasswordItem> populateViewList)
        {
            PasswordPanel.Controls.Clear();
            foreach (var item in populateViewList)
            {
                PasswordUiItem passwordUiItem = new PasswordUiItem(
                    item.PasswordData.Username,
                    item.PasswordData.Password,
                    item.isHashed,
                    item.Link,
                    item.DoublePassword,
                    item.isDoubleProtected,
                    (item.PasswordData.Key != string.Empty) ? true : false,
                    DockStyle.Top
                    );
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
