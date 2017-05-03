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

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Zeit", 100);
            listView1.Columns.Add("Mit", 100);
            listView1.Columns.Add("Nach", 170);
        }

        private ITransport testee;

        private void Timetable_Load(object sender, EventArgs e)
        {

        }

        private void btnCoBox_Click(object sender, EventArgs e)
        {
            testee = new Transport();

            while (coBox.Items.Count > 0)
            {
                coBox.Items.RemoveAt(0);

            }

            var station = testee.GetStations(coBox.Text);

            for (int i = 0; i < station.StationList.Count; i++)
            {
                Station res = station.StationList[i];
                coBox.Items.Add(res.Name);
            }
        }

        private void btnSucheVerb_Click(object sender, EventArgs e)
        { 
            while (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(0);
            }

            testee = new Transport();

            Stations stations = testee.GetStations(coBox.Text);
            Station station = stations.StationList[0];
            String id = station.Id;

            StationBoardRoot timetable = testee.GetStationBoard(coBox.Text, id);

            foreach(StationBoard entries in timetable.Entries)
            {
                TimeSpan tod = entries.Stop.Departure.TimeOfDay;                            
                string depastr = tod.ToString();
                string depa = depastr.Remove(5,3);
                var item = new ListViewItem(new[] { depa, entries.Name, entries.To });
                listView1.Items.Add(item);
            }
        }
    }
}
