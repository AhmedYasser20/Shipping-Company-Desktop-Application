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
    public partial class employee_view_clients : UserControl
    {
        Controller controllerObj;
        public employee_view_clients()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void employee_view_clients_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void employee_view_clients_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void employee_view_clients_view_btn_Click(object sender, EventArgs e)
        {
            if (employee_view_clients_fn.Text != "" && employee_view_clients_ln.Text != "")
            {
                string FName = employee_view_clients_fn.Text;
                string LName = employee_view_clients_ln.Text;
                DataTable dt = controllerObj.GetClientByName(FName, LName);
                employee_view_clients_datagrid.DataSource = dt;
                employee_view_clients_datagrid.Refresh();
            }
        }
    }
}
