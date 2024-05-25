namespace Camouflage_Shield
{
    partial class hashtext
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
            this.RBP5 = new System.Windows.Forms.RadioButton();
            this.L2 = new System.Windows.Forms.Label();
            this.RBP4 = new System.Windows.Forms.RadioButton();
            this.RBP3 = new System.Windows.Forms.RadioButton();
            this.RBP2 = new System.Windows.Forms.RadioButton();
            this.RBP1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.TextBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RBP5
            // 
            this.RBP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP5.Location = new System.Drawing.Point(100, 320);
            this.RBP5.Margin = new System.Windows.Forms.Padding(4);
            this.RBP5.Name = "RBP5";
            this.RBP5.Size = new System.Drawing.Size(125, 24);
            this.RBP5.TabIndex = 73;
            this.RBP5.TabStop = true;
            this.RBP5.Text = "SHA-512";
            this.RBP5.UseVisualStyleBackColor = true;
            this.RBP5.CheckedChanged += new System.EventHandler(this.RBP5_CheckedChanged);
            // 
            // L2
            // 
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(24, 22);
            this.L2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(294, 30);
            this.L2.TabIndex = 72;
            this.L2.Text = "Select a Process for encryption";
            this.L2.Click += new System.EventHandler(this.L2_Click);
            // 
            // RBP4
            // 
            this.RBP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP4.Location = new System.Drawing.Point(100, 260);
            this.RBP4.Margin = new System.Windows.Forms.Padding(4);
            this.RBP4.Name = "RBP4";
            this.RBP4.Size = new System.Drawing.Size(125, 24);
            this.RBP4.TabIndex = 71;
            this.RBP4.TabStop = true;
            this.RBP4.Text = "SHA-384";
            this.RBP4.UseVisualStyleBackColor = true;
            this.RBP4.CheckedChanged += new System.EventHandler(this.RBP4_CheckedChanged);
            // 
            // RBP3
            // 
            this.RBP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP3.Location = new System.Drawing.Point(100, 197);
            this.RBP3.Margin = new System.Windows.Forms.Padding(4);
            this.RBP3.Name = "RBP3";
            this.RBP3.Size = new System.Drawing.Size(125, 24);
            this.RBP3.TabIndex = 70;
            this.RBP3.TabStop = true;
            this.RBP3.Text = "SHA-256";
            this.RBP3.UseVisualStyleBackColor = true;
            this.RBP3.CheckedChanged += new System.EventHandler(this.RBP3_CheckedChanged);
            // 
            // RBP2
            // 
            this.RBP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP2.Location = new System.Drawing.Point(100, 132);
            this.RBP2.Margin = new System.Windows.Forms.Padding(4);
            this.RBP2.Name = "RBP2";
            this.RBP2.Size = new System.Drawing.Size(125, 24);
            this.RBP2.TabIndex = 69;
            this.RBP2.TabStop = true;
            this.RBP2.Text = "SHA-1";
            this.RBP2.UseVisualStyleBackColor = true;
            this.RBP2.CheckedChanged += new System.EventHandler(this.RBP2_CheckedChanged);
            // 
            // RBP1
            // 
            this.RBP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBP1.Location = new System.Drawing.Point(100, 72);
            this.RBP1.Margin = new System.Windows.Forms.Padding(4);
            this.RBP1.Name = "RBP1";
            this.RBP1.Size = new System.Drawing.Size(125, 24);
            this.RBP1.TabIndex = 68;
            this.RBP1.TabStop = true;
            this.RBP1.Text = "MD5";
            this.RBP1.UseVisualStyleBackColor = true;
            this.RBP1.CheckedChanged += new System.EventHandler(this.RBP1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 75;
            this.label1.Text = "Enter Text For Encryption";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonProcess
            // 
            this.ButtonProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProcess.Location = new System.Drawing.Point(372, 166);
            this.ButtonProcess.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonProcess.Name = "ButtonProcess";
            this.ButtonProcess.Size = new System.Drawing.Size(152, 55);
            this.ButtonProcess.TabIndex = 76;
            this.ButtonProcess.Text = "Process";
            this.ButtonProcess.UseVisualStyleBackColor = true;
            this.ButtonProcess.Click += new System.EventHandler(this.ButtonProcess_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 30);
            this.label2.TabIndex = 77;
            this.label2.Text = "Encrypted Text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCode.Location = new System.Drawing.Point(372, 277);
            this.TextBoxCode.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCode.Multiline = true;
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(400, 80);
            this.TextBoxCode.TabIndex = 78;
            this.TextBoxCode.TextChanged += new System.EventHandler(this.TextBoxCode_TextChanged);
            // 
            // TextBoxText
            // 
            this.TextBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxText.Location = new System.Drawing.Point(372, 56);
            this.TextBoxText.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxText.Multiline = true;
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.Size = new System.Drawing.Size(400, 80);
            this.TextBoxText.TabIndex = 79;
            this.TextBoxText.TextChanged += new System.EventHandler(this.TextBoxText_TextChanged);
            // 
            // hashtext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 415);
            this.Controls.Add(this.TextBoxText);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBP5);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.RBP4);
            this.Controls.Add(this.RBP3);
            this.Controls.Add(this.RBP2);
            this.Controls.Add(this.RBP1);
            this.Name = "hashtext";
            this.Load += new System.EventHandler(this.hashtext_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBP5;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.RadioButton RBP4;
        private System.Windows.Forms.RadioButton RBP3;
        private System.Windows.Forms.RadioButton RBP2;
        private System.Windows.Forms.RadioButton RBP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.TextBox TextBoxText;
    }
}