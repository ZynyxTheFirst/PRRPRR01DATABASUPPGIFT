
namespace DatabasForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lstContainer = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "Elever",
            "Vårdnadshavare",
            "Kurser",
            "Lärare",
            "Klasser"});
            this.cmbSelect.Location = new System.Drawing.Point(119, 55);
            this.cmbSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(200, 28);
            this.cmbSelect.TabIndex = 0;
            this.cmbSelect.Tag = "cmbSelect";
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lstContainer
            // 
            this.lstContainer.FormattingEnabled = true;
            this.lstContainer.ItemHeight = 20;
            this.lstContainer.Items.AddRange(new object[] {
            "Please select element ",
            "in the dropdown ",
            "above."});
            this.lstContainer.Location = new System.Drawing.Point(119, 136);
            this.lstContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstContainer.Name = "lstContainer";
            this.lstContainer.Size = new System.Drawing.Size(200, 224);
            this.lstContainer.TabIndex = 1;
            this.lstContainer.Tag = "lstContainer";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(133, 425);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(683, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
           
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstContainer);
            this.Controls.Add(this.cmbSelect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.ListBox lstContainer;
        private System.Windows.Forms.Button btnAdd;
    }
}

