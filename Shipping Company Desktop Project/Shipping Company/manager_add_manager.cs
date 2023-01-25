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
    public partial class manager_add_manager : UserControl
    {
        Controller controllerObj;
        int RPassword;
        public manager_add_manager()
        {
            InitializeComponent();
            controllerObj = new Controller();
            RPassword = 15212518;
        }

        private void manager_add_manager_ssn_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void manager_add_manager_fn_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void manager_add_manager_ln_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void manager_add_manager_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void CreatingUserPassword(string UserName)
        {
            MessageBox.Show("Username: " + UserName + "\n" + "Temp Password: " + RPassword.ToString());
        }
        private void manager_add_manager_add_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HERE");
            if (manager_add_manager_fn.Text.Length != 0 && manager_add_manager_ln.Text.Length != 0 && manager_add_manager_ssn.Text.Length != 0 && manager_add_manager_Salary.Text.Length != 0)
            {

                RPassword++;
                String hashedPassword = controllerObj.hashing(RPassword.ToString());
                int y = controllerObj.AddManager(manager_add_manager_fn.Text, manager_add_manager_ln.Text, manager_add_manager_ssn.Text, manager_add_manager_Salary.Text);
                int x = controllerObj.SetTempLogin(manager_add_manager_fn.Text, hashedPassword, manager_add_manager_ssn.Text);

                if (y != 0 && x != 0)
                {
                    manager_add_manager_error_label.Visible = false;
                    manager_add_manager_successful_label.Visible = true;

                    CreatingUserPassword(manager_add_manager_fn.Text);
                }
                else
                {
                    manager_add_manager_error_label.Visible = true;
                    manager_add_manager_successful_label.Visible = false;
                }
            }
            else
            {
                manager_add_manager_error_label.Visible = true;
                manager_add_manager_successful_label.Visible = false;
            }
        }

        private void manager_add_manager_add_btn_Click_1(object sender, EventArgs e)
        {

            if (manager_add_manager_fn.Text.Length != 0 && manager_add_manager_ln.Text.Length != 0 && manager_add_manager_ssn.Text.Length != 0 && manager_add_manager_Salary.Text.Length != 0)
            {

                RPassword++;
                String hashedPassword = controllerObj.hashing(RPassword.ToString());
                int y = controllerObj.AddManager(manager_add_manager_fn.Text, manager_add_manager_ln.Text, manager_add_manager_ssn.Text, manager_add_manager_Salary.Text);
                int x = controllerObj.SetTempLogin(manager_add_manager_fn.Text, hashedPassword, manager_add_manager_ssn.Text);
                



                if (y != 0 && x != 0)
                {
                    manager_add_manager_error_label.Visible = false;
                    manager_add_manager_successful_label.Visible = true;

                    CreatingUserPassword(manager_add_manager_fn.Text);
                }
                else
                {
                    manager_add_manager_error_label.Visible = true;
                    manager_add_manager_successful_label.Visible = false;
                }
            }
            else
            {
                manager_add_manager_error_label.Visible = true;
                manager_add_manager_successful_label.Visible = false;
            }
        }
    }
}
