using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Shipping_Company
{
    public partial class login_page : KryptonForm
    {
        Controller controllerobj;
        public login_page()
        {
            
            InitializeComponent();
            controllerobj = new Controller();
        }

        
        private void login_page_btn_Click(object sender, EventArgs e)
        {
            // open new window (employee)
            //employee_main em = new employee_main();
            //em.Show();

            // open new window (supervisor)
            //supervisor_main sp = new supervisor_main();
            //sp.Show();

            // open new window (manager)
            //manager_main mn = new manager_main();
            //mn.Show();

            //this.Close(); error there close all program


            // if user typed username or password incorrectly
            //if(condition)
            //{
            //    incorrect_pass_label.Visible = true;
            //}
            //else
            //    incorrect_pass_label.Visible = false;

            // controllerobj.CreateEmployeeTable();

            string Username = login_page_username.Text;
            string Password = login_page_password.Text;
            // employee with the username and password
            String hashedPassword = controllerobj.hashing(Password);
            DataTable dt = controllerobj.getEmployeeRowByUsernameAndPassword(Username, hashedPassword);
            



            if (dt == null)
            {
                incorrect_pass_label.Visible = true;
            }
            else
            {

                int branch = Convert.ToInt32(dt.Rows[0][5].ToString());
                int supervisorid = Convert.ToInt32(dt.Rows[0][3].ToString());
                string firstname = dt.Rows[0][0].ToString();
                int SSNE = Convert.ToInt32(dt.Rows[0][2].ToString());
               
                // manager
                if (branch == 0)
                {
                    manager_main MP = new manager_main(firstname, branch);
                    MP.Show();
                }
                // supervisor
                else if (supervisorid == 0)
                {
                    supervisor_main sp = new supervisor_main(firstname, branch, SSNE);
                    sp.Show();
                }
                // employee
                else
                {
                    employee_main em = new employee_main(firstname, branch, SSNE);
                    em.Show();
                }
            }

        }

        private void login_page_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow user to input characters only
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void login_page_change_pass_btn_Click(object sender, EventArgs e)
        {
            this.change_password1.Visible = true;
        }
    }
}
