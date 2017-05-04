using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Projekt
{
    public partial class Verbindungen : UserControl
    {
        public Verbindungen()
        {
            InitializeComponent();

            lvVerbindung.View = View.Details;
            lvVerbindung.GridLines = true;
            lvVerbindung.FullRowSelect = true;
            lvVerbindung.Columns.Add("Zeit", 70);
            lvVerbindung.Columns.Add("Von", 120);
            lvVerbindung.Columns.Add("Nach", 120);
            lvVerbindung.Columns.Add("Dauer", 70);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy | HH:mm";
        }

        private void coBoxFrom_TextUpdate(object sender, EventArgs e)
        {
            Autocomplete Autocomplete = new Autocomplete();
            Autocomplete.autocomplete(coBoxFrom, checkAutocomplete);
        }

        private void coBoxTo_TextUpdate(object sender, EventArgs e)
        {
            Autocomplete Autocomplete = new Autocomplete();
            Autocomplete.autocomplete(coBoxTo, checkAutocomplete);
        }

        private void btnCoBoxComplete_Click(object sender, EventArgs e)
        {
            SucheVerbindungen VerbSucheStation = new SucheVerbindungen();
            VerbSucheStation.SucheComplete(coBoxFrom, coBoxTo);
        }

        private void btnCoBoxVerbindung_Click(object sender, EventArgs e)
        {
            SucheVerbindungen VerbSucheStation = new SucheVerbindungen();
            VerbSucheStation.SucheStation(coBoxFrom, coBoxTo, lvVerbindung, dateTimePicker1);
        }


    }
}
