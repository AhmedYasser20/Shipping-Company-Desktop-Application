using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace Shipping_Company
{
    public partial class supervisor_truck_arrived : UserControl
    {
        Controller controllerObj;
        int branch;
        public supervisor_truck_arrived(int br)
        {
            branch= br;
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void supervisor_truck_arrived_truck_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_truck_arrived_truck_arrived_btn_Click(object sender, EventArgs e)
        {
            if(supervisor_truck_arrived_truck_id.Text.Length!=0)
            {
                int result = 0;
                object EndBranchID = controllerObj.GetEndBranchOFTruck(supervisor_truck_arrived_truck_id.Text);
                int EBranchID = Convert.ToInt32(EndBranchID);
                if (EBranchID == branch)
                {
                    supervisor_assign_products_datagrid.DataSource = controllerObj.ShowArrivedProducts(supervisor_truck_arrived_truck_id.Text);
                    supervisor_assign_products_datagrid.Refresh();
                    controllerObj.DeleteTrip(supervisor_truck_arrived_truck_id.Text);
                    result += controllerObj.ArrivedTruckChangeProduct(supervisor_truck_arrived_truck_id.Text);
                   
                    MessageBox.Show(branch.ToString());
                    result += controllerObj.ArrivedTruckChangeBranchID(supervisor_truck_arrived_truck_id.Text, EBranchID.ToString());
                    if (result == 2)
                    {
                        supervisor_truck_arrived_successful_label.Visible = true;

                    }
                }
            }
        }

        private void supervisor_truck_arrived_successful_label_Click(object sender, EventArgs e)
        {

        }
    }
}
