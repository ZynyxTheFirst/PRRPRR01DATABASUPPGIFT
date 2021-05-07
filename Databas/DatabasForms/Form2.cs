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
        [System.ComponentModel.Browsable(false)]
        public System.Windows.Forms.DataGridViewRow CurrentRow { get; }

        public List<EleverModel> elever { get; set; }
        public List<VårdnadshavareModel> vårdnadshavare { get; set; } 

        public Form2(string strComboBox)
        {
            elever = GetElever();
            vårdnadshavare = GetVårdnadshavare();
            InitializeComponent();

            btnEdit.Hide();
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
            Back();
        }

        private void CmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbSelect.Text.ToLower();

            #region Label Startup
            label1.Text = "-----";
            label2.Text = "-----";
            label3.Text = "-----";
            label4.Text = "-----";
            label5.Text = "-----";
            label6.Text = "-----";
            #endregion

            if (select == "elever")
            {
                var elever = this.elever;
                dataGridView1.DataSource = elever;

                label1.Text = "Personnummer";
                label2.Text = "Namn";
                label3.Text = "Adress";
                label4.Text = "Epost";
                label5.Text = "Telefonnummer";
                label6.Text = "Klass";

            }

            if (select == "vårdnadshavare")
            {
                var vårdnadshavare = this.vårdnadshavare;
                dataGridView1.DataSource = vårdnadshavare;
                
                label1.Text = "Personnummer";
                label2.Text = "Namn";
                label3.Text = "Adress";
                label4.Text = "Epost";
                label5.Text = "Telefonnummer";
                label6.Text = "Elev Personnummer";

            }
        }

        void Back()
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string select = cmbSelect.Text.ToLower();

            if (select == "elever")
            {
                int txtbox1int = Int32.Parse(txtBox1.Text);
                int txtbox5int = Int32.Parse(txtBox5.Text);
                EleverModel elev = new EleverModel(txtbox1int, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtbox5int, txtBox6.Text);
                SqliteDataAccess.AddElev(elev);
            }
            else if (select == "vårdnadshavare")
            {
                int txtbox1int = Int32.Parse(txtBox1.Text);
                int txtbox5int = Int32.Parse(txtBox5.Text);
                int txtbox6int = Int32.Parse(txtBox6.Text);
                SqliteDataAccess.NewVårdnadshavare(txtbox1int, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtbox5int, txtbox6int);
            }
            Back();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        int initiallPersonnummer;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string select = cmbSelect.Text.ToLower();

            if(select == "elever")
            {
                try
                {
                    btnAdd.Hide();
                    btnEdit.Show();
                    var selectedElev = dataGridView1.SelectedRows[0].DataBoundItem as EleverModel;
                    initiallPersonnummer = selectedElev.GetPersonnummer();
                    txtBox1.Text = selectedElev.Elev_Personnummer.ToString();
                    txtBox2.Text = selectedElev.Namn;
                    txtBox3.Text = selectedElev.Adress;
                    txtBox4.Text = selectedElev.Epost;
                    txtBox5.Text = selectedElev.Telefonnummer.ToString();
                    txtBox6.Text = selectedElev.Klass_Namn;
                }
                catch
                {
                    MessageBox.Show("Some error occured: " + "Print only numbers in [Elev_Personnummer] and [Telefonnummer]");
                }
            }

            if( select== "vårdnadshavare")
            {
                try
                {
                    btnAdd.Hide();
                    btnEdit.Show();
                    var selectedVårdnadshavare = dataGridView1.SelectedRows[0].DataBoundItem as VårdnadshavareModel;
                    txtBox1.Text = selectedVårdnadshavare.Vårdnadshavare_Personnummer.ToString();
                    txtBox2.Text = selectedVårdnadshavare.Namn;
                    txtBox3.Text = selectedVårdnadshavare.Adress;
                    txtBox4.Text = selectedVårdnadshavare.Epost;
                    txtBox5.Text = selectedVårdnadshavare.Telefonnummer.ToString();
                }
                catch
                {
                    MessageBox.Show("Some error occured: " + "Print only numbers in [Elev_Personnummer] and [Telefonnummer]");
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int txtbox1int = Int32.Parse(txtBox1.Text);
            int txtbox5int = Int32.Parse(txtBox5.Text);
            SqliteDataAccess.EditElev(initiallPersonnummer, txtbox1int, txtBox2.Text, txtBox3.Text, txtBox4.Text, txtbox5int, txtBox6.Text);
            Back();
        }
    }      
}

