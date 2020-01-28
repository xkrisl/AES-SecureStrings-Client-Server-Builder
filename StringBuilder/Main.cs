using System;
using System.Windows.Forms;
using Encryption;

namespace StringBuilder
{
    public partial class Main : Form
    {
        SecurityController _security = new SecurityController();
        public Main()
        {
            InitializeComponent();
        }
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AESPasswordTextbox.Text))
            {
                MessageBox.Show("Oops, the password textbox cannot be empty!");
                EncryptTextbox.Clear();
                return;
            }

            string AESPassword = AESPasswordTextbox.Text;
            string OutputMessage = EncryptTextbox.Text;

            EncryptTextbox.Text = _security.Encrypt(AESPassword, OutputMessage);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AESPasswordTextbox.Text))
            {
                MessageBox.Show("Oops, the password textbox cannot be empty!");
                DecryptTextbox.Clear();
                return;
            }

            string AESPassword = AESPasswordTextbox.Text;
            string OutputMessage = DecryptTextbox.Text;

            try
            {
                DecryptTextbox.Text = _security.Decrypt(AESPassword, OutputMessage);
            }
            catch (Exception)
            {
                MessageBox.Show("Invaild input (unprotected string)...");
                DecryptTextbox.Clear();
            }
        }
    }
}

