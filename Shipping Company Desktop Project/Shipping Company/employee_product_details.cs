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
    public partial class employee_product_details : UserControl
    {
        Controller controllerObj;
        public employee_product_details()
        {
            InitializeComponent();
            controllerObj= new Controller();
        }

        private void employee_product_details_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter character only
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void employee_product_details_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void employee_product_details_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_product_details_view_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ProductDetails(employee_product_details_ssn.Text);
            employee_product_details_datagrid.DataSource = dt;
            employee_product_details_datagrid.Refresh();
        }
    }
}
