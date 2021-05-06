using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace DatabasForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstContainer.DoubleClick += lstContainer_MouseDoubleClick;
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbSelect.Text.ToLower();

            List<EleverModel> elever = SqliteDataAccess.LoadEleverList();
            List<VårdnadshavareModel> vårdnadshavare = SqliteDataAccess.LoadVårdnadshavareList();
           
            if (cmbSelect.Text != null)
            {
                string[] huh = { "bananan", "batman", "owo", "trex" };
                lstContainer.Items.Clear();

                foreach (var s in elever)
                {
                    if (select == "elever")
                    {

                        lstContainer.Items.Add(s.ToString());
                    }
                }
                foreach(var s in vårdnadshavare)
                {
                    if (select == "vårdnadshavare")
                    {
                        lstContainer.Items.Add(s.ToString());
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
        
        void lstContainer_MouseDoubleClick(object sender, EventArgs e)
        {
            if(lstContainer.SelectedItem != null)
            {

                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}