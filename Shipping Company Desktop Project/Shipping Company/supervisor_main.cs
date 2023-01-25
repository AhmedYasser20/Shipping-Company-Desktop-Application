using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Shipping_Company
{
    public partial class supervisor_main : KryptonForm
    {
        string name;
        int branchid;
        int superssn;
    
        public supervisor_main(string fname, int branch, int ssn)
        {
            branchid = branch;
            superssn = ssn;
            InitializeComponent();
            name = fname;
            
            

            supervisor_main_name_label.Text = name;
            supervisor_main_branchid_label.Text = branchid.ToString();
            
        }

        private void employee_signout_btn_Click(object sender, EventArgs e)
        {
            login_page lp = new login_page();
            lp.Show();
            this.Close();
        }

        private void supervisor_update_price_btn_Click(object sender, EventArgs e)
        {
            this.supervisor_update_price1.Visible = true;
            this.supervisor_hire_driver1.Visible = false;
            this.supervisor_hire_employee1.Visible = false;
           
            this.supervisor_create_trip1.Visible = false;
            this.supervisor_view_avail_trucks1.Visible = false;
            this.supervisor_assign_product1.Visible = false;
            this.supervisor_truck_arrived1.Visible = false;

        }

        private void supervisor_hire_driver_btn_Click(object sender, EventArgs e)
        {
            this.supervisor_update_price1.Visible = false;
            this.supervisor_hire_driver1.Visible = true;
            this.supervisor_hire_employee1.Visible = false;
            
            this.supervisor_create_trip1.Visible = false;
            this.supervisor_view_avail_trucks1.Visible = false;
            this.supervisor_assign_product1.Visible = false;
            this.supervisor_truck_arrived1.Visible = false;

        }

        private void supervisor_hire_employee_btn_Click(object sender, EventArgs e)
        {
            this.supervisor_update_price1.Visible = false;
            this.supervisor_hire_driver1.Visible = false;
            this.supervisor_hire_employee1.Visible = true;
         
            this.supervisor_create_trip1.Visible = false;
            this.supervisor_view_avail_trucks1.Visible = false;
            this.supervisor_assign_product1.Visible = false;
            this.supervisor_truck_arrived1.Visible = false;


        }

        private void supervisor_update_bill_btn_Click(object sender, EventArgs e)
        {
            this.supervisor_update_price1.Visible = false;
            this.supervisor_hire_driver1.Visible = false;
            this.supervisor_hire_employee1.Visible = false;
           
            this.supervisor_create_trip1.Visible = false;
            this.supervisor_view_avail_trucks1.Visible = false;
            this.supervisor_assign_product1.Visible = false;
            this.supervisor_truck_arrived1.Visible = false;

        }

        private void supervisor_view_avail_trucks_btn_Click(object sender, EventArgs e)
        {
            this.supervisor_update_price1.Visible = false;
            this.supervisor_hire_driver1.Visible = false;
            this.supervisor_hire_employee1.Visible = false;

            this.supervisor_create_trip1.Visible = false;
            this.supervisor_view_avail_trucks1.Visible = true;
            this.supervisor_assign_product1.Visible = false;
            this.supervisor_truck_arrived1.Visible = false;

        }

        private void supervisor_create_trip_btn_Click(object sender, EventArgs e)
        {
            this.supervisor_update_price1.Visible = false;
            this.supervisor_hire_driver1.Visible = false;
            this.supervisor_hire_employee1.Visible = false;
           
            this.supervisor_create_trip1.Visible = true;
            this.supervisor_view_avail_trucks1.Visible = false;
            this.supervisor_assign_product1.Visible = false;
            this.supervisor_truck_arrived1.Visible = false;

        }

        private void supervisor_assign_product_btn_Click(object sender, EventArgs e)
        {
            this.supervisor_update_price1.Visible = false;
            this.supervisor_hire_driver1.Visible = false;
            this.supervisor_hire_employee1.Visible = false;

            this.supervisor_create_trip1.Visible = false;
            this.supervisor_view_avail_trucks1.Visible = false;
            this.supervisor_assign_product1.Visible = true;
            this.supervisor_truck_arrived1.Visible = false;

        }

        private void supervisor_truck_arrived_btn_Click(object sender, EventArgs e)
        {
            this.supervisor_update_price1.Visible = false;
            this.supervisor_hire_driver1.Visible = false;
            this.supervisor_hire_employee1.Visible = false;

            this.supervisor_create_trip1.Visible = false;
            this.supervisor_view_avail_trucks1.Visible = false;
            this.supervisor_assign_product1.Visible = false;
            this.supervisor_truck_arrived1.Visible = true;
        }
    }
}

