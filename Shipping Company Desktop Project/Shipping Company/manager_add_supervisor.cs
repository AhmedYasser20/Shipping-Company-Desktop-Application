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
    public partial class manager_add_supervisor : UserControl
    {
        Controller controllerObj;
        int RPassword;
        public manager_add_supervisor()
        {
            InitializeComponent();
            controllerObj = new Controller();
            RPassword = 15214715;
        }

        private void manager_add_supervisor_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void manager_add_supervisor_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void manager_add_supervisor_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void manager_add_supervisor_branchid_KeyPress(object sender, KeyPressEventArgs e)
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
        private void manager_add_supervisor_add_btn_Click(object sender, EventArgs e)
        {

            if (manager_add_supervisor_fn.Text.Length != 0 && manager_add_supervisor_ln.Text.Length != 0 && manager_add_supervisor_ssn.Text.Length != 0 && manager_add_supervisor_branchid.Text.Length != 0 &&manager_add_supervisor_Salary.Text.Length!=0)
            {
                controllerObj.UpdateEmployeeSupervisorID(manager_add_supervisor_ssn.Text, manager_add_supervisor_branchid.Text);
                RPassword++;
                String hashedPassword = controllerObj.hashing(RPassword.ToString());
                int y = controllerObj.AddSupervisor(manager_add_supervisor_fn.Text, manager_add_supervisor_ln.Text, manager_add_supervisor_ssn.Text, manager_add_supervisor_Salary.Text, manager_add_supervisor_branchid.Text);
                int x = controllerObj.SetTempLogin(manager_add_supervisor_fn.Text, hashedPassword, manager_add_supervisor_ssn.Text);


                MessageBox.Show(y.ToString() + "\n" + x.ToString());

                if (y != 0 && x != 0)
                {
                    manager_add_supervisor_error_label.Visible = false;
                    manager_add_supervisor_successful_label.Visible = true;
                   
                    CreatingUserPassword(manager_add_supervisor_fn.Text);
                }
                else
                {
                    manager_add_supervisor_error_label.Visible = true;
                    manager_add_supervisor_successful_label.Visible = false;
                }
            }
            else
            {
                manager_add_supervisor_error_label.Visible = true;
                manager_add_supervisor_successful_label.Visible = false;
            }
        }

        
        //Error in entering data
        //if (result == 0)
        //{
        //    manager_add_supervisor_error_label.Visible = true;
        //    manager_add_supervisor_successful_label.Visible = false;
        //}
        //else
        //{
        //    manager_add_supervisor_error_label.Visible = false;
        //    manager_add_supervisor_successful_label.Visible = true;
        //}
    

    private void manager_add_supervisor_depid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
