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
    public partial class Timetable : UserControl
    {
        public Timetable()
        {
            InitializeComponent();

            lvTimetable.View = View.Details;
            lvTimetable.GridLines = true;
            lvTimetable.FullRowSelect = true;
            lvTimetable.Columns.Add("Zeit", 100);
            lvTimetable.Columns.Add("Mit", 100);
            lvTimetable.Columns.Add("Nach", 170);
        }

        private void btnCoBoxComplete_Click(object sender, EventArgs e)
        {
            SucheTimetable SucheTimetable = new SucheTimetable();
            SucheTimetable.TTSucheComplete(coBox);
        }

        private void btnCoBoxVerbindung_Click(object sender, EventArgs e)
        {
            SucheTimetable SucheTimetable = new SucheTimetable();
            SucheTimetable.TTSucheVerbindung(coBox, lvTimetable);
        }

        private void coBox_TextUpdate(object sender, EventArgs e)
        {
            Autocomplete Autocomplete = new Autocomplete();
            Autocomplete.autocomplete(coBox, checkAutocomplete);
        }

        private void linkCoordinates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StationCoordinate StationCoordinate = new StationCoordinate();
            StationCoordinate.stationCoordinates(coBox);
        }
    }
}

