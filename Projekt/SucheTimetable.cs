using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;
using System.Net;

namespace Projekt
{
    class SucheTimetable
    {
        public ITransport SwissTrans;


        public void TimeTableSucheVerbindung(ComboBox coBox, ListView lv)
        {
            lv.Items.Clear();

            SwissTrans = new Transport();
            try
            {
                Stations stations = SwissTrans.GetStations(coBox.Text);

                if (stations.StationList.Count > 0)
                {
                    Station station = stations.StationList[0];
                    String id = station.Id;
                    StationBoardRoot timetable = SwissTrans.GetStationBoard(coBox.Text, id);
                    foreach (StationBoard entries in timetable.Entries)
                    {
                        TimeSpan tod = entries.Stop.Departure.TimeOfDay;
                        string depastr = tod.ToString();
                        string depa = depastr.Remove(5, 3);
                        var item = new ListViewItem(new[] { depa, entries.Name, entries.To });
                        lv.Items.Add(item);
                        coBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Geben Sie Bitte im Suchfeld eine Station ein");
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Zu viele Webanfragen");
            }
        }
        
        public void TimeTableSucheComplete(ComboBox coBox)
        {
            coBox.Items.Clear();
            try
            {
                SwissTrans = new Transport();
                var station = SwissTrans.GetStations(coBox.Text);

                if (station.StationList.Count > 0)
                {
                    for (int i = 0; i < station.StationList.Count; i++)
                    {
                        Station res = station.StationList[i];
                        coBox.Items.Add(res.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Geben Sie Bitte im Suchfeld eine Station ein");
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Zu viele Webanfragen");
            }
        }
    }
}
