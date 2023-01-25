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
    public partial class manager_update_salaries : UserControl
    {
        Controller controllerObj;
        public manager_update_salaries()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void manager_update_salaries_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void manager_update_salaries_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void manager_update_salaries_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void manager_update_salaries_update_btn_Click(object sender, EventArgs e)
        {
            if (manager_update_sallaries_fn.Text.Length != 0 && manager_update_sallaries_ln.Text.Length != 0 && manager_update_sallaries_ssn.Text.Length != 0 && manager_update_sallaries_new_salary.Text.Length != 0)
            {
                DataTable x = controllerObj.GetEmployeeBySSN(manager_update_sallaries_ssn.Text);
                if (x != null)
                {
                    if (x.Rows[0][0].ToString() == manager_update_sallaries_fn.Text && x.Rows[0][1].ToString() == manager_update_sallaries_ln.Text)
                    {
                       int y= controllerObj.UpdataEmployeeSalaryBySSN(manager_update_sallaries_ssn.Text, manager_update_sallaries_new_salary.Text);
                        if (y != 0)
                        {
                            manager_update_salaries_successful_label.Visible = true;
                            manager_update_salaries_error_label.Visible = false;

                        }
                        else
                        {
                            manager_update_salaries_error_label.Visible = true;
                            manager_update_salaries_successful_label.Visible = false;
                        }
                    }
                    else
                    {
                        manager_update_salaries_error_label.Visible = true;
                        manager_update_salaries_successful_label.Visible = false;
                    }
                }
                else
                {
                    manager_update_salaries_error_label.Visible = true;
                    manager_update_salaries_successful_label.Visible = false;
                }
                //Error in entering data
                //if (result == 0)
                //{
                //    manager_update_salaries_error_label.Visible = true;
                //    manager_update_salaries_successful_label.Visible = false;
                //}
                //else
                //{
                //    manager_update_salaries_error_label.Visible = false;
                //    manager_update_salaries_successful_label.Visible = true;
                //}

            }
            }
        private void manager_update_sallaries_new_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
