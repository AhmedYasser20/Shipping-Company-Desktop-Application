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
    public partial class manager_move_employee : UserControl
    {
        Controller controllerObj;
        public manager_move_employee()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void manager_move_employee_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void manager_move_employee_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter characters only
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void manager_move_employee_ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void manager_move_employee_branchid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow user to enter numbers only
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void manager_move_employee_move_btn_Click(object sender, EventArgs e)
        {

            DataTable x = controllerObj.GetNameOfEmployee(manager_move_employee_ssn.Text);
            if (x != null)
            {
                if (x.Rows[0][0].ToString() == manager_move_employee_fn.Text && x.Rows[0][1].ToString() == manager_move_employee_ln.Text)
                {
                    int y = controllerObj.UpdataBranchID(manager_move_employee_ssn.Text, manager_move_employee_branchid.Text);
                    if (y != 0)
                    {
                        manager_move_employee_successful_label.Visible = true;
                        manager_move_employee_error_label.Visible = false;
                    }
                    else
                    {
                        manager_move_employee_error_label.Visible = true;
                        manager_move_employee_successful_label.Visible = false;
                    }
                }
                else
                {
                    manager_move_employee_error_label.Visible = true;
                    manager_move_employee_successful_label.Visible = false;
                }
            }
            else
            {
                manager_move_employee_error_label.Visible = true;
                manager_move_employee_successful_label.Visible = false;
            }
        }
    //Error in entering data
    //if (result == 0)
    //{
    //    manager_move_employee_error_label.Visible = true;
    //    manager_move_employee_successful_label.Visible = false;
    //}
    //else
    //{
    //    manager_move_employee_error_label.Visible = false;
    //    manager_move_employee_successful_label.Visible = true;
    //}
}
    }

