using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EncryptionPasswordManager.Forms
{
    public partial class QuickEncryptForm : Form
    {
        public QuickEncryptForm()
        {
            InitializeComponent();
            this.infoLbl.Text = "";
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(this.inputTxtBx.Text));

                String result = Convert.ToBase64String(bytes);
                
                Clipboard.SetText(result.Substring(0,this.trackBar1.Value));
                this.infoLbl.Text = "Password is in your Clipboard";
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            this.charInfoLbl.Text = this.trackBar1.Value.ToString();
        }
    }
}
