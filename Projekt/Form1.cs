using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Globalization;



namespace Projekt
{

    public partial class Form1 : Form
    {
        private ITransport testee;
        public Form1()
        {
            InitializeComponent();


        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            testee = new Transport();
            var connections = testee.GetConnections(eigStationAfg.Text, eigStationEnd.Text);

            for (int i = 0; i < connections.ConnectionList.Count; i++)
            {
                Connection res = connections.ConnectionList[i];
                ConnectionPoint from = res.From;
                ConnectionPoint to = res.To;

                var depa = DateTime.Parse(res.From.Departure).TimeOfDay;
                var arri = DateTime.Parse(res.To.Arrival);


                string removed = res.Duration.Remove(0, 3);
                var durr = TimeSpan.Parse(removed).Minutes;


                string depastrPre = depa.ToString();
                string depastr = depastrPre.Remove(5, 3);

                var durrstr = durr.ToString();



                MessageBox.Show("From: " + from.Station.Name + "\n" +
                    "Abfahrt :" + depa + "\n" +
                    "to: " + res.To.Arrival + "\n" +
                    "Ankunft: " + arri + "\n" +
                    "Length: " + durr);
                this.dataGridView1.Rows.Add(arri, "six", "seven", "eight");

                ///////////////////////////////////////////////////////////////////////////
                string[] arr = new string[4];
                ListViewItem itm;

                arr[0] = depastr + " Uhr";
                arr[1] = from.Station.Name;
                arr[2] = to.Station.Name;
                arr[3] = durrstr + ":00";
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Zeit", 70);
            listView1.Columns.Add("Von", 70);
            listView1.Columns.Add("Nach", 70);
            listView1.Columns.Add("Dauer", 70);


        }
    }
}
