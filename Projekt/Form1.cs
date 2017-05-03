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
        Verbindungen verbindungen = new Verbindungen();

        Timetable timetable = new Timetable();

        public Form1()
        {
            InitializeComponent();
            panelUserControll.Controls.Add(timetable);

        }

        private void timetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUserControll.Controls.Clear();
            panelUserControll.Controls.Add(timetable);
        }

        private void verbindungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUserControll.Controls.Clear();
            panelUserControll.Controls.Add(verbindungen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }













    }
}
