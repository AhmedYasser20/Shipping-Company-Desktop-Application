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
    public partial class employee_add_client : UserControl
    {
        Controller controllerObj;
        int branchID;
        public employee_add_client(int brID)
        {
            branchID = brID;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void employee_add_client_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void employee_add_client_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void employee_add_client_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_add_client_branchid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_add_client_add_btn_Click(object sender, EventArgs e)
        {
            string ClientFName = employee_add_client_fn.Text;
            string ClientLName = employee_add_client_ln.Text;
            int SSN = Convert.ToInt32(employee_add_client_ssn.Text);

            int result = controllerObj.add_client(ClientFName, ClientLName, SSN, branchID);

            //Error in entering data
            if (result == 0)
            {
                employee_error_label.Visible = true;
                employee_successful_label.Visible = false;
            }
            else
            {
                employee_error_label.Visible = false;
                employee_successful_label.Visible = true;
            }
        }
    }
}
