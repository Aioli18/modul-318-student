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

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Zeit", 70);
            listView1.Columns.Add("Von", 120);
            listView1.Columns.Add("Nach", 120);
            listView1.Columns.Add("Dauer", 70);
        }

        private ITransport testee;

        private void btnComplete_Click(object sender, EventArgs e)
        {
            testee = new Transport();
            
            while (coBoxStart.Items.Count > 0)
            {
                coBoxStart.Items.RemoveAt(0);

            }

            var station = testee.GetStations(coBoxStart.Text);

            for (int i = 0; i < station.StationList.Count; i++)
            {
                Station res = station.StationList[i];
                coBoxStart.Items.Add(res.Name);
            }

            while (coBoxEnd.Items.Count > 0)
            {
                coBoxEnd.Items.RemoveAt(0);
            }

            var stationEnd = testee.GetStations(coBoxEnd.Text);

            for (int i = 0; i < stationEnd.StationList.Count; i++)
            {
                Station resEnd = stationEnd.StationList[i];
                coBoxEnd.Items.Add(resEnd.Name);
            }
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            testee = new Transport();

            while(listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(0);
            }

            var connections = testee.GetConnections(coBoxStart.Text, coBoxEnd.Text);

            for (int i = 0; i < connections.ConnectionList.Count; i++)
            {
                Connection res = connections.ConnectionList[i];
                ConnectionPoint from = res.From;
                ConnectionPoint to = res.To;

                
                var depa = DateTime.Parse(res.From.Departure).TimeOfDay;

                var arri = DateTime.Parse(res.To.Arrival);
                string depastrPre = depa.ToString();
                string depastr = depastrPre.Remove(5, 3);

                string removed = res.Duration.Remove(0, 3);
                var durr = TimeSpan.Parse(removed);
                var durrstr = durr.ToString();


                

                string[] arr = new string[4];
                ListViewItem itm;

                arr[0] = depastr + " Uhr";
                arr[1] = from.Station.Name;
                arr[2] = to.Station.Name;
                arr[3] = durrstr + "";

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            }
        }
    }
}
