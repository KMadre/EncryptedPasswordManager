using EncryptionPasswordManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionPasswordManager.Forms
{
    public partial class PasswordDeletionForm : Form
    {
        PasswordItemModel model;

        public PasswordDeletionForm(PasswordItemModel model)
        {
            InitializeComponent();
            this.model = model;
            this.listView.Columns.Add("Username", 100);
            this.listView.Columns.Add("Website Link", 250);
            PopulateList();
        }

        private void PopulateList()
        {
            listView.Items.Clear();
            foreach(var item in model.GetResult(String.Empty))
            {
                var listItem = new ListViewItem(new[]
                {
                    item.PasswordData.Username,
                    item.Link
                });

                listView.Items.Add(listItem);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count > 0)
            {
                var selected = listView.SelectedItems[0];

                var deletionItem = model.PasswordItems.FirstOrDefault(
                    x => x.PasswordData.Username == selected.SubItems[0].Text &&
                    x.Link == selected.SubItems[1].Text);
                model.RemoveFromPasswordModel(deletionItem);
            }

            PopulateList();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
