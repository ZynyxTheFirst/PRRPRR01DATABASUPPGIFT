using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatabasForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

<<<<<<< Updated upstream
       
       
=======
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int txtbox1int = Int32.Parse(txtBox1.Text);
            int txtbox5int = Int32.Parse(txtBox5.Text);

            SqliteDataAccess.NewElev(txtbox1int, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtbox5int, txtBox6.Text);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
>>>>>>> Stashed changes
    }
}
