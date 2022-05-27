using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            var locations = new List<Location>() { new North(), new South() };

            foreach (var location in locations)
            {
                cmbGetDataLocation.Items.Add(location);

                foreach (var office in location.Offices)
                {
                    cmbGetDataOffice.Items.Add(office);
                }
            }
        }

        private void cmbGetDataLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var locations = new List<Location>() { new North(), new South() };                                 
            cmbGetDataOffice.Items.Clear();
            foreach (var location in locations)
            {
                if (cmbGetDataLocation.Text == location.ToString()) { 
                    foreach (var office in location.Offices)
                    {
                        
                        cmbGetDataOffice.Items.Add(office);
                    }
                }
            }
        }
    }
}
