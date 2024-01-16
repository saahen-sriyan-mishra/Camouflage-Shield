using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camouflage_Shield
{
    public partial class hashtext : Form
    {
        public hashtext()
        {
            InitializeComponent();
        }

        private void hashtext_Load(object sender, EventArgs e)
        {

        }

        private void L2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void RBP1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBP2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBP3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBP4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBP5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxText_TextChanged(object sender, EventArgs e)
        {
            TextBoxText.ScrollBars = ScrollBars.Vertical;
        }

        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            RBP1.Enabled = false;
            RBP2.Enabled = false;
            RBP3.Enabled = false;
            RBP4.Enabled = false;
            RBP5.Enabled = false;
            TextBoxText.Enabled = false;

            string inputText = TextBoxText.Text;

            if (!string.IsNullOrWhiteSpace(inputText))
            {
                string hashedText = string.Empty;

                if (RBP1.Checked)
                {
                    hashedText = ComputeHash(inputText, new MD5CryptoServiceProvider());
                }
                else if (RBP2.Checked)
                {
                    hashedText = ComputeHash(inputText, new SHA1Managed());
                }
                else if (RBP3.Checked)
                {
                    hashedText = ComputeHash(inputText, new SHA256Managed());
                }
                else if (RBP4.Checked)
                {
                    hashedText = ComputeHash(inputText, new SHA384Managed());
                }
                else if (RBP5.Checked)
                {
                    hashedText = ComputeHash(inputText, new SHA512Managed());
                }

                TextBoxCode.Text = hashedText;
            }
            else
            {
                MessageBox.Show("Please enter text before processing.");
            }
            RBP1.Enabled = true;
            RBP2.Enabled = true;
            RBP3.Enabled = true;
            RBP4.Enabled = true;
            RBP5.Enabled = true;
            TextBoxText.Enabled = true;
        }
        private string ComputeHash(string input, HashAlgorithm algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            // Convert the hashed bytes to a hexadecimal string
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hashedBytes)
            {
                stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        private void TextBoxCode_TextChanged(object sender, EventArgs e)
        {
            TextBoxCode.ScrollBars = ScrollBars.Vertical;
        }

      
    }
}
