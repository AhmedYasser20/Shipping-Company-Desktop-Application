using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shipping_Company
{
    public partial class supervisor_view_avail_trucks : UserControl
    {
        int branchID;
        Controller controllerObj;
        public supervisor_view_avail_trucks(int brID)
        {
            branchID = brID;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void supervisor_view_avail_check_trucks_Click(object sender, EventArgs e)
        {

            supervisor_view_avail_trucks_datagrid.DataSource = controllerObj.ViewAvailDriverPS(branchID);

            if (supervisor_view_avail_trucks_datagrid.DataSource == null)
            {
                MessageBox.Show("All drivers have trips");
            }
            else
            {

                supervisor_view_avail_trucks_datagrid.Refresh();
            }
        }

        private void supervisor_view_avail_trucks_check_btn_Click(object sender, EventArgs e)
        {
            supervisor_view_avail_trucks_datagrid.DataSource = controllerObj.ViewAvailTrucksPS(branchID);

            if (supervisor_view_avail_trucks_datagrid.DataSource == null)
            {
                MessageBox.Show("All Trucks have trips");
            }
            else
            {

                supervisor_view_avail_trucks_datagrid.Refresh();
            }
        }
    }
}
