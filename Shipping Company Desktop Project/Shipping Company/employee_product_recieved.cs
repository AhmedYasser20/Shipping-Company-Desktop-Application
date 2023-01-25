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
    public partial class employee_product_recieved : UserControl
    {
        Controller controllerObj;
        int BRID;
        bool found = false;
        public employee_product_recieved(int BRID1)
        {
            BRID = BRID1;

            InitializeComponent();
            controllerObj= new Controller();
        }

        private void employee_product_recieved_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_product_recieved_product_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_product_recieved_view_btn_Click(object sender, EventArgs e)
        {

            object ob = controllerObj.GetBranchClientBySSN(employee_product_recieved_ssn.Text);
            int branch = Convert.ToInt32(ob);

            if (branch == BRID)
            {
                DataTable dt = controllerObj.RecievedProduct(employee_product_recieved_ssn.Text);
                employee_product_recieved_datagrid.DataSource = dt;
                employee_product_recieved_datagrid.Refresh();
                found = true;
            }
            else
            {
                MessageBox.Show("Not Same Branch!!");
            }
        }

        private void employee_product_recieved_recieve_btn_Click(object sender, EventArgs e)
        {
            if (found)
            {
                controllerObj.GiveProductToReciever(employee_product_recieved_product_id.Text);
            }
            else
            {
                MessageBox.Show("Check first please!!");
            }
        }
    }
}


