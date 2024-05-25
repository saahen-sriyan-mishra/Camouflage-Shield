namespace Camouflage_Shield
{
    partial class Main
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
            this.L1 = new System.Windows.Forms.Label();
            this.LabelDisplayUserName = new System.Windows.Forms.Label();
            this.ButtonENCandSAVE = new System.Windows.Forms.Button();
            this.PanelFix = new System.Windows.Forms.Panel();
            this.ButtonVIEW = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.encryptedDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p1DB1DataSet = new Camouflage_Shield.P1DB1DataSet();
            this.encryptedDataTableAdapter = new Camouflage_Shield.P1DB1DataSetTableAdapters.EncryptedDataTableAdapter();
            this.ButtonTE = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encryptedTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelFix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptedDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1DB1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(4, 23);
            this.L1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(595, 44);
            this.L1.TabIndex = 3;
            this.L1.Text = "Welcome User ";
            this.L1.Click += new System.EventHandler(this.L1_Click);
            // 
            // LabelDisplayUserName
            // 
            this.LabelDisplayUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDisplayUserName.Location = new System.Drawing.Point(241, 23);
            this.LabelDisplayUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDisplayUserName.Name = "LabelDisplayUserName";
            this.LabelDisplayUserName.Size = new System.Drawing.Size(358, 44);
            this.LabelDisplayUserName.TabIndex = 4;
            this.LabelDisplayUserName.Click += new System.EventHandler(this.LabelDisplayUserName_Click);
            // 
            // ButtonENCandSAVE
            // 
            this.ButtonENCandSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonENCandSAVE.Location = new System.Drawing.Point(641, 23);
            this.ButtonENCandSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonENCandSAVE.Name = "ButtonENCandSAVE";
            this.ButtonENCandSAVE.Size = new System.Drawing.Size(132, 55);
            this.ButtonENCandSAVE.TabIndex = 49;
            this.ButtonENCandSAVE.Text = "Encrypt/ Save";
            this.ButtonENCandSAVE.UseVisualStyleBackColor = true;
            this.ButtonENCandSAVE.Click += new System.EventHandler(this.ButtonENCandSAVE_Click);
            // 
            // PanelFix
            // 
            this.PanelFix.AutoScroll = true;
            this.PanelFix.Controls.Add(this.ButtonVIEW);
            this.PanelFix.Controls.Add(this.LabelDisplayUserName);
            this.PanelFix.Controls.Add(this.ButtonENCandSAVE);
            this.PanelFix.Controls.Add(this.L1);
            this.PanelFix.Location = new System.Drawing.Point(13, 12);
            this.PanelFix.Name = "PanelFix";
            this.PanelFix.Size = new System.Drawing.Size(942, 100);
            this.PanelFix.TabIndex = 52;
            // 
            // ButtonVIEW
            // 
            this.ButtonVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVIEW.Location = new System.Drawing.Point(790, 23);
            this.ButtonVIEW.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonVIEW.Name = "ButtonVIEW";
            this.ButtonVIEW.Size = new System.Drawing.Size(132, 55);
            this.ButtonVIEW.TabIndex = 53;
            this.ButtonVIEW.Text = "View Image";
            this.ButtonVIEW.UseVisualStyleBackColor = true;
            this.ButtonVIEW.Click += new System.EventHandler(this.ButtonVIEW_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.encryptedTextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.encryptedDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 555);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // encryptedDataBindingSource
            // 
            this.encryptedDataBindingSource.DataMember = "EncryptedData";
            this.encryptedDataBindingSource.DataSource = this.p1DB1DataSet;
            // 
            // p1DB1DataSet
            // 
            this.p1DB1DataSet.DataSetName = "P1DB1DataSet";
            this.p1DB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encryptedDataTableAdapter
            // 
            this.encryptedDataTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonTE
            // 
            this.ButtonTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTE.Location = new System.Drawing.Point(654, 195);
            this.ButtonTE.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonTE.Name = "ButtonTE";
            this.ButtonTE.Size = new System.Drawing.Size(281, 55);
            this.ButtonTE.TabIndex = 54;
            this.ButtonTE.Text = "Use Hash Text Encrypter";
            this.ButtonTE.UseVisualStyleBackColor = true;
            this.ButtonTE.Click += new System.EventHandler(this.ButtonTE_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // encryptedTextDataGridViewTextBoxColumn
            // 
            this.encryptedTextDataGridViewTextBoxColumn.DataPropertyName = "EncryptedText";
            this.encryptedTextDataGridViewTextBoxColumn.HeaderText = "EncryptedText";
            this.encryptedTextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.encryptedTextDataGridViewTextBoxColumn.Name = "encryptedTextDataGridViewTextBoxColumn";
            this.encryptedTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.encryptedTextDataGridViewTextBoxColumn.Width = 125;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(972, 738);
            this.Controls.Add(this.ButtonTE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PanelFix);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PanelFix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptedDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1DB1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label LabelDisplayUserName;
        private System.Windows.Forms.Button ButtonENCandSAVE;
        private System.Windows.Forms.Panel PanelFix;
        private System.Windows.Forms.Button ButtonVIEW;
        private System.Windows.Forms.DataGridView dataGridView1;
        private P1DB1DataSet p1DB1DataSet;
        private System.Windows.Forms.BindingSource encryptedDataBindingSource;
        private P1DB1DataSetTableAdapters.EncryptedDataTableAdapter encryptedDataTableAdapter;
        private System.Windows.Forms.Button ButtonTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encryptedTextDataGridViewTextBoxColumn;
    }
}