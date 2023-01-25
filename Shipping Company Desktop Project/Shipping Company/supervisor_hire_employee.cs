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
    public partial class supervisor_hire_employee : UserControl
    {
        Controller controllerObj;
        int branchid;
        int superSSN;
        int RPassword;
        public supervisor_hire_employee(int branch, int ssn)
        {
            branchid = branch;
            superSSN = ssn;
            RPassword = 1523648;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void supervisor_hire_employee_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void supervisor_hire_employee_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void supervisor_hire_employee_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_hire_employee_dep_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_hire_employee_hire_btn_Click(object sender, EventArgs e)
        {
            string fname = supervisor_hire_employee_fn.Text;
            string lname = supervisor_hire_employee_ln.Text;
            int ssn = Convert.ToInt32(supervisor_hire_employee_ssn.Text);
            int salary = Convert.ToInt32(supervisor_hire_employee_salary.Text);
            int BN = branchid;
            RPassword++;
            String hashedPassword = controllerObj.hashing(RPassword.ToString());

            int result = controllerObj.HireEmployee(fname, lname, ssn, salary, BN, superSSN);
            controllerObj.SetTempLogin(fname, hashedPassword, ssn.ToString());

            if (result == 0)
            {
                supervisor_hire_employee_error_label.Visible = true;
                supervisor_hire_employee_successful_label.Visible = false;
            }
            else
            {
                MessageBox.Show("UserName :" + fname + "  Password: " + RPassword);
                supervisor_hire_employee_error_label.Visible = false;
                supervisor_hire_employee_successful_label.Visible = true;
            }
        }

        
    }
}
