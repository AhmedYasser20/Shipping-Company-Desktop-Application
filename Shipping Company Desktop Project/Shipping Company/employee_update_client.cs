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
    public partial class employee_update_client : UserControl
    {
        Controller controllerObj;
        int BrID;
        public employee_update_client(int branch)
        {
            BrID = branch;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void employee_update_client_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void employee_update_client_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void employee_update_client_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_update_client_branchid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_update_client_update_btn_Click(object sender, EventArgs e)
        {
            string ClientFName = employee_update_client_fn.Text;
            string ClientLName = employee_update_client_ln.Text;
            int SSN = Convert.ToInt32(employee_update_client_ssn.Text);
            int BranchID = BrID;

            int result = controllerObj.UpdateClient(ClientFName, ClientLName,SSN,BranchID);

            // Error in updating data
            if (result==0)
            {
                employee_updata_unsuccessful_label.Visible = true;
                employee_update_successful_label.Visible = false;
            }
            else
            {
                employee_updata_unsuccessful_label.Visible = false;
                employee_update_successful_label.Visible = true;
            }
        }
    }
}
