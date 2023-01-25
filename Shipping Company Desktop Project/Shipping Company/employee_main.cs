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
    public partial class employee_main : KryptonForm
    {
        string name;
        int branchid;
        int departmentid;
        int SSNE;
        public employee_main(string fname, int branch, int SSN)
        {
            SSNE = SSN;
            branchid = branch;
            InitializeComponent();
            name = fname;
           

           
            
            employee_main_name_label.Text = name;
            employee_main_branchid_label.Text = branchid.ToString();
            
        }

        private void employee_add_client_btn_Click(object sender, EventArgs e)
        {
            this.employee_add_client1.Visible = true;
            this.employee_update_client1.Visible = false;
            this.employee_view_clients1.Visible = false;
            this.employee_add_product1.Visible = false;
            this.employee_product_details1.Visible = false;
            this.employee_pay_bill1.Visible = false;
            this.employee_product_recieved1.Visible = false;

        }

        private void employee_signout_btn_Click_1(object sender, EventArgs e)
        {
            login_page lp = new login_page();
            lp.Show();
            this.Close();
        }

        private void employee_update_client_btn_Click(object sender, EventArgs e)
        {
            this.employee_add_client1.Visible = false;
            this.employee_update_client1.Visible = true;
            this.employee_view_clients1.Visible = false;
            this.employee_add_product1.Visible = false;
            this.employee_product_details1.Visible = false;
            this.employee_pay_bill1.Visible = false;
            this.employee_product_recieved1.Visible = false;

        }

        private void employee_view_clients_btn_Click(object sender, EventArgs e)
        {
            this.employee_add_client1.Visible = false;
            this.employee_update_client1.Visible = false;
            this.employee_view_clients1.Visible = true;
            this.employee_add_product1.Visible = false;
            this.employee_product_details1.Visible = false;
            this.employee_pay_bill1.Visible = false;
            this.employee_product_recieved1.Visible = false;

        }

        private void employee_add_product_btn_Click(object sender, EventArgs e)
        {
            
            this.employee_add_client1.Visible = false;
            this.employee_update_client1.Visible = false;
            this.employee_view_clients1.Visible = false;
            this.employee_add_product1.Visible = true;
            this.employee_product_details1.Visible = false;
            this.employee_pay_bill1.Visible = false;
            this.employee_product_recieved1.Visible = false;


        }

        private void employee_product_datails_btn_Click(object sender, EventArgs e)
        {
            this.employee_add_client1.Visible = false;
            this.employee_update_client1.Visible = false;
            this.employee_view_clients1.Visible = false;
            this.employee_add_product1.Visible = false;
            this.employee_product_details1.Visible = true;
            this.employee_pay_bill1.Visible = false;
            this.employee_product_recieved1.Visible = false;


        }

        private void employe_pay_bills_btn_Click(object sender, EventArgs e)
        {
            this.employee_add_client1.Visible = false;
            this.employee_update_client1.Visible = false;
            this.employee_view_clients1.Visible = false;
            this.employee_add_product1.Visible = false;
            this.employee_product_details1.Visible = false;
            this.employee_pay_bill1.Visible = true;
            this.employee_product_recieved1.Visible = false;

        }

        private void employee_product_recieved_btn_Click(object sender, EventArgs e)
        {
            this.employee_add_client1.Visible = false;
            this.employee_update_client1.Visible = false;
            this.employee_view_clients1.Visible = false;
            this.employee_add_product1.Visible = false;
            this.employee_product_details1.Visible = false;
            this.employee_pay_bill1.Visible = false;
            this.employee_product_recieved1.Visible = true;
        }
    }
}

