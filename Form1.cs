using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;

namespace Camouflage_Shield
{
    public partial class Form1 : Form
    {

        private TimeSpan countdownTime; // Total time for the countdown
        private string generatedOTP;    //Initiate random OTP
        private DateTime otpGenerationTime; // Store the time when OTP was generated
        private bool nextButton1Clicked = false; // Flag to track if "Next" button has been clicked

        public Form1()
        {
            InitializeComponent(); 
            
            
            //1.1
            TextBoxBirthDate.Leave += TextBoxBirthDate_Leave;
            TextBoxBirthDate.TextChanged += TextBoxBirthDate_TextChanged;

            TextBoxEmail.Leave += TextBoxEmail_Leave;
            TextBoxEmail.TextChanged += TextBoxEmail_TextChanged;

            TextBoxPhoneNumber.Leave += TextBoxPhoneNumber_Leave;
            TextBoxPhoneNumber.TextChanged += TextBoxPhoneNumber_TextChanged;

            CheckBoxConfirmPersonalDetails.Enabled = false;


            //1.2
            RadioButtonEmail.Enabled = false;
            RadioButtonPhoneNumber.Enabled = false;
            LinkLabelGetOTP.Enabled = false;
            LabelDisplayTimer.Visible = false;
            LabelDisplayOTP.Enabled = false;
            TextBoxOTP.Enabled = false;
            ButtonNext1.Enabled = false;

            //2.1
            ButtonGenerateUserName.Enabled = false;

            //3.1
            TextBoxPassword.Enabled = false;
            TextBoxConfirmPassword.Enabled = false;
            ButtonViewPassword.Enabled = false;
            ButtonViewConfirmPassword.Enabled = false;

            //3.2
            TextBoxPassword.TextChanged += TextBoxPassword_TextChanged;

            CB_LowerCase.Enabled = false;
            CB_UpperCase.Enabled = false;
            CB_Number.Enabled = false;
            CB_SpecialCharacter.Enabled = false;
            CB_12Bits.Enabled = false;

            //3.3
            ButtonNext.Enabled = false;
        }
        //SQL DATABASE
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KIIT\\Desktop\\Camouflage Shield Final1\\P1DB1.mdf\";Integrated Security=True");





        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------------------------------------------------------
        //invisible data
        private void Form1_Load(object sender, EventArgs e)
        {
            // Assuming an invisible label is added to the form
            invisibleLabel.Visible = false;
            invisibleLabel.Enabled = false;
            invisibleLabel.TabStop = false; // Set TabStop to false to avoid receiving focus through tab navigation
            invisibleLabel.Select(); // Set focus to the invisible label
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------

        //DATA LOGIC
        //PERSONAL DETAIL SECTION


        //DATE OF BIRTH VALID LOGIC
        private void TextBoxBirthDate_TextChanged(object sender, EventArgs e)
        {
            //^(?!0000)[0-9]{4}/(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])$
            ValidateAndEnableCheckBox();

        }
        private void ValidateDate()
        {
            string date = TextBoxBirthDate.Text.Trim();
            bool isValid = IsValidDate(date);

            if (!isValid)
            {
                MessageBox.Show("Please enter a valid Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxBirthDate.Text = string.Empty; // Optionally clear the TextBox if the email is invalid
                TextBoxBirthDate.Focus();
            }
        }

        private bool IsValidDate(string date)
        {
            if (string.IsNullOrEmpty(date))
                return false;

            DateTime parsedDate;
            bool isValid = DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
            return isValid;
        }


        private void TextBoxBirthDate_Leave(object sender, EventArgs e)
        {
            ValidateDate();
        }






        //_______________________________________________________________________________________________________________________________








        //EMAIL VALID LOGIC
        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            //^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$
            ValidateAndEnableCheckBox();

        }
        private void ValidateEmail()
        {
            string email = TextBoxEmail.Text.Trim();
            bool isValid = IsValidEmail(email);

            if (!isValid)
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxEmail.Text = string.Empty; // Optionally clear the TextBox if the email is invalid
                TextBoxEmail.Focus();
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }





        //_______________________________________________________________________________________________________________________________










        //PHONE NUMBER VALIDATE LOGIC
        private void TextBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateAndEnableCheckBox();

        }
        private void ValidatePhoneNumber()
        {
            string phonenumber = TextBoxPhoneNumber.Text.Trim();
            bool isValid = IsValidPhoneNumber(phonenumber);

            if (!isValid)
            {
                MessageBox.Show("Please enter a valid Phone Number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxPhoneNumber.Text = string.Empty; // Optionally clear the TextBox if the Phone Number is invalid
                TextBoxPhoneNumber.Focus();
            }
        }

        private bool IsValidPhoneNumber(string phonenumber)
        {
            if (string.IsNullOrEmpty(phonenumber))
                return false;

            string PhoneNumberPattern = @"^\d{10}$";
            return Regex.IsMatch(phonenumber, PhoneNumberPattern);

        }

        private void TextBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
        }





        //_______________________________________________________________________________________________________________________________







        //CHECKBOX CHECKING AND TEXT BOX EN/DIS ABLE

        private void ValidateAndEnableCheckBox()
        {

            if (IsValidDate(TextBoxBirthDate.Text) && IsValidEmail(TextBoxEmail.Text) && IsValidPhoneNumber(TextBoxPhoneNumber.Text) == true)
            {
                CheckBoxConfirmPersonalDetails.Enabled = true;
            }
            else
            {
                CheckBoxConfirmPersonalDetails.Enabled = false;
            }
        }

        private void CheckBoxConfirmPersonalDetails_CheckedChanged(object sender, EventArgs e)
        {

            if(CheckBoxConfirmPersonalDetails.Checked==true)
            {
                TextBoxBirthDate.Enabled = false; 
                TextBoxEmail.Enabled = false; 
                TextBoxPhoneNumber.Enabled = false;

                RadioButtonEmail.Enabled = true;
                RadioButtonPhoneNumber.Enabled = true;



            }
            else
            {
                TextBoxBirthDate.Enabled = true;
                TextBoxEmail.Enabled = true;
                TextBoxPhoneNumber.Enabled = true;

                RadioButtonEmail.Enabled = false;
                RadioButtonPhoneNumber.Enabled = false;
            }
        }

        //DATA LOGIC






        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------
        
        


        
        
        
        //OTP logic
        private void ActivateOTP()
        {
            if(RadioButtonEmail.Checked==true || RadioButtonPhoneNumber.Checked==true)
            {
                LinkLabelGetOTP.Enabled = true;
                LabelDisplayOTP.Enabled = true;
                TextBoxOTP.Enabled = true;
                
                
            }
        }

        private void RadioButtonEmail_CheckedChanged(object sender, EventArgs e)
        {
            ActivateOTP();
        }

        private void RadioButtonPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            ActivateOTP();
        }

        //Random 6 digit OTP function
        private string GenerateOTP()
        {
            // Generate a random string for the CAPTCHA
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());

        }
        private void LinkLabelGetOTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Disable the "Get OTP" link
            LinkLabelGetOTP.Enabled = false;

            //Display timer label
            LabelDisplayTimer.Visible = true;

            // Disable radio buttons and checkbox
            RadioButtonEmail.Enabled = false;
            RadioButtonPhoneNumber.Enabled = false;
            CheckBoxConfirmPersonalDetails.Enabled = false;

            // Activate next button
            ButtonNext1.Enabled = true;

            //store the OTP, else nothing is present to campare to
            generatedOTP = GenerateOTP();
            LabelDisplayOTP.Text = generatedOTP;

            // Enable the OTP textbox
            TextBoxOTP.Enabled = true;


            // current time is passed to the otpGenerationTime
            otpGenerationTime = DateTime.Now;

            //Only for timer logic
            //Start timer, make 5:00 initial text visible as in the entire label, start from 5
            OutsideCountdownTimer.Enabled = true;
            LabelDisplayTimer.Visible = true;
            countdownTime = TimeSpan.FromMinutes(5);
        }


        private void OutsideCountdownTimer_Tick(object sender, EventArgs e)
        {
            // Timespan variable to subtract 1 sec when inside loop
            countdownTime -= TimeSpan.FromSeconds(1);

            if (countdownTime.TotalSeconds < 0 && !nextButton1Clicked)
            {
                // Inbuilt function to stop timer
                OutsideCountdownTimer.Stop();
                // Message box function below it is called
                validityoverdisplay();

                // Reset the OTP generation time when the timer expires
                otpGenerationTime = DateTime.MinValue;

                // Re-enable the "Get OTP" button
                LinkLabelGetOTP.Enabled = true;
            }
            else
            {
                // Convert to a string format for display INSIDE THE LABELTIMER through .Text property
                LabelDisplayTimer.Text = countdownTime.ToString(@"mm\:ss");
            }
        }
        void validityoverdisplay()
        {
            if (LabelDisplayTimer.Text == "00:00")
            {
                MessageBox.Show("OTP validity over!");
            }
        }

        private void ButtonNext1_Click(object sender, EventArgs e)
        {
            nextButton1Clicked = true;

            GenerateOTP();
            if (generatedOTP == TextBoxOTP.Text)
            {
                //otp will not be valid after 5 minutes of generation time
                if (DateTime.Now - otpGenerationTime <= TimeSpan.FromMinutes(5))
                {
                    
                    LabelDisplayTimer.Enabled = false;
                    LabelDisplayTimer.Visible = false;
                    TextBoxOTP.Enabled = false;
                    ButtonNext1.Enabled = false;

                    ButtonGenerateUserName.Enabled = true;

                }
                else
                {
                    MessageBox.Show("The OTP is no longer valid. Please generate a new OTP.");
                }
            }
            if (CheckBoxConfirmPersonalDetails.Checked==false)
            {
                MessageBox.Show("Confirm the details first");
            }

            else if (string.IsNullOrEmpty(LabelDisplayOTP.Text) && !string.IsNullOrEmpty(TextBoxOTP.Text))
            {
                MessageBox.Show("Generate an OTP and enter it");
            }
            else if (LabelDisplayOTP.Text != TextBoxOTP.Text)
            {
                MessageBox.Show("The OTP do not match");
            }

        }


        private void LabelDisplayTimer_Click(object sender, EventArgs e)
        {

        }

        private void LabelDisplayOTP_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxOTP_TextChanged(object sender, EventArgs e)
        {

        }


        //OTP logic









        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------












        //NAME GENERATOR
        private List<string> generatedNames = new List<string>(); // Declare a list to store generated names
        private string NameGen()
        {
            // Define an array or list of characters
            string[] characters = { "vito_corleone_", "james_bond_", "ace_ventura_", "hannibal_lecter_", "rocky_balboa_", "tony_montana_", "tyler_durden_", "harry_potter_", "han_solo_", "jack_sparrow_", "travis_bickle_", "patrick_bateman_" };

            // Create a random number generator
            Random random = new Random();

            // Generate a random index to select a character
            int randomIndex = random.Next(0, characters.Length);

            // Get the selected character
            string selectedCharacter = characters[randomIndex];

            // The 'selectedCharacter' variable now contains one of the characters randomly
            return selectedCharacter;
        }

        private string NumberGen()
        {
            //inbuilt random generator
            Random random = new Random();
            int otp = random.Next(1000, 9999);
            return otp.ToString();
        }
        private string GenerateUniqueName()
        {
            string name;
            do
            {
                name = NameGen() + NumberGen();
            } while (generatedNames.Contains(name)); // Check if the generated name exists in the list

            generatedNames.Add(name); // Add the new unique name to the list
            return name;
        }
        private void ButtonGenerateUserName_Click(object sender, EventArgs e)
        {
            LabelDisplayUserName.Text = GenerateUniqueName();
            
            //No redo. disable
            ButtonGenerateUserName.Enabled = false;

            //enable next stage
            TextBoxPassword.Enabled = true;
            TextBoxConfirmPassword.Enabled = true;
            ButtonViewPassword.Enabled = true;
            ButtonViewConfirmPassword.Enabled = true;
            //enable next button
            ButtonNext.Enabled = true;
        }

        private void LabelDisplayUserName_Click(object sender, EventArgs e)
        {

        }
        //NAME GENERATOR






        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------








        //PASSWORD CHECKER

        
        private bool pv = false;
        private void ButtonViewPassword_Click(object sender, EventArgs e)
        {
            if (pv)//true
            {
                TextBoxPassword.PasswordChar = '*';

            }
            else if (!pv)//false
            {
                TextBoxPassword.PasswordChar = '\0';
            }

            pv = !pv;//toggle
        }
       
        private bool cpv = false;
        private void ButtonViewConfirmPassword_Click(object sender, EventArgs e)
        {
            if (cpv)//true
            {
                TextBoxConfirmPassword.PasswordChar = '*';

            }
            else if (!cpv)//false
            {
                TextBoxConfirmPassword.PasswordChar = '\0';
            }

            cpv = !cpv;//toggle
        }





        //_______________________________________________________________________________________________________________________________

        
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = TextBoxPassword.Text;

            // Check password conditions and update checkboxes accordingly
            CB_LowerCase.Checked = ContainsLowerCase(password);
            CB_UpperCase.Checked = ContainsUpperCase(password);
            CB_Number.Checked = ContainsNumber(password);
            CB_SpecialCharacter.Checked = ContainsSpecialCharacter(password);
            CB_12Bits.Checked = IsMinimumLength(password, 12);

        }
        private void TextBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ContainsLowerCase(string password)
        {
            return password.Any(char.IsLower);
        }

        private bool ContainsUpperCase(string password)
        {
            return password.Any(char.IsUpper);
        }

        private bool ContainsNumber(string password)
        {
            return password.Any(char.IsDigit);
        }

        private bool ContainsSpecialCharacter(string password)
        {
            return password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private bool IsMinimumLength(string password, int minLength)
        {
            return password.Length >= minLength;
        }
        private void CB_LowerCase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CB_UpperCase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CB_Number_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CB_SpecialCharacter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CB_12Bits_CheckedChanged(object sender, EventArgs e)
        {

        }




        //END PARTS

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == TextBoxConfirmPassword.Text && CB_LowerCase.Checked == true && CB_UpperCase.Checked == true && CB_Number.Checked == true && CB_SpecialCharacter.Checked == true && CB_12Bits.Checked == true)
            {
                int v = check(TextBoxEmail.Text);
                if (v != 1)
                {
                    connection.Open();

                    // Hashing values before inserting into the database
                    string hashedDate = GetHash(TextBoxBirthDate.Text, MD5.Create());
                    string hashedEmail = GetHash(TextBoxEmail.Text, SHA1.Create());
                    string hashedPhoneNumber = GetHash(TextBoxPhoneNumber.Text, SHA256.Create());
                    string hashedUsername = GetHash(LabelDisplayUserName.Text, SHA384.Create());
                    string hashedPassword = GetHash(TextBoxConfirmPassword.Text, SHA512.Create());



                    SqlCommand command = new SqlCommand("INSERT INTO Signup VALUES(@date, @email, @phonenumber, @username, @password)", connection);
                    command.Parameters.AddWithValue("@date", hashedDate);
                    command.Parameters.AddWithValue("@email", hashedEmail);
                    command.Parameters.AddWithValue("@phonenumber", hashedPhoneNumber);
                    command.Parameters.AddWithValue("@username", hashedUsername);
                    command.Parameters.AddWithValue("@password", hashedPassword);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Registration Successful. Re-open to login.");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Already a User with this email exists. \n Click on Login below / re-open application and login.");
                }
            }
            else if (TextBoxPassword.Text == TextBoxConfirmPassword.Text && (CB_LowerCase.Checked == false || CB_UpperCase.Checked == false || CB_Number.Checked == false || CB_SpecialCharacter.Checked == false || CB_12Bits.Checked == false))
            {
                MessageBox.Show("All conditions not checked");
            }
            else
            {
                MessageBox.Show("Fill in Password and Confirm Password Correctly");
            }
        }

        // Hashing function
        private string GetHash(string input, HashAlgorithm algorithm)
        {
            using (var hasher = algorithm)
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = hasher.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }



        //END PARTS


        //database check via email
        /*
        int check(string email)
        {
            connection.Open();
            string query = "select count (*) from Signup where email ='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;

        }
        */

        private int check(string email)
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM Signup WHERE email = @email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@email", email);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }


        //PASSWORD CHECKER






        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------


        //SIGN UP 
        private void LinkLabelSignUpForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide the current form
            this.Hide();

            Form2 lg = new Form2();
            lg.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
            lg.ShowDialog();
        }
        //SIGN UP

























        //USELESS PANELS

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //USELESS LABELS

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
//The OTP generation here is just for showing how it is done, actual process can be achieved by signing up to differnt service providers.