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
    public partial class supervisor_assign_product : UserControl
    {
        Controller controllerObj;
        int branch;
        public supervisor_assign_product(int branch1)
        {
            branch = branch1;
            InitializeComponent();
            controllerObj = new Controller();
        
        }

        private void supervisor_update_price_new_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_assign_products_view_product_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewBranchProduct(branch);
            supervisor_assign_products_datagrid.DataSource = dt;
            supervisor_assign_products_datagrid.Refresh();
        }

        private void supervisor_assign_products_assign_truck_btn_Click(object sender, EventArgs e)
        {
            if (supervisor_update_price_new_price.Text.Length != 0)
            {
                int TruckID = Convert.ToInt32(supervisor_update_price_new_price.Text);
                object cap = controllerObj.getCapacity(TruckID);
                cap = Convert.ToInt32(cap);
                if (cap != null)
                {
                    int result = 0;
                    object brannch = controllerObj.getBranchIDForTruck(TruckID.ToString());
                    int branchIDINT= Convert.ToInt32(brannch);
                    if (branchIDINT == branch)
                    {
                        object trucktype=controllerObj.GetTruckTypeByID(TruckID.ToString());

                        result = controllerObj.AssignProduct(TruckID.ToString(), cap.ToString(), trucktype.ToString(),branchIDINT.ToString());
                    }
                    else
                    {
                        result = 0;
                    }
                    if (result != 0)
                    {
                        supervisor_assign_products_assign_truck_error_label.Visible = false;
                        supervisor_assign_products_assign_truck_successful_label.Visible = true;
                    }
                    else
                    {
                        supervisor_assign_products_assign_truck_error_label.Visible = true;
                        supervisor_assign_products_assign_truck_successful_label.Visible = false;
                    }
                }
                else
                {
                    supervisor_assign_products_assign_truck_error_label.Visible = true;
                    supervisor_assign_products_assign_truck_successful_label.Visible = false;
                }
            }
            else
            {
                supervisor_assign_products_assign_truck_error_label.Visible = true;
                supervisor_assign_products_assign_truck_successful_label.Visible = false;
            }
           
        }
    }
}
