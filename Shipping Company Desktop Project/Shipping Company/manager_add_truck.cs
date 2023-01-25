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
    public partial class manager_add_truck : UserControl
    {
        Controller controllerObj;
        int RPassword;
        public manager_add_truck()
        {
            InitializeComponent();
            controllerObj = new Controller();
            RPassword = 15212515;
        }

        private void manager_add_truck_branch_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void manager_add_truck_truck_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void manager_add_truck_btn_Click(object sender, EventArgs e)
        {
            
            if (manager_add_truck_branch_id.Text.Length!= 0 && manager_add_truck_truck_type.Text.Length!=0) {
                if (manager_add_truck_truck_type.Text == "Normal")
                {
                    int result = controllerObj.AddTruck(manager_add_truck_branch_id.Text, manager_add_truck_truck_type.Text, "20", "100");
                    if (result != 0)
                    {
                        manager_add_truck_successful_label.Visible = true;
                        manager_add_truck_error_label.Visible = false;
                    }
                    else
                    {
                        manager_add_truck_successful_label.Visible = false;
                        manager_add_truck_error_label.Visible = true;
                    }
                }
                else if(manager_add_truck_truck_type.Text == "Special")
                {
                    int result = controllerObj.AddTruck(manager_add_truck_branch_id.Text, manager_add_truck_truck_type.Text, "15", "120");
                    if (result != 0)
                    {
                        manager_add_truck_successful_label.Visible = true;
                        manager_add_truck_error_label.Visible = false;
                    }
                    else
                    {
                        manager_add_truck_successful_label.Visible = false;
                        manager_add_truck_error_label.Visible = true;
                    }
                }
                else if (manager_add_truck_truck_type.Text == "VIP")
                {
                    int result = controllerObj.AddTruck(manager_add_truck_branch_id.Text, manager_add_truck_truck_type.Text, "10", "140");
                    if (result != 0)
                    {
                        manager_add_truck_successful_label.Visible = true;
                        manager_add_truck_error_label.Visible = false;
                    }
                    else
                    {
                        manager_add_truck_successful_label.Visible = false;
                        manager_add_truck_error_label.Visible = true;
                    }
                }
                else
                {
                    manager_add_truck_successful_label.Visible = false;
                    manager_add_truck_error_label.Visible = true;
                }
            }
            else
            {
                manager_add_truck_successful_label.Visible = false;
                manager_add_truck_error_label.Visible = true;
            }
        }

        private void manager_remove_truck_btn_Click(object sender, EventArgs e)
        {
            if (manager_add_truck_truck_id.Text.Length != 0)
            {
                int result = controllerObj.DeleteTruckByID(manager_add_truck_truck_id.Text);
                if (result != 0)
                {
                    manager_add_truck_remove_successful_label.Visible = true;
                    manager_add_truck_remove_error_label.Visible = false;
                }
                else
                {
                    manager_add_truck_remove_successful_label.Visible = false;
                    manager_add_truck_remove_error_label.Visible = true;
                }
            }
            else
            {
                manager_add_truck_remove_successful_label.Visible= false;
                manager_add_truck_remove_error_label.Visible = true;

            }
        }
    }      
}
