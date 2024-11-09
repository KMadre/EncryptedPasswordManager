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
using EncryptionPasswordManager.Util;

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
            String result = Sha256.Encrypt256(this.inputTxtBx.Text);

            
            Clipboard.SetText(result.Substring(0, this.trackBar1.Value));
            this.infoLbl.Text = "Password is in your Clipboard";
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            this.charInfoLbl.Text = this.trackBar1.Value.ToString();
        }
    }
}
