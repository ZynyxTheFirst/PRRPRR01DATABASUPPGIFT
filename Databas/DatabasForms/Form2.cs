using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabasForms
{
    public partial class Form2 : Form
    {
        
        public List<EleverModel> elever { get; set; }
        public List<VårdnadshavareModel> vårdnadshavare { get; set; }
        

        public Form2(string strComboBox)
        {
            elever = GetElever();
            vårdnadshavare = GetVårdnadshavare();
            InitializeComponent();

            lstViewBox.View = View.Details;
            cmbSelect.Text = strComboBox;
        }

        private List<VårdnadshavareModel> GetVårdnadshavare()
        {
            List<VårdnadshavareModel> vårdnadshavare = SqliteDataAccess.LoadVårdnadshavareList();
            return vårdnadshavare;

        }

        private List<EleverModel> GetElever()
        {
            List<EleverModel> elever = SqliteDataAccess.LoadEleverList();

            return elever;
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
                var elever = this.elever;

                dataGridView1.DataSource = elever;

           
            }

            if (select == "vårdnadshavare")
            {
                var vårdnadshavare = this.vårdnadshavare;
                dataGridView1.DataSource = vårdnadshavare;
            }
        }


        private void LstViewBox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstViewBox.Columns[e.ColumnIndex].Width;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int txtbox1int = Int32.Parse(txtBox1.Text);
            int txtbox5int = Int32.Parse(txtBox5.Text);
            EleverModel elev = new EleverModel(txtbox1int, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtbox5int, txtBox6.Text);
            SqliteDataAccess.AddElev(elev);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Environment.Exit(0);
            }

       
    }

        
}

