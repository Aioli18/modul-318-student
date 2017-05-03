namespace Projekt
{
    partial class Form1
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
            this.eigStationAfg = new System.Windows.Forms.TextBox();
            this.eigStationEnd = new System.Windows.Forms.TextBox();
            this.btnStation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eigATafel = new System.Windows.Forms.TextBox();
            this.btnSrchATafel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // eigStationAfg
            // 
            this.eigStationAfg.Location = new System.Drawing.Point(12, 11);
            this.eigStationAfg.Name = "eigStationAfg";
            this.eigStationAfg.Size = new System.Drawing.Size(100, 20);
            this.eigStationAfg.TabIndex = 0;
            // 
            // eigStationEnd
            // 
            this.eigStationEnd.Location = new System.Drawing.Point(119, 12);
            this.eigStationEnd.Name = "eigStationEnd";
            this.eigStationEnd.Size = new System.Drawing.Size(100, 20);
            this.eigStationEnd.TabIndex = 1;
            // 
            // btnStation
            // 
            this.btnStation.Location = new System.Drawing.Point(225, 11);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(75, 23);
            this.btnStation.TabIndex = 2;
            this.btnStation.Text = "button1";
            this.btnStation.UseVisualStyleBackColor = true;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(422, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(555, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // eigATafel
            // 
            this.eigATafel.Location = new System.Drawing.Point(448, 11);
            this.eigATafel.Name = "eigATafel";
            this.eigATafel.Size = new System.Drawing.Size(100, 20);
            this.eigATafel.TabIndex = 5;
            // 
            // btnSrchATafel
            // 
            this.btnSrchATafel.Location = new System.Drawing.Point(555, 11);
            this.btnSrchATafel.Name = "btnSrchATafel";
            this.btnSrchATafel.Size = new System.Drawing.Size(75, 23);
            this.btnSrchATafel.TabIndex = 6;
            this.btnSrchATafel.Text = "Suche";
            this.btnSrchATafel.UseVisualStyleBackColor = true;
            this.btnSrchATafel.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 203);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(306, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 393);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSrchATafel);
            this.Controls.Add(this.eigATafel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStation);
            this.Controls.Add(this.eigStationEnd);
            this.Controls.Add(this.eigStationAfg);
            this.Name = "Form1";
            this.Text = "ProjektÖV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eigStationAfg;
        private System.Windows.Forms.TextBox eigStationEnd;
        private System.Windows.Forms.Button btnStation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox eigATafel;
        private System.Windows.Forms.Button btnSrchATafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

