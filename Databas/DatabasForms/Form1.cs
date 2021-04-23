using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DatabasForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbSelect.Text.ToLower();

            if (cmbSelect.Text != null)
            {
                string[] elever = { "Paco", "Zynyx", "Mini Fruit", "Shonen" };
                string[] huh = { "bananan", "batman", "owo", "trex" };
                lstContainer.Items.Clear();

                foreach (string s in elever)
                {
                    if (select == "elever")
                    {
                        lstContainer.Items.Add(s);
                    }
                }
                foreach(string s in huh)
                {
                    if (select == "vårdnadshavare")
                    {
                        lstContainer.Items.Add(s);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

       
    }
}