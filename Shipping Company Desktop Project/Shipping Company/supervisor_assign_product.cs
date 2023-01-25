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
    public partial class supervisor_assign_product : UserControl
    {
        public supervisor_assign_product()
        {
            InitializeComponent();
        }

        private void supervisor_update_bills_sender_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_update_bills_reciever_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_update_bills_product_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_update_bills_update_btn_Click(object sender, EventArgs e)
        {
            //Error in entering data
            //if (result == 0)
            //{
            //    supervisor_update_bills_unsuccessful_label.Visible = true;
            //    supervisor_update_bills_successful_label.Visible = false;
            //}
            //else
            //{
            //    supervisor_update_bills_unsuccessful_label.Visible = false;
            //    supervisor_update_bills_successful_label.Visible = true;
            //}
        }

        private void supervisor_update_bills_fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        
    }
}
