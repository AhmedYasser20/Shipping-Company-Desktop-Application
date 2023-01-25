using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shipping_Company
{
    public partial class supervisor_create_trip : UserControl
    {
        Controller ControllerObj;
        public supervisor_create_trip()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void supervisor_create_trip_driver_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_create_trip_truck_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_create_trip_num_products_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_create_trip_start_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to Time Format only
            if (e.KeyChar == ':')
            {
                if (this.Text.IndexOf(":") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = false;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_create_trip_end_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to Time Format only
            if (e.KeyChar == ':')
            {
                if (this.Text.IndexOf(":") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = false;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_create_trip_start_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to Date Format only
            if (e.KeyChar == '-')
            {
                if (this.Text.IndexOf("-") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = false;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_create_trip_end_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to Date Format only
            if (e.KeyChar == '-')
            {
                if (this.Text.IndexOf("-") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = false;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_create_trip_btn_Click(object sender, EventArgs e)
        {
       
            
            if (supervisor_create_trip_driver_ssn.Text.Length!=0 && supervisor_create_trip_truck_id.Text.Length != 0 && TripIDText.Text.Length!=0)
            {
                //object DBranchID = ControllerObj.GetDriverSSN(supervisor_create_trip_driver_ssn.Text);
                object DBranchID = ControllerObj.getBranchIdByDriverSSN(supervisor_create_trip_driver_ssn.Text);
                int DriverBranchID=Convert.ToInt32(DBranchID);
                object TBranchID = ControllerObj.GetBranchOFTruck(supervisor_create_trip_truck_id.Text);
                int TruckBranchID=Convert.ToInt32(TBranchID);
                object EndBranchID = ControllerObj.GetEndBranchOFTruck(supervisor_create_trip_truck_id.Text);
                int EBranchID=Convert.ToInt32(EndBranchID);
                object ACapacity = ControllerObj.GetCountOfProductINTruck(supervisor_create_trip_driver_ssn.Text);
                int RC=Convert.ToInt32(ACapacity);
                
                if (TruckBranchID == DriverBranchID)
                {
                    
                    int reuslt = ControllerObj.CreateTrip(supervisor_create_trip_driver_ssn.Text, TruckBranchID.ToString(), EBranchID.ToString(), TripIDText.Text, RC.ToString(), supervisor_create_trip_truck_id.Text, StartDate.Text, StartTime.Text, EndDate.Text, EndTime.Text);
                    ControllerObj.AssignTruckToTrip(TripIDText.Text, supervisor_create_trip_truck_id.Text);
                    ControllerObj.AssignDriverToTrip(TripIDText.Text, supervisor_create_trip_driver_ssn.Text);
                    if (reuslt != 0)
                    {
                        supervisor_create_trip_unsuccessful_label.Visible = false;
                        supervisor_create_trip_successful_label.Visible = true;
                    }
                    else
                    {
                        supervisor_create_trip_unsuccessful_label.Visible = true;
                        supervisor_create_trip_successful_label.Visible = false;
                    }
                }
                else
                {
                    supervisor_create_trip_unsuccessful_label.Visible = true;
                    supervisor_create_trip_successful_label.Visible = false;
                }
            }
            else
            {
                supervisor_create_trip_unsuccessful_label.Visible = true;
                supervisor_create_trip_successful_label.Visible = false;
            }
        }
    }
}