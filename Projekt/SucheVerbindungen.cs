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
    class SucheVerbindungen
    {
        public ITransport SwissTrans;

        public void SucheComplete(ComboBox coBoxFrom, ComboBox coBoxTo)
        {
            SwissTrans = new Transport();
            try
            {
                var station = SwissTrans.GetStations(coBoxFrom.Text);

                if (station.StationList.Count <= 0)
                {
                    MessageBox.Show("Geben Sie Bitte im Suchfeld eine Station ein");
                }
                else
                {
                    for (int i = 0; i < station.StationList.Count; i++)
                    {
                        Station res = station.StationList[i];
                        coBoxFrom.Items.Add(res.Name);
                    }

                    coBoxTo.Items.Clear();


                    var stationEnd = SwissTrans.GetStations(coBoxTo.Text);


                    for (int i = 0; i < stationEnd.StationList.Count; i++)
                    {
                        Station resEnd = stationEnd.StationList[i];
                        coBoxTo.Items.Add(resEnd.Name);
                    }
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Zu viele Webanfragen");
            }
        }

        public void SucheStation(ComboBox coBoxFrom, ComboBox coBoxTo, ListView lv, DateTimePicker DTP)
        {
            SwissTrans = new Transport();
            try
            {
                coBoxFrom.Items.Clear();
                lv.Items.Clear();

                string Time = DTP.Text;
                var date = DateTime.Parse(Time.Substring(0, 10));
                String rightDate = date.ToString("yyyy-MM-dd");
                String time = Time.Substring(12, 6);
                var connections = SwissTrans.GetConnections(coBoxFrom.Text, coBoxTo.Text, rightDate, time);

                if (connections.ConnectionList.Count <= 0)
                {
                    MessageBox.Show("Geben Sie Bitte im Suchfeld eine Station ein");
                }
                else
                {
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
                        lv.Items.Add(itm);

                        coBoxFrom.Focus();
                    }
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Zu viele Webanfragen");
            }
        }
    }
}
