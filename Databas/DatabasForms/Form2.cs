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
            if (select == "elever")
            {
                lstViewBox.Columns.Add("Namn", width: 100);
                lstViewBox.Columns.Add("Vårdnadshavare", width: 100);
                lstViewBox.Columns.Add("ID", width: 100);
            }
        }

        private void lstViewBox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstViewBox.Columns[e.ColumnIndex].Width;
        }
    }
}
