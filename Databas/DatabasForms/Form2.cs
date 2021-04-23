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

            lstViewBox.View = View.Details;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbSelect.Text.ToLower();
            lstViewBox.Columns.Clear();
            lstViewBox.FullRowSelect = true;

            #region Label Startup
            lbl1.Text = "-----";
            lbl2.Text = "-----";
            lbl3.Text = "-----";
            lbl4.Text = "-----";
            lbl5.Text = "-----";
            lbl6.Text = "-----";
            #endregion

            if (select == "elever")
            {
                lstViewBox.Columns.Add("Namn", width: 150);
                lstViewBox.Columns.Add("Vårdnadshavare", width: 150);
                lstViewBox.Columns.Add("Personnummer", width: 150);
                lstViewBox.Columns.Add("Adress", width: 150);
                lstViewBox.Columns.Add("E-post", width: 150);
                lstViewBox.Columns.Add("Klass", width: 150);

                lbl1.Text = "Namn";
                lbl2.Text = "Vårdnadshavare";
                lbl3.Text = "Personnummer";
                lbl4.Text = "Adress";
                lbl5.Text = "E-post";
                lbl6.Text = "Klass";

                lbl6.Hide();
            }
        }
        

        private void lstViewBox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstViewBox.Columns[e.ColumnIndex].Width;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void AddElever()
        {

        }
    }
}
