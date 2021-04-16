
namespace DatabasForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewBox = new System.Windows.Forms.ListView();
            this.chInfo = new System.Windows.Forms.ColumnHeader();
            this.chData = new System.Windows.Forms.ColumnHeader();
            this.lblOne = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(62, 43);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 29);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.cmbSelect.Location = new System.Drawing.Point(298, 41);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(138, 28);
            this.cmbSelect.TabIndex = 1;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 45);
            this.label1.MinimumSize = new System.Drawing.Size(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add";
            // 
            // lstViewBox
            // 
            this.lstViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chInfo,
            this.chData});
            this.lstViewBox.FullRowSelect = true;
            this.lstViewBox.GridLines = true;
            this.lstViewBox.HideSelection = false;
            this.lstViewBox.LabelEdit = true;
            this.lstViewBox.Location = new System.Drawing.Point(62, 121);
            this.lstViewBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstViewBox.Name = "lstViewBox";
            this.lstViewBox.Size = new System.Drawing.Size(859, 441);
            this.lstViewBox.TabIndex = 4;
            this.lstViewBox.UseCompatibleStateImageBehavior = false;
            this.lstViewBox.View = System.Windows.Forms.View.Details;
            this.lstViewBox.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstViewBox_ColumnWidthChanging);
            // 
            // chInfo
            // 
            this.chInfo.Text = "Info";
            this.chInfo.Width = 100;
            // 
            // chData
            // 
            this.chData.Text = "Data";
            this.chData.Width = 100;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(507, 49);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(45, 20);
            this.lblOne.TabIndex = 5;
            this.lblOne.Text = "------";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, -120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(744, 27);
            this.textBox1.TabIndex = 6;
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(558, 44);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(125, 27);
            this.txtOne.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1005, 611);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.lstViewBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.btnBack);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(18, 47);
            this.Name = "Form2";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewBox;
        private System.Windows.Forms.ColumnHeader chInfo;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtOne;
    }
}