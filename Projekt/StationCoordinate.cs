using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace Projekt
{
    class StationCoordinate
    {

        public ITransport testee;

        public void stationCoordinates(ComboBox coBox)
        {
            testee = new Transport();
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
    }
}
