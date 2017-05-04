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
            this.checkAutocomplete = new System.Windows.Forms.CheckBox();
            this.linkCoordinates = new System.Windows.Forms.LinkLabel();
            this.btnCoBoxVerbindung = new System.Windows.Forms.Button();
            this.btnCoBoxComplete = new System.Windows.Forms.Button();
            this.coBox = new System.Windows.Forms.ComboBox();
            this.lvTimetable = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkAutocomplete);
            this.panel1.Controls.Add(this.linkCoordinates);
            this.panel1.Controls.Add(this.btnCoBoxVerbindung);
            this.panel1.Controls.Add(this.btnCoBoxComplete);
            this.panel1.Controls.Add(this.coBox);
            this.panel1.Controls.Add(this.lvTimetable);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 340);
            this.panel1.TabIndex = 1;
            // 
            // checkAutocomplete
            // 
            this.checkAutocomplete.AutoSize = true;
            this.checkAutocomplete.Location = new System.Drawing.Point(49, 79);
            this.checkAutocomplete.Name = "checkAutocomplete";
            this.checkAutocomplete.Size = new System.Drawing.Size(91, 17);
            this.checkAutocomplete.TabIndex = 5;
            this.checkAutocomplete.Text = "Autocomplete";
            this.checkAutocomplete.UseVisualStyleBackColor = true;
            // 
            // linkCoordinates
            // 
            this.linkCoordinates.AutoSize = true;
            this.linkCoordinates.Location = new System.Drawing.Point(46, 157);
            this.linkCoordinates.Name = "linkCoordinates";
            this.linkCoordinates.Size = new System.Drawing.Size(55, 13);
            this.linkCoordinates.TabIndex = 4;
            this.linkCoordinates.TabStop = true;
            this.linkCoordinates.Text = "linkLabel1";
            this.linkCoordinates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCoordinates_LinkClicked);
            // 
            // btnCoBoxVerbindung
            // 
            this.btnCoBoxVerbindung.Location = new System.Drawing.Point(49, 131);
            this.btnCoBoxVerbindung.Name = "btnCoBoxVerbindung";
            this.btnCoBoxVerbindung.Size = new System.Drawing.Size(121, 23);
            this.btnCoBoxVerbindung.TabIndex = 3;
            this.btnCoBoxVerbindung.Text = "Verbindungen";
            this.btnCoBoxVerbindung.UseVisualStyleBackColor = true;
            this.btnCoBoxVerbindung.Click += new System.EventHandler(this.btnCoBoxVerbindung_Click);
            // 
            // btnCoBoxComplete
            // 
            this.btnCoBoxComplete.Location = new System.Drawing.Point(49, 102);
            this.btnCoBoxComplete.Name = "btnCoBoxComplete";
            this.btnCoBoxComplete.Size = new System.Drawing.Size(121, 23);
            this.btnCoBoxComplete.TabIndex = 2;
            this.btnCoBoxComplete.Text = "Station Suchen";
            this.btnCoBoxComplete.UseVisualStyleBackColor = true;
            this.btnCoBoxComplete.Click += new System.EventHandler(this.btnCoBoxComplete_Click);
            // 
            // coBox
            // 
            this.coBox.FormattingEnabled = true;
            this.coBox.Location = new System.Drawing.Point(49, 51);
            this.coBox.Name = "coBox";
            this.coBox.Size = new System.Drawing.Size(121, 21);
            this.coBox.TabIndex = 1;
            this.coBox.TextUpdate += new System.EventHandler(this.coBox_TextUpdate);
            // 
            // lvTimetable
            // 
            this.lvTimetable.Location = new System.Drawing.Point(176, 51);
            this.lvTimetable.Name = "lvTimetable";
            this.lvTimetable.Size = new System.Drawing.Size(401, 249);
            this.lvTimetable.TabIndex = 0;
            this.lvTimetable.UseCompatibleStateImageBehavior = false;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Timetable";
            this.Size = new System.Drawing.Size(836, 343);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCoBoxComplete;
        private System.Windows.Forms.ComboBox coBox;
        private System.Windows.Forms.ListView lvTimetable;
        private System.Windows.Forms.Button btnCoBoxVerbindung;
        private System.Windows.Forms.LinkLabel linkCoordinates;
        private System.Windows.Forms.CheckBox checkAutocomplete;
    }
}
