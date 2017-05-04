using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace Projekt
{
    class Autocomplete
    {

        public ITransport transport = new Transport();
        public Connections connection = new Connections();

        public void autocomplete(ComboBox coBox, CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (coBox.Text.Count() > 3)
                {
                    var searchFrom = coBox.Text;
                    var stationsFrom = transport.GetStations(searchFrom + ",");
                    coBox.Items.Clear();

                    foreach (Station station in stationsFrom.StationList)
                    {
                        string sFrom = station.Name;
                        coBox.SelectionStart = coBox.Text.Length;
                        coBox.Items.Add(sFrom);
                        coBox.DroppedDown = true;
                    }
                }
            }
        }

        
    }
}
