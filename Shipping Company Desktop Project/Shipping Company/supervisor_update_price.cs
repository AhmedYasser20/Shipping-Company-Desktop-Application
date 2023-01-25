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
    public partial class supervisor_update_price : UserControl
    {
        Controller controllerObj;
        public supervisor_update_price()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        

        private void supervisor_update_price_new_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void supervisor_update_list_update_btn_Click(object sender, EventArgs e)
        {
            string MinWeight = MinWeight_TextBox.Text;
            string MaxWeight = MaxWeight_TextBox.Text;
            string TruckType = supervisor_update_price_truck_type.Text;
            int price = Convert.ToInt32(supervisor_update_price_new_price.Text);
            //we need To check that comming values are in the table or not 
            DataTable dt = controllerObj.FindOutIfThisListExist(MinWeight, MaxWeight, TruckType);
            int result = 0;

            // if in 
            if (dt == null)
            {
                MessageBox.Show("dt null");
                result = controllerObj.InsertNewprice(MinWeight, MaxWeight, TruckType, price);
            }

            // if not
            else
            {
                MessageBox.Show("dt not null");
                result = controllerObj.updateprice(MinWeight, MaxWeight, TruckType, price);
            }
            // inserting comming value


            // Error in updating data
            if (result == 0)
            {
                MessageBox.Show("falid");
                supervisor_update_price_unsuccessful_label.Visible = true;
                supervisor_update_price_successful_label.Visible = false;
            }
            else
            {
                MessageBox.Show("success");
                supervisor_update_price_unsuccessful_label.Visible = false;
                supervisor_update_price_successful_label.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void supervisor_update_price_truck_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
