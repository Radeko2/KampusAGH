using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itinero;
using Itinero.IO.Osm;
using Itinero.Osm.Vehicles;

namespace KampusAGH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // load some routing data and build a routing network.
            var routerDb = new RouterDb();
            using (var stream = new FileInfo(@"malopolskie-latest.osm.pbf").OpenRead())
            {
                // create the network for cars only.
                routerDb.LoadOsmData(stream, Vehicle.Car);
            }

            // write the routerdb to disk.
            using (var stream = new FileInfo(@"malopolskie-latest.osm.pbf").Open(FileMode.Create))
            {
                routerDb.Serialize(stream);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
