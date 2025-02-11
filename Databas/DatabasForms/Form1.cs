﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace DatabasForms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            lstContainer.DoubleClick += LstContainer_MouseDoubleClick;
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbSelect.Text.ToLower();

            List<EleverModel> elever = SqliteDataAccess.LoadEleverList();
            List<VårdnadshavareModel> vårdnadshavare = SqliteDataAccess.LoadVårdnadshavareList();
           
            if (cmbSelect.Text != null)
            {
                lstContainer.Items.Clear();

                foreach (var s in elever)
                {
                    if (select == "elever")
                    {

                        lstContainer.Items.Add(s.GetName());
                    }
                }
                foreach(var s in vårdnadshavare)
                {
                    if (select == "vårdnadshavare")
                    {
                        lstContainer.Items.Add(s.GetName());
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(cmbSelect.Text);
            f2.Show();
        }
        
        void LstContainer_MouseDoubleClick(object sender, EventArgs e)
        {
           

            if (lstContainer.SelectedItem != null)
            {
               
                this.Hide();
                Form2 f2 = new Form2(cmbSelect.Text);
                f2.Show();
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            List<EleverModel> elever = SqliteDataAccess.LoadEleverList();

            foreach (var s in elever)
            { 
                if (s.GetName() == lstContainer.SelectedItem.ToString())
                {
                    SqliteDataAccess.RemoveElev(s.GetPersonnummer());
                }
            }

        }

    }
}