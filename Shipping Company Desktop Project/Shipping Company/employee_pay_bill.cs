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
    public partial class employee_pay_bill : UserControl
    {
        Controller controllerObj;
        public employee_pay_bill()
        {
            InitializeComponent();
            controllerObj= new Controller();
        }

        private void employee_pay_bill_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_pay_bill_bill_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_pay_bill_view_btn_Click(object sender, EventArgs e)
        {
            if (employee_pay_bill_ssn.Text.Length != 0)
            {
                DataTable dt = controllerObj.ViewProducts(employee_pay_bill_ssn.Text);
                employee_pay_bill_datagrid.DataSource = dt;
                employee_pay_bill_datagrid.Refresh();
            }
        }

        private void employee_pay_bill_pay_btn_Click(object sender, EventArgs e)
        {
            if (employee_pay_bill_bill_id.Text.Length != 0)
            {
                int result = controllerObj.PayBill(employee_pay_bill_bill_id.Text);
                MessageBox.Show(result.ToString());
            }
        }
    }
}
