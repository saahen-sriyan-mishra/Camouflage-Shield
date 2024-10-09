using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

namespace Camouflage_Shield
{
    public partial class Form2 : Form
    {
        //next form username display
        public static string UserName;
        public Form2()
        {
            InitializeComponent();
        }

        //sql connection
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KIIT\\Desktop\\Camouflage Shield Final1\\P1DB1.mdf\";Integrated Security=True");


        //TEXTBOXES
        private void TBLF1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBLF2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TVLF3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBLF4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBLF5_TextChanged(object sender, EventArgs e)
        {

        }


        //NEXT BUTTON
        private void ButtonNext1_Click(object sender, EventArgs e)
        {
            if (TBLF1.Text != "" && TBLF2.Text != "" && TVLF3.Text != "" && TBLF4.Text != "" && TBLF5.Text != "")
            {
                string query = "SELECT COUNT(*) FROM Signup WHERE " +
                    "email = @email AND " +
                    "password = @password AND " +
                    "date = @date AND " +
                    "phonenumber = @phonenumber AND " +
                    "username = @username";

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", GetHash(TBLF2.Text, SHA1.Create()));
                command.Parameters.AddWithValue("@password", GetHash(TBLF5.Text, SHA512.Create()));
                command.Parameters.AddWithValue("@date", GetHash(TBLF1.Text, MD5.Create()));
                command.Parameters.AddWithValue("@phonenumber", GetHash(TVLF3.Text, SHA256.Create()));
                command.Parameters.AddWithValue("@username", GetHash(TBLF4.Text, SHA384.Create()));

                int v = (int)command.ExecuteScalar();
                connection.Close();

                if (v != 1)
                {
                    MessageBox.Show("Error! Try again");
                }
                else
                {
                    // Hide the current form
                    this.Hide();
                    UserName = TBLF4.Text;
                    Main main = new Main();
                    main.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
                    main.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Fill in all the boxes");
            }
        }

 
        private string GetHash(string input, HashAlgorithm algorithm)
        {
            using (var hasher = algorithm)
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = hasher.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }







        //LINK
        private void LinkLabelSignUpForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide the current form
            this.Hide();

            Form1 su = new Form1();
            su.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
            su.ShowDialog();
        }

        //FORM
        private void Form2_Load(object sender, EventArgs e)
        {

        }




        //USELESS LABEL
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void L2_Click(object sender, EventArgs e)
        {

        }

        private void L3_Click(object sender, EventArgs e)
        {

        }

        private void L4_Click(object sender, EventArgs e)
        {

        }

        private void L5_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
