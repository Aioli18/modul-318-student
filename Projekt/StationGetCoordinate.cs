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
    class StationGetCoordinate
    {
        public ITransport testee;

        public void stationGetCoordinates(ComboBox coBox)
        {
            testee = new Transport();
            try
            {
                Stations stations = testee.GetStations(coBox.Text);

                if (stations.StationList.Count > 0)
                {
                    Station station = stations.StationList[0];
                    string x;
                    string y;
                    x = Convert.ToString(station.Coordinate.XCoordinate);
                    y = Convert.ToString(station.Coordinate.YCoordinate);

                    x = x.Replace(',', '.');
                    y = y.Replace(',', '.');
                    System.Diagnostics.Process.Start("https://www.google.ch/maps/search/" + x + "+" + y);
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine Station ein.");
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Zu viele Webanfragen");
            }
        }
    }
}
