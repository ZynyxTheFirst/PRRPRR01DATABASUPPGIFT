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
        public Form2(string strComboBox)
        {
            InitializeComponent();

            lstViewBox.View = View.Details;
            cmbSelect.Text = strComboBox;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void CmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbSelect.Text.ToLower();
            lstViewBox.Columns.Clear();
            lstViewBox.Items.Clear();
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
                lstViewBox.Columns.Add("Personnummer", width: 150);
                lstViewBox.Columns.Add("Namn", width: 150);
                lstViewBox.Columns.Add("Adress", width: 150);
                lstViewBox.Columns.Add("E-post", width: 150);
                lstViewBox.Columns.Add("Telefonnummer", width: 150);
                lstViewBox.Columns.Add("Klass", width: 150);

                lbl1.Text = "Personnummer";
                lbl2.Text = "Namn";
                lbl3.Text = "Adress";
                lbl4.Text = "E-post";
                lbl5.Text = "Telefonnummer";
                lbl6.Text = "Klass";

                lbl6.Show();
                txtBox6.Show();
            }

            if (select == "vårdnadshavare")
            {
                lstViewBox.Columns.Add("Personnummer", width: 150);
                lstViewBox.Columns.Add("Namn", width: 150);
                lstViewBox.Columns.Add("Adress", width: 150);
                lstViewBox.Columns.Add("E-post", width: 150);
                lstViewBox.Columns.Add("Telefonnummer", width: 150);

                lbl1.Text = "Personnummer";
                lbl2.Text = "Namn";
                lbl3.Text = "Adress";
                lbl4.Text = "E-post";
                lbl5.Text = "Telefonnummer";

                lbl6.Hide();
                txtBox6.Hide();
            }
        }
        
        private void AddElever(String personnummer, String name, String adress, String epost, String telefonnummer, String klass)
        {
            String[] row = { personnummer, name, adress, epost, telefonnummer, klass };

            ListViewItem item = new ListViewItem(row);

            lstViewBox.Items.Add(item);
        }



        private void LstViewBox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstViewBox.Columns[e.ColumnIndex].Width;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddElever(txtBox1.Text, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtBox5.Text, txtBox6.Text);

            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
            txtBox4.Text = "";
            txtBox5.Text = "";
            txtBox6.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
