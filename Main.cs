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

namespace Camouflage_Shield
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //sql connection
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KIIT\\Desktop\\Camouflage Shield Final1\\P1DB1.mdf\";Integrated Security=True");

        



        private void Main_Load(object sender, EventArgs e)
        {
            this.encryptedDataTableAdapter.FillByUsername(this.p1DB1DataSet.EncryptedData, Form2.UserName);
            LabelDisplayUserName.Text = Form2.UserName;

        }


        //TOP BUTTONS
        private void ButtonENCandSAVE_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            encrypt.ShowDialog();
        }
 
        private void ButtonShowDetails_Click(object sender, EventArgs e)
        {

        }
        private void ButtonVIEW_Click(object sender, EventArgs e)
        {
            TextToPhoto ttp = new TextToPhoto();
            ttp.ShowDialog();
        }




        private void ButtonTE_Click(object sender, EventArgs e)
        {
            hashtext ht = new hashtext();
            ht.ShowDialog();
        }

        //useless lables
        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void LabelDisplayUserName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
