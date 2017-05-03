namespace Projekt
{
    partial class Timetable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.coBox = new System.Windows.Forms.ComboBox();
            this.btnCoBox = new System.Windows.Forms.Button();
            this.btnSucheVerb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSucheVerb);
            this.panel1.Controls.Add(this.btnCoBox);
            this.panel1.Controls.Add(this.coBox);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 340);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(307, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(401, 249);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // coBox
            // 
            this.coBox.FormattingEnabled = true;
            this.coBox.Location = new System.Drawing.Point(95, 51);
            this.coBox.Name = "coBox";
            this.coBox.Size = new System.Drawing.Size(121, 21);
            this.coBox.TabIndex = 1;
            // 
            // btnCoBox
            // 
            this.btnCoBox.Location = new System.Drawing.Point(95, 78);
            this.btnCoBox.Name = "btnCoBox";
            this.btnCoBox.Size = new System.Drawing.Size(75, 23);
            this.btnCoBox.TabIndex = 2;
            this.btnCoBox.Text = "button1";
            this.btnCoBox.UseVisualStyleBackColor = true;
            this.btnCoBox.Click += new System.EventHandler(this.btnCoBox_Click);
            // 
            // btnSucheVerb
            // 
            this.btnSucheVerb.Location = new System.Drawing.Point(95, 170);
            this.btnSucheVerb.Name = "btnSucheVerb";
            this.btnSucheVerb.Size = new System.Drawing.Size(75, 23);
            this.btnSucheVerb.TabIndex = 3;
            this.btnSucheVerb.Text = "button1";
            this.btnSucheVerb.UseVisualStyleBackColor = true;
            this.btnSucheVerb.Click += new System.EventHandler(this.btnSucheVerb_Click);
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Timetable";
            this.Size = new System.Drawing.Size(836, 343);
            this.Load += new System.EventHandler(this.Timetable_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCoBox;
        private System.Windows.Forms.ComboBox coBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSucheVerb;
    }
}
