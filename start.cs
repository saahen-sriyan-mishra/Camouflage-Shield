using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camouflage_Shield
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            Form2 lg = new Form2();
            lg.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
            lg.ShowDialog();
        }

        private void start_Load(object sender, EventArgs e)
        {
 
        }

        private void ButtonSignUp_Click_1(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            Form1 su = new Form1();
            su.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
            su.ShowDialog();
        }
    }
}
