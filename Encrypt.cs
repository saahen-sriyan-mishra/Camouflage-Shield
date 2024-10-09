using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Camouflage_Shield
{
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
            TextBoxKey.Enabled = false;
            

            ButtonGenerate.Enabled = false;
            TextboxImageCODE.Enabled = false;
            ButtonSAVE.Enabled = false;


        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an OpenFileDialog to allow users to select an image file
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Select an Image",
                    Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp",
                    Multiselect = false
                };

                // Show the OpenFileDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = openFileDialog.FileName;

                    // Display the selected image in PictureBox
                    PictureBox.Image = Image.FromFile(filePath);

                    // Set the SizeMode to Zoom to avoid cropping and distortion
                    PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
















        private void RBP1_CheckedChanged(object sender, EventArgs e)
        {
            TBKeyENABLE();
        }

        private void RBP2_CheckedChanged(object sender, EventArgs e)
        {
            TBKeyENABLE();
        }

        private void RBP3_CheckedChanged(object sender, EventArgs e)
        {
            TBKeyENABLE();
        }

        private void RBP4_CheckedChanged(object sender, EventArgs e)
        {
            TBKeyENABLE();
        }
        private void RBP5_CheckedChanged(object sender, EventArgs e)
        {
            TBKeyENABLE();
        }

        private void TBKeyENABLE ()
        {
            if (RBP1.Checked==true || RBP2.Checked == true || RBP3.Checked == true || RBP4.Checked == true || RBP5.Checked == true)
            {
                TextBoxKey.Enabled = true;
            }

        }
        private void TextBoxKey_TextChanged(object sender, EventArgs e)
        {

        }


        private void ButtonLockData_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image != null && (RBP1.Checked || RBP2.Checked || RBP3.Checked || RBP4.Checked || RBP5.Checked) && !string.IsNullOrWhiteSpace(TextBoxKey.Text))
            {
                ButtonLockData.Enabled = false;
                ButtonSelect.Enabled = false;
                RBP1.Enabled = false;
                RBP2.Enabled = false;
                RBP3.Enabled = false;
                RBP4.Enabled = false;
                RBP5.Enabled = false;
                TextBoxKey.Enabled = false;

                ButtonGenerate.Focus();
                ButtonGenerate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please make sure to select an image, a process, and enter a key.");
            }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            TextboxImageCODE.Enabled = true;
            ButtonSAVE.Enabled = true;
            ButtonGenerate.Enabled = false;
            try
            {
                if (PictureBox.Image != null)
                {
                    // Convert the image to a byte array
                    using (MemoryStream ms = new MemoryStream())
                    {
                        PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
                        byte[] imageBytes = ms.ToArray();

                        // Get the selected algorithm
                        string algorithm = GetSelectedAlgorithm();

                        // Get the key
                        string key = TextBoxKey.Text;

                        // Encrypt the byte array based on the selected algorithm
                        byte[] encryptedBytes = EncryptData(imageBytes, key, algorithm);

                        // Convert the encrypted byte array to a Base64 string
                        string base64String = Convert.ToBase64String(encryptedBytes);

                        // Display the Base64 string in TextboxImageCODE
                        TextboxImageCODE.Text = base64String;
                    }
                }
                else
                {
                    MessageBox.Show("Please select an image before generating the Base64 code.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Base64 code: " + ex.Message);
            }
        }


        private byte[] EncryptData(byte[] data, string key, string algorithm)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] result;

            switch (algorithm.ToLower())
            {
                case "aes":
                    using (Aes aesAlg = Aes.Create())
                    {
                        aesAlg.Key = GetKey(keyBytes, aesAlg.KeySize / 8);
                        aesAlg.Mode = CipherMode.ECB;
                        aesAlg.Padding = PaddingMode.PKCS7;

                        using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                        {
                            result = encryptor.TransformFinalBlock(data, 0, data.Length);
                        }
                    }
                    break;

                case "des":
                    using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
                    {
                        desAlg.Key = GetKey(keyBytes, desAlg.KeySize / 8);
                        desAlg.Mode = CipherMode.ECB;
                        desAlg.Padding = PaddingMode.PKCS7;

                        using (ICryptoTransform encryptor = desAlg.CreateEncryptor())
                        {
                            result = encryptor.TransformFinalBlock(data, 0, data.Length);
                        }
                    }
                    break;

                case "3des":
                    using (TripleDESCryptoServiceProvider tripleDesAlg = new TripleDESCryptoServiceProvider())
                    {
                        tripleDesAlg.Key = GetKey(keyBytes, tripleDesAlg.KeySize / 8);
                        tripleDesAlg.Mode = CipherMode.ECB;
                        tripleDesAlg.Padding = PaddingMode.PKCS7;

                        using (ICryptoTransform encryptor = tripleDesAlg.CreateEncryptor())
                        {
                            result = encryptor.TransformFinalBlock(data, 0, data.Length);
                        }
                    }
                    break;

                case "rc2":
                    using (RC2CryptoServiceProvider rc2Alg = new RC2CryptoServiceProvider())
                    {
                        rc2Alg.Key = GetKey(keyBytes, rc2Alg.KeySize / 8);
                        rc2Alg.Mode = CipherMode.ECB;
                        rc2Alg.Padding = PaddingMode.PKCS7;

                        using (ICryptoTransform encryptor = rc2Alg.CreateEncryptor())
                        {
                            result = encryptor.TransformFinalBlock(data, 0, data.Length);
                        }
                    }
                    break;

                case "Rijndael":
                    using (RijndaelManaged rijndaelAlg = new RijndaelManaged())
                    {
                        rijndaelAlg.Key = GetKey(keyBytes, rijndaelAlg.KeySize / 8);
                        rijndaelAlg.Mode = CipherMode.ECB;
                        rijndaelAlg.Padding = PaddingMode.PKCS7;

                        using (ICryptoTransform encryptor = rijndaelAlg.CreateEncryptor())
                        {
                            result = encryptor.TransformFinalBlock(data, 0, data.Length);
                        }
                    }
                    break;


                default:
                    throw new NotSupportedException("Unsupported algorithm");
            }

            return result;
        }

        private byte[] GetKey(byte[] key, int size)
        {
            byte[] result = new byte[size];
            int keyIndex = 0;

            for (int i = 0; i < size; i++)
            {
                result[i] = key[keyIndex];
                keyIndex = (keyIndex + 1) % key.Length;
            }

            return result;
        }

        private string GetSelectedAlgorithm()
        {
            if (RBP1.Checked) return "aes";
            if (RBP2.Checked) return "des";
            if (RBP3.Checked) return "3des";
            if (RBP4.Checked) return "rc2";
            if (RBP5.Checked) return "Rijndael";

            throw new InvalidOperationException("No algorithm selected");
        }
        private void TextboxImageCODE_TextChanged(object sender, EventArgs e)
        {
            TextboxImageCODE.ScrollBars = ScrollBars.Vertical;
            DisableTextboxFunctionality();
        }
        private void DisableTextboxFunctionality()
        {
            TextboxImageCODE.ReadOnly = true;
            TextboxImageCODE.TabStop = false; // Disable tab stop
        }


























        private void ButtonSAVE_Click(object sender, EventArgs e)
        {
            if (ButtonGenerate.Enabled == false)
            {
                try
                {
                    // Get the encrypted text from TextBoxImageCODE
                    string encryptedText = TextboxImageCODE.Text;

                    // Get the logged-in username (replace this with your actual logic to get the username)
                    string loggedInUsername = Form2.UserName;

                    // Insert the data into the EncryptedData table
                    InsertEncryptedData(loggedInUsername, encryptedText);

                    MessageBox.Show("Data saved successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message, "Error");
                }
            }

            else
            {
                MessageBox.Show("generate the code first");
            }
        }
        private void InsertEncryptedData(string username, string encryptedText)
        {
           
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KIIT\\Desktop\\Camouflage Shield Final1\\P1DB1.mdf\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO EncryptedData (Username, EncryptedText) VALUES (@Username, @EncryptedText)", connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@EncryptedText", encryptedText);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle database-related exceptions
                    MessageBox.Show("Error inserting data into the database: " + ex.Message, "Database Error");
                }
            }
        }
























        private void L2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Encrypt_Load(object sender, EventArgs e)
        {

        }

       
    }
}
