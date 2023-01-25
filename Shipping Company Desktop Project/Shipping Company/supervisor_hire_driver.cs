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
    public partial class supervisor_hire_driver : UserControl
    {
        Controller controllerObj;
        int branchid;
        public supervisor_hire_driver(int branch)
        {
            branchid = branch;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void supervidor_hire_driver_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void supervidor_hire_driver_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void supervidor_hire_driver_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervidor_hire_driver_add_btn_Click(object sender, EventArgs e)
        {
            string fname = supervisor_hire_driver_fn.Text;
            string lname = supervisor_hire_driver_ln.Text;
            int ssn = Convert.ToInt32(supervisor_hire_driver_ssn.Text);
            int salary = Convert.ToInt32(supervisor_hire_driver_salary.Text);
            int bn = branchid;
            int result = controllerObj.HireDriver(fname, lname, ssn, salary, bn);
            //Error in entering data
            if (result == 0)
            {
                supervisor_hire_driver_error_label.Visible = true;
                supervisor_hire_driver_successful_label.Visible = false;
            }
            else
            {
                supervisor_hire_driver_error_label.Visible = false;
                supervisor_hire_driver_successful_label.Visible = true;
            }
        }

        private void kryptonTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
