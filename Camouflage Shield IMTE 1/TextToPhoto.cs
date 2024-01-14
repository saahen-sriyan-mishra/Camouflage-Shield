using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camouflage_Shield
{
    public partial class TextToPhoto : Form
    {
        public TextToPhoto()
        {
            InitializeComponent();
        }

        private void TextToPhoto_Load(object sender, EventArgs e)
        {

        }

        

        private void TextboxImageCODE_TextChanged(object sender, EventArgs e)
        {
            TextboxImageCODE.ScrollBars = ScrollBars.Vertical;
        }



        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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

        private void TextBoxKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            try
            {
               
                    // Get the Base64 string from the TextBox
                    string base64String = TextboxImageCODE.Text;

                    // Get the selected algorithm
                    string algorithm = GetSelectedAlgorithm();

                    // Get the key
                    string key = TextBoxKey.Text;

                    // Convert Base64 string to byte array
                    byte[] encryptedBytes = Convert.FromBase64String(base64String);

                    // Decrypt the byte array based on the selected algorithm and key
                    byte[] decryptedBytes = DecryptData(encryptedBytes, key, algorithm);

                    // Create a MemoryStream from the decrypted byte array
                    MemoryStream ms = new MemoryStream(decryptedBytes);

                    // Create an Image from the MemoryStream
                    Image image = Image.FromStream(ms);

                    // Display the decrypted image in PictureBox1
                    PictureBox1.Image = image;

                    // Set the SizeMode to Zoom to avoid cropping and distortion
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: Please enter correct image code, selected process and the key \n" + ex.Message);
            }

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

        private byte[] DecryptData(byte[] data, string key, string algorithm)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] result;

            using (MemoryStream ms = new MemoryStream())
            {
                switch (algorithm.ToLower())
                {
                    case "aes":
                        using (Aes aesAlg = Aes.Create())
                        {
                            aesAlg.Key = GetKey(keyBytes, aesAlg.KeySize / 8);
                            aesAlg.Mode = CipherMode.ECB;
                            aesAlg.Padding = PaddingMode.PKCS7;

                            using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                            {
                                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                                {
                                    cs.Write(data, 0, data.Length);
                                    cs.Close();
                                }
                            }
                        }
                        break;

                    case "des":
                        using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
                        {
                            desAlg.Key = GetKey(keyBytes, desAlg.KeySize / 8);
                            desAlg.Mode = CipherMode.ECB;
                            desAlg.Padding = PaddingMode.PKCS7;

                            using (ICryptoTransform decryptor = desAlg.CreateDecryptor())
                            {
                                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                                {
                                    cs.Write(data, 0, data.Length);
                                    cs.Close();
                                }
                            }
                        }
                        break;

                    case "3des":
                        using (TripleDESCryptoServiceProvider tripleDesAlg = new TripleDESCryptoServiceProvider())
                        {
                            tripleDesAlg.Key = GetKey(keyBytes, tripleDesAlg.KeySize / 8);
                            tripleDesAlg.Mode = CipherMode.ECB;
                            tripleDesAlg.Padding = PaddingMode.PKCS7;

                            using (ICryptoTransform decryptor = tripleDesAlg.CreateDecryptor())
                            {
                                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                                {
                                    cs.Write(data, 0, data.Length);
                                    cs.Close();
                                }
                            }
                        }
                        break;

                    case "rc2":
                        using (RC2CryptoServiceProvider rc2Alg = new RC2CryptoServiceProvider())
                        {
                            rc2Alg.Key = GetKey(keyBytes, rc2Alg.KeySize / 8);
                            rc2Alg.Mode = CipherMode.ECB;
                            rc2Alg.Padding = PaddingMode.PKCS7;

                            using (ICryptoTransform decryptor = rc2Alg.CreateDecryptor())
                            {
                                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                                {
                                    cs.Write(data, 0, data.Length);
                                    cs.Close();
                                }
                            }
                        }
                        break;

                    case "Rijndael":
                        using (RijndaelManaged rijndaelAlg = new RijndaelManaged())
                        {
                            rijndaelAlg.Key = GetKey(keyBytes, rijndaelAlg.KeySize / 8);
                            rijndaelAlg.Mode = CipherMode.ECB;
                            rijndaelAlg.Padding = PaddingMode.PKCS7;

                            using (ICryptoTransform decryptor = rijndaelAlg.CreateDecryptor())
                            {
                                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                                {
                                    cs.Write(data, 0, data.Length);
                                    cs.Close();
                                }
                            }
                        }
                        break;

                    default:
                        throw new NotSupportedException("Unsupported algorithm");
                }

                result = ms.ToArray();
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






























        //USELESS
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void L2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}


/*
 

iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAApgAAAKYB3X3/OAAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAANCSURBVEiJtZZPbBtFFMZ/M7ubXdtdb1xSFyeilBapySVU8h8OoFaooFSqiihIVIpQBKci6KEg9Q6H9kovIHoCIVQJJCKE1ENFjnAgcaSGC6rEnxBwA04Tx43t2FnvDAfjkNibxgHxnWb2e/u992bee7tCa00YFsffekFY+nUzFtjW0LrvjRXrCDIAaPLlW0nHL0SsZtVoaF98mLrx3pdhOqLtYPHChahZcYYO7KvPFxvRl5XPp1sN3adWiD1ZAqD6XYK1b/dvE5IWryTt2udLFedwc1+9kLp+vbbpoDh+6TklxBeAi9TL0taeWpdmZzQDry0AcO+jQ12RyohqqoYoo8RDwJrU+qXkjWtfi8Xxt58BdQuwQs9qC/afLwCw8tnQbqYAPsgxE1S6F3EAIXux2oQFKm0ihMsOF71dHYx+f3NND68ghCu1YIoePPQN1pGRABkJ6Bus96CutRZMydTl+TvuiRW1m3n0eDl0vRPcEysqdXn+jsQPsrHMquGeXEaY4Yk4wxWcY5V/9scqOMOVUFthatyTy8QyqwZ+kDURKoMWxNKr2EeqVKcTNOajqKoBgOE28U4tdQl5p5bwCw7BWquaZSzAPlwjlithJtp3pTImSqQRrb2Z8PHGigD4RZuNX6JYj6wj7O4TFLbCO/Mn/m8R+h6rYSUb3ekokRY6f/YukArN979jcW+V/S8g0eT/N3VN3kTqWbQ428m9/8k0P/1aIhF36PccEl6EhOcAUCrXKZXXWS3XKd2vc/TRBG9O5ELC17MmWubD2nKhUKZa26Ba2+D3P+4/MNCFwg59oWVeYhkzgN/JDR8deKBoD7Y+ljEjGZ0sosXVTvbc6RHirr2reNy1OXd6pJsQ+gqjk8VWFYmHrwBzW/n+uMPFiRwHB2I7ih8ciHFxIkd/3Omk5tCDV1t+2nNu5sxxpDFNx+huNhVT3/zMDz8usXC3ddaHBj1GHj/As08fwTS7Kt1HBTmyN29vdwAw+/wbwLVOJ3uAD1wi/dUH7Qei66PfyuRj4Ik9is+hglfbkbfR3cnZm7chlUWLdwmprtCohX4HUtlOcQjLYCu+fzGJH2QRKvP3UNz8bWk1qMxjGTOMThZ3kvgLI5AzFfo379UAAAAASUVORK5CYII= 

 
 
 */