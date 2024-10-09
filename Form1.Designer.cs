namespace Camouflage_Shield
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBoxConfirmPersonalDetails = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButtonEmail = new System.Windows.Forms.RadioButton();
            this.RadioButtonPhoneNumber = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelDisplayUserName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CB_LowerCase = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.CB_UpperCase = new System.Windows.Forms.CheckBox();
            this.CB_Number = new System.Windows.Forms.CheckBox();
            this.CB_SpecialCharacter = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxOTP = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.CB_12Bits = new System.Windows.Forms.CheckBox();
            this.LabelDisplayOTP = new System.Windows.Forms.Label();
            this.LinkLabelGetOTP = new System.Windows.Forms.LinkLabel();
            this.LabelDisplayTimer = new System.Windows.Forms.Label();
            this.ButtonGenerateUserName = new System.Windows.Forms.Button();
            this.OutsideCountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonNext = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.LinkLabelSignUpForm = new System.Windows.Forms.LinkLabel();
            this.TextBoxBirthDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ButtonNext1 = new System.Windows.Forms.Button();
            this.ButtonViewPassword = new System.Windows.Forms.Button();
            this.ButtonViewConfirmPassword = new System.Windows.Forms.Button();
            this.invisibleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Of Birth";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill Out Your Details/Credentials";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 472);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter OTP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CheckBoxConfirmPersonalDetails
            // 
            this.CheckBoxConfirmPersonalDetails.BackColor = System.Drawing.Color.Silver;
            this.CheckBoxConfirmPersonalDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckBoxConfirmPersonalDetails.FlatAppearance.BorderSize = 5;
            this.CheckBoxConfirmPersonalDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.CheckBoxConfirmPersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxConfirmPersonalDetails.Location = new System.Drawing.Point(301, 270);
            this.CheckBoxConfirmPersonalDetails.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxConfirmPersonalDetails.Name = "CheckBoxConfirmPersonalDetails";
            this.CheckBoxConfirmPersonalDetails.Size = new System.Drawing.Size(511, 31);
            this.CheckBoxConfirmPersonalDetails.TabIndex = 6;
            this.CheckBoxConfirmPersonalDetails.Text = "Check The Box to confirm the above entered information";
            this.CheckBoxConfirmPersonalDetails.UseVisualStyleBackColor = false;
            this.CheckBoxConfirmPersonalDetails.CheckedChanged += new System.EventHandler(this.CheckBoxConfirmPersonalDetails_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 60);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RadioButtonEmail
            // 
            this.RadioButtonEmail.AutoSize = true;
            this.RadioButtonEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonEmail.Location = new System.Drawing.Point(479, 323);
            this.RadioButtonEmail.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonEmail.Name = "RadioButtonEmail";
            this.RadioButtonEmail.Size = new System.Drawing.Size(72, 24);
            this.RadioButtonEmail.TabIndex = 8;
            this.RadioButtonEmail.TabStop = true;
            this.RadioButtonEmail.Text = "Email";
            this.RadioButtonEmail.UseVisualStyleBackColor = true;
            this.RadioButtonEmail.CheckedChanged += new System.EventHandler(this.RadioButtonEmail_CheckedChanged);
            // 
            // RadioButtonPhoneNumber
            // 
            this.RadioButtonPhoneNumber.AutoSize = true;
            this.RadioButtonPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonPhoneNumber.Location = new System.Drawing.Point(617, 323);
            this.RadioButtonPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonPhoneNumber.Name = "RadioButtonPhoneNumber";
            this.RadioButtonPhoneNumber.Size = new System.Drawing.Size(141, 24);
            this.RadioButtonPhoneNumber.TabIndex = 9;
            this.RadioButtonPhoneNumber.TabStop = true;
            this.RadioButtonPhoneNumber.Text = "Phone Number";
            this.RadioButtonPhoneNumber.UseVisualStyleBackColor = true;
            this.RadioButtonPhoneNumber.CheckedChanged += new System.EventHandler(this.RadioButtonPhoneNumber_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select One To Get OTP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(268, 367);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(599, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Click HERE to get the OTP. It is valid for 5 minutes only.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 427);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "Your OTP is";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(160, 603);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(629, 31);
            this.label10.TabIndex = 13;
            this.label10.Text = "Click The GENERATE Buton to get yor Unique Username.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(160, 634);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(851, 31);
            this.label11.TabIndex = 14;
            this.label11.Text = "(Remember your Username because it cannot be changed, and is essential for you to" +
    " login.)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // LabelDisplayUserName
            // 
            this.LabelDisplayUserName.BackColor = System.Drawing.Color.White;
            this.LabelDisplayUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelDisplayUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDisplayUserName.Location = new System.Drawing.Point(479, 665);
            this.LabelDisplayUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDisplayUserName.Name = "LabelDisplayUserName";
            this.LabelDisplayUserName.Size = new System.Drawing.Size(332, 36);
            this.LabelDisplayUserName.TabIndex = 15;
            this.LabelDisplayUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDisplayUserName.Click += new System.EventHandler(this.LabelDisplayUserName_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(208, 798);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 31);
            this.label13.TabIndex = 16;
            this.label13.Text = "Enter PASSWORD";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(208, 874);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 31);
            this.label14.TabIndex = 17;
            this.label14.Text = "Confirm PASSWORD";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // CB_LowerCase
            // 
            this.CB_LowerCase.BackColor = System.Drawing.Color.Silver;
            this.CB_LowerCase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CB_LowerCase.FlatAppearance.BorderSize = 5;
            this.CB_LowerCase.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.CB_LowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_LowerCase.Location = new System.Drawing.Point(941, 836);
            this.CB_LowerCase.Margin = new System.Windows.Forms.Padding(4);
            this.CB_LowerCase.Name = "CB_LowerCase";
            this.CB_LowerCase.Size = new System.Drawing.Size(279, 31);
            this.CB_LowerCase.TabIndex = 18;
            this.CB_LowerCase.Text = "   Must   Use   Lowercase";
            this.CB_LowerCase.UseVisualStyleBackColor = false;
            this.CB_LowerCase.CheckedChanged += new System.EventHandler(this.CB_LowerCase_CheckedChanged);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(969, 801);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 31);
            this.label15.TabIndex = 19;
            this.label15.Text = "Password Conditions";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label16);
            this.panel2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(16, 530);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 60);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(360, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(436, 38);
            this.label16.TabIndex = 1;
            this.label16.Text = "Get Your USERNAME";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label17);
            this.panel3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(16, 724);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1219, 57);
            this.panel3.TabIndex = 21;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(360, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(436, 38);
            this.label17.TabIndex = 1;
            this.label17.Text = "Create a PASSWORD";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // CB_UpperCase
            // 
            this.CB_UpperCase.BackColor = System.Drawing.Color.Silver;
            this.CB_UpperCase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CB_UpperCase.FlatAppearance.BorderSize = 5;
            this.CB_UpperCase.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.CB_UpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_UpperCase.Location = new System.Drawing.Point(941, 876);
            this.CB_UpperCase.Margin = new System.Windows.Forms.Padding(4);
            this.CB_UpperCase.Name = "CB_UpperCase";
            this.CB_UpperCase.Size = new System.Drawing.Size(279, 31);
            this.CB_UpperCase.TabIndex = 22;
            this.CB_UpperCase.Text = "   Must   Use   Uppercase";
            this.CB_UpperCase.UseVisualStyleBackColor = false;
            this.CB_UpperCase.CheckedChanged += new System.EventHandler(this.CB_UpperCase_CheckedChanged);
            // 
            // CB_Number
            // 
            this.CB_Number.BackColor = System.Drawing.Color.Silver;
            this.CB_Number.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CB_Number.FlatAppearance.BorderSize = 5;
            this.CB_Number.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.CB_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Number.Location = new System.Drawing.Point(941, 915);
            this.CB_Number.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Number.Name = "CB_Number";
            this.CB_Number.Size = new System.Drawing.Size(279, 31);
            this.CB_Number.TabIndex = 23;
            this.CB_Number.Text = "Must Use Numeric Character";
            this.CB_Number.UseVisualStyleBackColor = false;
            this.CB_Number.CheckedChanged += new System.EventHandler(this.CB_Number_CheckedChanged);
            // 
            // CB_SpecialCharacter
            // 
            this.CB_SpecialCharacter.BackColor = System.Drawing.Color.Silver;
            this.CB_SpecialCharacter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CB_SpecialCharacter.FlatAppearance.BorderSize = 5;
            this.CB_SpecialCharacter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.CB_SpecialCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_SpecialCharacter.Location = new System.Drawing.Point(941, 954);
            this.CB_SpecialCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.CB_SpecialCharacter.Name = "CB_SpecialCharacter";
            this.CB_SpecialCharacter.Size = new System.Drawing.Size(279, 31);
            this.CB_SpecialCharacter.TabIndex = 24;
            this.CB_SpecialCharacter.Text = "Must Use Special Character";
            this.CB_SpecialCharacter.UseVisualStyleBackColor = false;
            this.CB_SpecialCharacter.CheckedChanged += new System.EventHandler(this.CB_SpecialCharacter_CheckedChanged);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(208, 833);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(373, 31);
            this.label18.TabIndex = 25;
            this.label18.Text = "(All password conditions must be satisfied)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.Location = new System.Drawing.Point(352, 154);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(431, 29);
            this.TextBoxEmail.TabIndex = 26;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(352, 209);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(264, 29);
            this.TextBoxPhoneNumber.TabIndex = 27;
            this.TextBoxPhoneNumber.TextChanged += new System.EventHandler(this.TextBoxPhoneNumber_TextChanged);
            // 
            // TextBoxOTP
            // 
            this.TextBoxOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOTP.Location = new System.Drawing.Point(479, 474);
            this.TextBoxOTP.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxOTP.Name = "TextBoxOTP";
            this.TextBoxOTP.Size = new System.Drawing.Size(332, 29);
            this.TextBoxOTP.TabIndex = 28;
            this.TextBoxOTP.TextChanged += new System.EventHandler(this.TextBoxOTP_TextChanged);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(480, 800);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(332, 29);
            this.TextBoxPassword.TabIndex = 29;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // TextBoxConfirmPassword
            // 
            this.TextBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(479, 878);
            this.TextBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.PasswordChar = '*';
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(332, 29);
            this.TextBoxConfirmPassword.TabIndex = 30;
            this.TextBoxConfirmPassword.TextChanged += new System.EventHandler(this.TextBoxConfirmPassword_TextChanged);
            // 
            // CB_12Bits
            // 
            this.CB_12Bits.BackColor = System.Drawing.Color.Silver;
            this.CB_12Bits.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CB_12Bits.FlatAppearance.BorderSize = 5;
            this.CB_12Bits.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.CB_12Bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_12Bits.Location = new System.Drawing.Point(941, 993);
            this.CB_12Bits.Margin = new System.Windows.Forms.Padding(4);
            this.CB_12Bits.Name = "CB_12Bits";
            this.CB_12Bits.Size = new System.Drawing.Size(279, 31);
            this.CB_12Bits.TabIndex = 31;
            this.CB_12Bits.Text = "Must  have  12  Bits  atleast";
            this.CB_12Bits.UseVisualStyleBackColor = false;
            this.CB_12Bits.CheckedChanged += new System.EventHandler(this.CB_12Bits_CheckedChanged);
            // 
            // LabelDisplayOTP
            // 
            this.LabelDisplayOTP.BackColor = System.Drawing.Color.White;
            this.LabelDisplayOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelDisplayOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDisplayOTP.Location = new System.Drawing.Point(479, 427);
            this.LabelDisplayOTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDisplayOTP.Name = "LabelDisplayOTP";
            this.LabelDisplayOTP.Size = new System.Drawing.Size(333, 30);
            this.LabelDisplayOTP.TabIndex = 32;
            this.LabelDisplayOTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDisplayOTP.Click += new System.EventHandler(this.LabelDisplayOTP_Click);
            // 
            // LinkLabelGetOTP
            // 
            this.LinkLabelGetOTP.AutoSize = true;
            this.LinkLabelGetOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelGetOTP.Location = new System.Drawing.Point(372, 372);
            this.LinkLabelGetOTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabelGetOTP.Name = "LinkLabelGetOTP";
            this.LinkLabelGetOTP.Size = new System.Drawing.Size(56, 20);
            this.LinkLabelGetOTP.TabIndex = 33;
            this.LinkLabelGetOTP.TabStop = true;
            this.LinkLabelGetOTP.Text = "HERE";
            this.LinkLabelGetOTP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGetOTP_LinkClicked);
            // 
            // LabelDisplayTimer
            // 
            this.LabelDisplayTimer.BackColor = System.Drawing.Color.White;
            this.LabelDisplayTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelDisplayTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDisplayTimer.Location = new System.Drawing.Point(892, 367);
            this.LabelDisplayTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDisplayTimer.Name = "LabelDisplayTimer";
            this.LabelDisplayTimer.Size = new System.Drawing.Size(118, 36);
            this.LabelDisplayTimer.TabIndex = 34;
            this.LabelDisplayTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDisplayTimer.Click += new System.EventHandler(this.LabelDisplayTimer_Click);
            // 
            // ButtonGenerateUserName
            // 
            this.ButtonGenerateUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerateUserName.Location = new System.Drawing.Point(258, 669);
            this.ButtonGenerateUserName.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonGenerateUserName.Name = "ButtonGenerateUserName";
            this.ButtonGenerateUserName.Size = new System.Drawing.Size(147, 37);
            this.ButtonGenerateUserName.TabIndex = 38;
            this.ButtonGenerateUserName.Text = "GENERATE";
            this.ButtonGenerateUserName.UseVisualStyleBackColor = true;
            this.ButtonGenerateUserName.Click += new System.EventHandler(this.ButtonGenerateUserName_Click);
            // 
            // OutsideCountdownTimer
            // 
            this.OutsideCountdownTimer.Tick += new System.EventHandler(this.OutsideCountdownTimer_Tick);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(665, 945);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(147, 37);
            this.ButtonNext.TabIndex = 39;
            this.ButtonNext.Text = "NEXT";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(260, 993);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(529, 31);
            this.label12.TabIndex = 40;
            this.label12.Text = "Click LOGIN if you already have an account.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // LinkLabelSignUpForm
            // 
            this.LinkLabelSignUpForm.AutoSize = true;
            this.LinkLabelSignUpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSignUpForm.Location = new System.Drawing.Point(316, 993);
            this.LinkLabelSignUpForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabelSignUpForm.Name = "LinkLabelSignUpForm";
            this.LinkLabelSignUpForm.Size = new System.Drawing.Size(87, 29);
            this.LinkLabelSignUpForm.TabIndex = 41;
            this.LinkLabelSignUpForm.TabStop = true;
            this.LinkLabelSignUpForm.Text = "LOGIN";
            this.LinkLabelSignUpForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSignUpForm_LinkClicked);
            // 
            // TextBoxBirthDate
            // 
            this.TextBoxBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBirthDate.Location = new System.Drawing.Point(352, 92);
            this.TextBoxBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBirthDate.Name = "TextBoxBirthDate";
            this.TextBoxBirthDate.Size = new System.Drawing.Size(264, 29);
            this.TextBoxBirthDate.TabIndex = 42;
            this.TextBoxBirthDate.TextChanged += new System.EventHandler(this.TextBoxBirthDate_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(639, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 43;
            this.label4.Text = "(dd/mm/yyyy)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(635, 209);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 29);
            this.label19.TabIndex = 44;
            this.label19.Text = "10 digits only";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // ButtonNext1
            // 
            this.ButtonNext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext1.Location = new System.Drawing.Point(892, 474);
            this.ButtonNext1.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNext1.Name = "ButtonNext1";
            this.ButtonNext1.Size = new System.Drawing.Size(118, 32);
            this.ButtonNext1.TabIndex = 45;
            this.ButtonNext1.Text = "NEXT";
            this.ButtonNext1.UseVisualStyleBackColor = true;
            this.ButtonNext1.Click += new System.EventHandler(this.ButtonNext1_Click);
            // 
            // ButtonViewPassword
            // 
            this.ButtonViewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewPassword.Location = new System.Drawing.Point(820, 801);
            this.ButtonViewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonViewPassword.Name = "ButtonViewPassword";
            this.ButtonViewPassword.Size = new System.Drawing.Size(82, 28);
            this.ButtonViewPassword.TabIndex = 46;
            this.ButtonViewPassword.Text = "VIEW";
            this.ButtonViewPassword.UseVisualStyleBackColor = true;
            this.ButtonViewPassword.Click += new System.EventHandler(this.ButtonViewPassword_Click);
            // 
            // ButtonViewConfirmPassword
            // 
            this.ButtonViewConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewConfirmPassword.Location = new System.Drawing.Point(820, 880);
            this.ButtonViewConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonViewConfirmPassword.Name = "ButtonViewConfirmPassword";
            this.ButtonViewConfirmPassword.Size = new System.Drawing.Size(82, 28);
            this.ButtonViewConfirmPassword.TabIndex = 47;
            this.ButtonViewConfirmPassword.Text = "VIEW";
            this.ButtonViewConfirmPassword.UseVisualStyleBackColor = true;
            this.ButtonViewConfirmPassword.Click += new System.EventHandler(this.ButtonViewConfirmPassword_Click);
            // 
            // invisibleLabel
            // 
            this.invisibleLabel.AutoSize = true;
            this.invisibleLabel.Location = new System.Drawing.Point(811, 96);
            this.invisibleLabel.Name = "invisibleLabel";
            this.invisibleLabel.Size = new System.Drawing.Size(0, 16);
            this.invisibleLabel.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1250, 1035);
            this.Controls.Add(this.invisibleLabel);
            this.Controls.Add(this.ButtonViewConfirmPassword);
            this.Controls.Add(this.ButtonViewPassword);
            this.Controls.Add(this.ButtonNext1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxBirthDate);
            this.Controls.Add(this.LinkLabelSignUpForm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonGenerateUserName);
            this.Controls.Add(this.LabelDisplayTimer);
            this.Controls.Add(this.LinkLabelGetOTP);
            this.Controls.Add(this.LabelDisplayOTP);
            this.Controls.Add(this.CB_12Bits);
            this.Controls.Add(this.TextBoxConfirmPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxOTP);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CB_SpecialCharacter);
            this.Controls.Add(this.CB_Number);
            this.Controls.Add(this.CB_UpperCase);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CB_LowerCase);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LabelDisplayUserName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RadioButtonPhoneNumber);
            this.Controls.Add(this.RadioButtonEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckBoxConfirmPersonalDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckBoxConfirmPersonalDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButtonEmail;
        private System.Windows.Forms.RadioButton RadioButtonPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelDisplayUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CB_LowerCase;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox CB_UpperCase;
        private System.Windows.Forms.CheckBox CB_Number;
        private System.Windows.Forms.CheckBox CB_SpecialCharacter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxOTP;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxConfirmPassword;
        private System.Windows.Forms.CheckBox CB_12Bits;
        private System.Windows.Forms.Label LabelDisplayOTP;
        private System.Windows.Forms.LinkLabel LinkLabelGetOTP;
        private System.Windows.Forms.Label LabelDisplayTimer;
        private System.Windows.Forms.Button ButtonGenerateUserName;
        private System.Windows.Forms.Timer OutsideCountdownTimer;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel LinkLabelSignUpForm;
        private System.Windows.Forms.TextBox TextBoxBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button ButtonNext1;
        private System.Windows.Forms.Button ButtonViewPassword;
        private System.Windows.Forms.Button ButtonViewConfirmPassword;
        private System.Windows.Forms.Label invisibleLabel;
    }
}

