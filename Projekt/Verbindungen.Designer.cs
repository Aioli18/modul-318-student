namespace Projekt
{
    partial class Verbindungen
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
            this.btnComplete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.coBoxEnd = new System.Windows.Forms.ComboBox();
            this.coBoxStart = new System.Windows.Forms.ComboBox();
            this.btnStation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(38, 35);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 0;
            this.btnComplete.Text = "verbindung";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.coBoxEnd);
            this.panel1.Controls.Add(this.coBoxStart);
            this.panel1.Controls.Add(this.btnStation);
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 343);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(38, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 168);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // coBoxEnd
            // 
            this.coBoxEnd.FormattingEnabled = true;
            this.coBoxEnd.Location = new System.Drawing.Point(165, 65);
            this.coBoxEnd.Name = "coBoxEnd";
            this.coBoxEnd.Size = new System.Drawing.Size(121, 21);
            this.coBoxEnd.TabIndex = 3;
            // 
            // coBoxStart
            // 
            this.coBoxStart.FormattingEnabled = true;
            this.coBoxStart.Location = new System.Drawing.Point(38, 65);
            this.coBoxStart.Name = "coBoxStart";
            this.coBoxStart.Size = new System.Drawing.Size(121, 21);
            this.coBoxStart.TabIndex = 2;
            // 
            // btnStation
            // 
            this.btnStation.Location = new System.Drawing.Point(206, 34);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(75, 23);
            this.btnStation.TabIndex = 1;
            this.btnStation.Text = "button2";
            this.btnStation.UseVisualStyleBackColor = true;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Verbindungen";
            this.Size = new System.Drawing.Size(836, 343);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStation;
        private System.Windows.Forms.ComboBox coBoxEnd;
        private System.Windows.Forms.ComboBox coBoxStart;
        private System.Windows.Forms.ListView listView1;

    }
}
