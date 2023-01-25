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
    public partial class manager_fire_employee : UserControl
    {
        Controller controllerObj;
        public manager_fire_employee()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void manager_fire_employee_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void manager_fire_employee_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void manager_fire_employee_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void manager_fire_employee_fire_btn_Click(object sender, EventArgs e)
        {
            if (manager_fire_employee_fn.Text.Length != 0 && manager_fire_employee_ln.Text.Length != 0 && manager_fire_employee_ssn.Text.Length != 0)
            {
                DataTable x=controllerObj.GetEmployeeBySSN(manager_fire_employee_ssn.Text);
               if(x != null)
                {
                    if (x.Rows[0][0].ToString()== manager_fire_employee_fn.Text && x.Rows[0][1].ToString() == manager_fire_employee_ln.Text)
                    {
                        int y=controllerObj.FireEmployeeBySSN(manager_fire_employee_ssn.Text);
                        if(y != 0)
                        {
                            manager_fire_employee_successful_label.Visible = true;
                            manager_fire_employee_error_label.Visible = false;

                        }
                        else
                        {
                            manager_fire_employee_error_label.Visible = true;
                            manager_fire_employee_successful_label.Visible = false;
                        }
                    }
                    else
                    {
                        manager_fire_employee_error_label.Visible = true;
                        manager_fire_employee_successful_label.Visible = false;
                    }
                }
               else
                {
                    manager_fire_employee_error_label.Visible = true;
                    manager_fire_employee_successful_label.Visible = false;
                }
            }
            else
            {
                manager_fire_employee_error_label.Visible = true;
                manager_fire_employee_successful_label.Visible = false;
            }
            //Error in entering data
            //if (result == 0)
            //{
            //    manager_fire_employee_error_label.Visible = true;
            //    manager_fire_employee_successful_label.Visible = false;
            //}
            //else
            //{
            //    manager_fire_employee_error_label.Visible = false;
            //    manager_fire_employee_successful_label.Visible = true;
            //}
        }
    }
}
