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
            this.btnCoBoxComplete = new System.Windows.Forms.Button();
            this.pannelVerbindungen = new System.Windows.Forms.Panel();
            this.checkAutocomplete = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lvVerbindung = new System.Windows.Forms.ListView();
            this.coBoxTo = new System.Windows.Forms.ComboBox();
            this.coBoxFrom = new System.Windows.Forms.ComboBox();
            this.btnCoBoxVerbindung = new System.Windows.Forms.Button();
            this.pannelVerbindungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCoBoxComplete
            // 
            this.btnCoBoxComplete.Location = new System.Drawing.Point(38, 116);
            this.btnCoBoxComplete.Name = "btnCoBoxComplete";
            this.btnCoBoxComplete.Size = new System.Drawing.Size(140, 23);
            this.btnCoBoxComplete.TabIndex = 0;
            this.btnCoBoxComplete.Text = "Station Suchen";
            this.btnCoBoxComplete.UseVisualStyleBackColor = true;
            this.btnCoBoxComplete.Click += new System.EventHandler(this.btnCoBoxComplete_Click);
            // 
            // pannelVerbindungen
            // 
            this.pannelVerbindungen.Controls.Add(this.checkAutocomplete);
            this.pannelVerbindungen.Controls.Add(this.dateTimePicker1);
            this.pannelVerbindungen.Controls.Add(this.lvVerbindung);
            this.pannelVerbindungen.Controls.Add(this.coBoxTo);
            this.pannelVerbindungen.Controls.Add(this.coBoxFrom);
            this.pannelVerbindungen.Controls.Add(this.btnCoBoxVerbindung);
            this.pannelVerbindungen.Controls.Add(this.btnCoBoxComplete);
            this.pannelVerbindungen.Location = new System.Drawing.Point(0, 0);
            this.pannelVerbindungen.Name = "pannelVerbindungen";
            this.pannelVerbindungen.Size = new System.Drawing.Size(836, 340);
            this.pannelVerbindungen.TabIndex = 1;
            // 
            // checkAutocomplete
            // 
            this.checkAutocomplete.AutoSize = true;
            this.checkAutocomplete.Location = new System.Drawing.Point(38, 93);
            this.checkAutocomplete.Name = "checkAutocomplete";
            this.checkAutocomplete.Size = new System.Drawing.Size(91, 17);
            this.checkAutocomplete.TabIndex = 6;
            this.checkAutocomplete.Text = "Autocomplete";
            this.checkAutocomplete.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lvVerbindung
            // 
            this.lvVerbindung.Location = new System.Drawing.Point(184, 38);
            this.lvVerbindung.Name = "lvVerbindung";
            this.lvVerbindung.Size = new System.Drawing.Size(423, 182);
            this.lvVerbindung.TabIndex = 4;
            this.lvVerbindung.UseCompatibleStateImageBehavior = false;
            // 
            // coBoxTo
            // 
            this.coBoxTo.FormattingEnabled = true;
            this.coBoxTo.Location = new System.Drawing.Point(38, 65);
            this.coBoxTo.Name = "coBoxTo";
            this.coBoxTo.Size = new System.Drawing.Size(140, 21);
            this.coBoxTo.TabIndex = 2;
            this.coBoxTo.TextUpdate += new System.EventHandler(this.coBoxTo_TextUpdate);
            // 
            // coBoxFrom
            // 
            this.coBoxFrom.FormattingEnabled = true;
            this.coBoxFrom.Location = new System.Drawing.Point(38, 38);
            this.coBoxFrom.Name = "coBoxFrom";
            this.coBoxFrom.Size = new System.Drawing.Size(140, 21);
            this.coBoxFrom.TabIndex = 1;
            this.coBoxFrom.TextUpdate += new System.EventHandler(this.coBoxFrom_TextUpdate);
            // 
            // btnCoBoxVerbindung
            // 
            this.btnCoBoxVerbindung.Location = new System.Drawing.Point(38, 171);
            this.btnCoBoxVerbindung.Name = "btnCoBoxVerbindung";
            this.btnCoBoxVerbindung.Size = new System.Drawing.Size(140, 23);
            this.btnCoBoxVerbindung.TabIndex = 3;
            this.btnCoBoxVerbindung.Text = "Verbindungen Suchen";
            this.btnCoBoxVerbindung.UseVisualStyleBackColor = true;
            this.btnCoBoxVerbindung.Click += new System.EventHandler(this.btnCoBoxVerbindung_Click);
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pannelVerbindungen);
            this.Name = "Verbindungen";
            this.Size = new System.Drawing.Size(836, 343);
            this.pannelVerbindungen.ResumeLayout(false);
            this.pannelVerbindungen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoBoxComplete;
        private System.Windows.Forms.Panel pannelVerbindungen;
        private System.Windows.Forms.Button btnCoBoxVerbindung;
        private System.Windows.Forms.ComboBox coBoxTo;
        private System.Windows.Forms.ComboBox coBoxFrom;
        private System.Windows.Forms.ListView lvVerbindung;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkAutocomplete;

    }
}
