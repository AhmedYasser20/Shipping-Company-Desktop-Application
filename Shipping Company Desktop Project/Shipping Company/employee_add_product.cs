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
    public partial class employee_add_product : UserControl
    {
        Controller controllerObj;
        int SSNE;
        int empBranch;
        public employee_add_product(int SSN, int branch)
        {
            SSNE = SSN;
            empBranch = branch;
            InitializeComponent();
           
            
            controllerObj =new Controller();
        }

        private void employee_add_product_sender_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_add_product_reciever_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_add_product_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void employee_add_product_create_btn_Click(object sender, EventArgs e)
        {
            if (employee_add_product_sender_ssn.Text != "" && employee_add_product_reciever_ssn.Text != "" && employee_add_product_weight.Text != "" && employee_add_product_truck_type.Text!="")
            {
                int S_SSN = Convert.ToInt32(employee_add_product_sender_ssn.Text);
                int R_SSN = Convert.ToInt32(employee_add_product_reciever_ssn.Text);
                int weight = Convert.ToInt32(employee_add_product_weight.Text);
               
                object sb = controllerObj.GetBranchClientBySSN(employee_add_product_sender_ssn.Text);
                int sender_branch = Convert.ToInt32(sb);

                if (S_SSN != R_SSN && sender_branch == empBranch)
                {

                    string TruckType = employee_add_product_truck_type.GetItemText(employee_add_product_truck_type.SelectedItem);
                    int result = controllerObj.add_Product(S_SSN, R_SSN, weight, TruckType);

                    if (result == 0)
                    {
                        employee_add_product_unsuccessful_label.Visible = true;
                        employee_create_product_successful_label.Visible = false;
                    }
                    else
                    {
                        object result2 = controllerObj.GetPrice(weight, TruckType);

                        int rw = Convert.ToInt32(result2);
                        object productid = controllerObj.GetProductID(S_SSN.ToString(), R_SSN.ToString());
                        productid = Convert.ToInt32(productid);
                        controllerObj.CreateBill(productid.ToString(), SSNE.ToString(), S_SSN.ToString(), "Pending", rw.ToString());
                        MessageBox.Show("Product ID:" + productid.ToString() + "\n" + "Bill ID : " + controllerObj.GetBillIDByProductID(productid.ToString()) + "");
                        employee_add_product_unsuccessful_label.Visible = false;
                        employee_create_product_successful_label.Visible = true;
                    }
                }
                else
                {
                    employee_add_product_unsuccessful_label.Visible = true;
                    employee_create_product_successful_label.Visible = false;
                }
            }
            else
            {
                employee_add_product_unsuccessful_label.Visible = true;
                employee_create_product_successful_label.Visible = false;
            }
        }
    }
}
