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

/*
        private void Form2_Load(object sender, EventArgs e)
        {
            var Elever = GetEleverList();
        }

        private List<Elever> GetEleverList()
        {
            throw new NotImplementedException();
        }
*/
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbSelect.Text.ToLower();
            lstViewBox.Columns.Clear();
            lstViewBox.View = View.Details;
            lblOne.Text = "-----";
            if (select == "elever")
            {
                lstViewBox.Columns.Add("Namn", width: 150);
                lstViewBox.Columns.Add("Vårdnadshavare", width: 150);
                lstViewBox.Columns.Add("Personnummer", width: 150);
                lstViewBox.Columns.Add("Adress", width: 150);
                lstViewBox.Columns.Add("E-post", width: 150);
                lstViewBox.Columns.Add("Klass", width: 150);

                lblOne.Text = "Namn";
            }
        }

        private void lstViewBox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstViewBox.Columns[e.ColumnIndex].Width;
        }

    }
}
