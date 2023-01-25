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
    public partial class change_password : UserControl
    {
        Controller controllerObj;
        public change_password()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void back_to_login_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void change_password_change_btn_Click(object sender, EventArgs e)
        {
            if (change_password_new_password.Text.Length != 0 && change_password_old_password.Text.Length != 0 && change_password_username.Text.Length != 0 )
            {

                String hashedPassword = controllerObj.hashing(change_password_new_password.Text);
                String hashedPasswordOld = controllerObj.hashing(change_password_old_password.Text);

                int y = controllerObj.ChangePassword(hashedPassword, hashedPasswordOld, change_password_username.Text);

                if (y != 0 )
                {
                    password_error_label.Visible = false;
                    password_successful_label.Visible = true;

                 
                }
                else
                {
                    password_error_label.Visible = true;
                    password_successful_label.Visible = false;
                }
            }
            else
            {
                password_error_label.Visible = true;
                password_successful_label.Visible = false;
            }
            
        }

        
    }
}
