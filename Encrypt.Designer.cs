namespace Camouflage_Shield
{
    partial class Encrypt
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.Label();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.RBP1 = new System.Windows.Forms.RadioButton();
            this.RBP2 = new System.Windows.Forms.RadioButton();
            this.RBP3 = new System.Windows.Forms.RadioButton();
            this.RBP4 = new System.Windows.Forms.RadioButton();
            this.L2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxKey = new System.Windows.Forms.TextBox();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxImageCODE = new System.Windows.Forms.TextBox();
            this.ButtonLockData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonSAVE = new System.Windows.Forms.Button();
            this.RBP5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(7, 4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(305, 267);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // L1
            // 
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(13, 9);
            this.L1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(425, 44);
            this.L1.TabIndex = 4;
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelect.Location = new System.Drawing.Point(19, 410);
            this.ButtonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(132, 55);
            this.ButtonSelect.TabIndex = 50;
            this.ButtonSelect.Text = "Select";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // RBP1
            // 
            this.RBP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP1.Location = new System.Drawing.Point(409, 148);
            this.RBP1.Margin = new System.Windows.Forms.Padding(4);
            this.RBP1.Name = "RBP1";
            this.RBP1.Size = new System.Drawing.Size(125, 24);
            this.RBP1.TabIndex = 51;
            this.RBP1.TabStop = true;
            this.RBP1.Text = "Process 1";
            this.RBP1.UseVisualStyleBackColor = true;
            this.RBP1.CheckedChanged += new System.EventHandler(this.RBP1_CheckedChanged);
            // 
            // RBP2
            // 
            this.RBP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP2.Location = new System.Drawing.Point(409, 208);
            this.RBP2.Margin = new System.Windows.Forms.Padding(4);
            this.RBP2.Name = "RBP2";
            this.RBP2.Size = new System.Drawing.Size(125, 24);
            this.RBP2.TabIndex = 52;
            this.RBP2.TabStop = true;
            this.RBP2.Text = "Process 2";
            this.RBP2.UseVisualStyleBackColor = true;
            this.RBP2.CheckedChanged += new System.EventHandler(this.RBP2_CheckedChanged);
            // 
            // RBP3
            // 
            this.RBP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP3.Location = new System.Drawing.Point(409, 273);
            this.RBP3.Margin = new System.Windows.Forms.Padding(4);
            this.RBP3.Name = "RBP3";
            this.RBP3.Size = new System.Drawing.Size(125, 24);
            this.RBP3.TabIndex = 53;
            this.RBP3.TabStop = true;
            this.RBP3.Text = "Process 3";
            this.RBP3.UseVisualStyleBackColor = true;
            this.RBP3.CheckedChanged += new System.EventHandler(this.RBP3_CheckedChanged);
            // 
            // RBP4
            // 
            this.RBP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP4.Location = new System.Drawing.Point(409, 336);
            this.RBP4.Margin = new System.Windows.Forms.Padding(4);
            this.RBP4.Name = "RBP4";
            this.RBP4.Size = new System.Drawing.Size(125, 24);
            this.RBP4.TabIndex = 54;
            this.RBP4.TabStop = true;
            this.RBP4.Text = "Process 4";
            this.RBP4.UseVisualStyleBackColor = true;
            this.RBP4.CheckedChanged += new System.EventHandler(this.RBP4_CheckedChanged);
            // 
            // L2
            // 
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(322, 100);
            this.L2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(294, 30);
            this.L2.TabIndex = 55;
            this.L2.Text = "Select a Process for encryption";
            this.L2.Click += new System.EventHandler(this.L2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 30);
            this.label1.TabIndex = 56;
            this.label1.Text = "Select an Image To Encrypt";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 30);
            this.label2.TabIndex = 57;
            this.label2.Text = "Enter a key";
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxKey.Location = new System.Drawing.Point(624, 129);
            this.TextBoxKey.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.Size = new System.Drawing.Size(152, 29);
            this.TextBoxKey.TabIndex = 58;
            this.TextBoxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxKey.TextChanged += new System.EventHandler(this.TextBoxKey_TextChanged);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerate.Location = new System.Drawing.Point(624, 275);
            this.ButtonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(152, 55);
            this.ButtonGenerate.TabIndex = 59;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 69);
            this.label3.TabIndex = 60;
            this.label3.Text = "Click Genarate to show the encrypted code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextboxImageCODE
            // 
            this.TextboxImageCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxImageCODE.Location = new System.Drawing.Point(834, 129);
            this.TextboxImageCODE.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxImageCODE.Multiline = true;
            this.TextboxImageCODE.Name = "TextboxImageCODE";
            this.TextboxImageCODE.Size = new System.Drawing.Size(400, 274);
            this.TextboxImageCODE.TabIndex = 62;
            this.TextboxImageCODE.TextChanged += new System.EventHandler(this.TextboxImageCODE_TextChanged);
            // 
            // ButtonLockData
            // 
            this.ButtonLockData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLockData.Location = new System.Drawing.Point(624, 193);
            this.ButtonLockData.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLockData.Name = "ButtonLockData";
            this.ButtonLockData.Size = new System.Drawing.Size(152, 55);
            this.ButtonLockData.TabIndex = 63;
            this.ButtonLockData.Text = "Lock Data";
            this.ButtonLockData.UseVisualStyleBackColor = true;
            this.ButtonLockData.Click += new System.EventHandler(this.ButtonLockData_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.PictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 274);
            this.panel1.TabIndex = 64;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(834, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 30);
            this.label4.TabIndex = 65;
            this.label4.Text = "Encrypted Image Code";
            // 
            // ButtonSAVE
            // 
            this.ButtonSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSAVE.Location = new System.Drawing.Point(1102, 411);
            this.ButtonSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSAVE.Name = "ButtonSAVE";
            this.ButtonSAVE.Size = new System.Drawing.Size(132, 55);
            this.ButtonSAVE.TabIndex = 66;
            this.ButtonSAVE.Text = "SAVE";
            this.ButtonSAVE.UseVisualStyleBackColor = true;
            this.ButtonSAVE.Click += new System.EventHandler(this.ButtonSAVE_Click);
            // 
            // RBP5
            // 
            this.RBP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP5.Location = new System.Drawing.Point(409, 396);
            this.RBP5.Margin = new System.Windows.Forms.Padding(4);
            this.RBP5.Name = "RBP5";
            this.RBP5.Size = new System.Drawing.Size(125, 24);
            this.RBP5.TabIndex = 67;
            this.RBP5.TabStop = true;
            this.RBP5.Text = "Process 5";
            this.RBP5.UseVisualStyleBackColor = true;
            this.RBP5.CheckedChanged += new System.EventHandler(this.RBP5_CheckedChanged);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 502);
            this.Controls.Add(this.RBP5);
            this.Controls.Add(this.ButtonSAVE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonLockData);
            this.Controls.Add(this.TextboxImageCODE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.TextBoxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.RBP4);
            this.Controls.Add(this.RBP3);
            this.Controls.Add(this.RBP2);
            this.Controls.Add(this.RBP1);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.L1);
            this.Name = "Encrypt";
            this.Text = "Encrypt";
            this.Load += new System.EventHandler(this.Encrypt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.RadioButton RBP1;
        private System.Windows.Forms.RadioButton RBP2;
        private System.Windows.Forms.RadioButton RBP3;
        private System.Windows.Forms.RadioButton RBP4;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxKey;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxImageCODE;
        private System.Windows.Forms.Button ButtonLockData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonSAVE;
        private System.Windows.Forms.RadioButton RBP5;
    }
}