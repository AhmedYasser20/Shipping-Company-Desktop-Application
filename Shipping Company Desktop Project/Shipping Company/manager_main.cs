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
    public partial class manager_main : KryptonForm
    {

        string name;
        int branchid;
        public manager_main(string fname, int branch)
        {
            InitializeComponent();
            name = fname;
            branchid = branch;

            manager_main_name_label.Text = name;
        }

        private void manager_move_employee_btn_Click(object sender, EventArgs e)
        {
            this.manager_move_employee1.Visible = true;
            this.manager_add_supervisor1.Visible = false;
            this.manager_view_all_assets1.Visible = false;
            this.manager_update_salaries1.Visible = false;
            this.manager_fire_employee1.Visible = false;
            this.manager_add_manager1.Visible = false;
            this.manager_add_truck1.Visible = false;

        }

        private void manager_signout_btn_Click_1(object sender, EventArgs e)
        {
            login_page lp = new login_page();
            lp.Show();
            this.Close();
        }

        private void manager_add_supervisor_btn_Click(object sender, EventArgs e)
        {
            this.manager_move_employee1.Visible = false;
            this.manager_add_supervisor1.Visible = true;
            this.manager_view_all_assets1.Visible = false;
            this.manager_update_salaries1.Visible = false;
            this.manager_fire_employee1.Visible = false;
            this.manager_add_manager1.Visible = false;
            this.manager_add_truck1.Visible = false;

        }

        private void manager_view_all_assets_btn_Click(object sender, EventArgs e)
        {
            this.manager_move_employee1.Visible = false;
            this.manager_add_supervisor1.Visible = false;
            this.manager_view_all_assets1.Visible = true;
            this.manager_update_salaries1.Visible = false;
            this.manager_fire_employee1.Visible = false;
            this.manager_add_manager1.Visible = false;
            this.manager_add_truck1.Visible = false;

        }

        private void manager_update_salaries_btn_Click(object sender, EventArgs e)
        {
            this.manager_move_employee1.Visible = false;
            this.manager_add_supervisor1.Visible = false;
            this.manager_view_all_assets1.Visible = false;
            this.manager_update_salaries1.Visible = true;
            this.manager_fire_employee1.Visible = false;
            this.manager_add_manager1.Visible = false;
            this.manager_add_truck1.Visible = false;

        }

        private void manager_fire_employee_btn_Click(object sender, EventArgs e)
        {
            this.manager_move_employee1.Visible = false;
            this.manager_add_supervisor1.Visible = false;
            this.manager_view_all_assets1.Visible = false;
            this.manager_update_salaries1.Visible = false;
            this.manager_fire_employee1.Visible = true;
            this.manager_add_manager1.Visible = false;
            this.manager_add_truck1.Visible = false;

        }

        private void manager_add_manager_btn_Click(object sender, EventArgs e)
        {
            this.manager_move_employee1.Visible = false;
            this.manager_add_supervisor1.Visible = false;
            this.manager_view_all_assets1.Visible = false;
            this.manager_update_salaries1.Visible = false;
            this.manager_fire_employee1.Visible = false;
            this.manager_add_manager1.Visible = true;
            this.manager_add_truck1.Visible = false;
        }

        private void manager_add_delete_truck_btn_Click(object sender, EventArgs e)
        {
            this.manager_move_employee1.Visible = false;
            this.manager_add_supervisor1.Visible = false;
            this.manager_view_all_assets1.Visible = false;
            this.manager_update_salaries1.Visible = false;
            this.manager_fire_employee1.Visible = false;
            this.manager_add_manager1.Visible = false;
            this.manager_add_truck1.Visible = true;
        }
    }
}

