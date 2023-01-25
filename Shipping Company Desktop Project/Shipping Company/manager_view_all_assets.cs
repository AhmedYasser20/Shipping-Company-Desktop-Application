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
    public partial class manager_view_all_assets : UserControl
    {
        Controller controllerObj;
        public manager_view_all_assets()
        {
            InitializeComponent();
            controllerObj  = new Controller();
            manager_view_all_assets_datagrid.DataSource = null;
        }

        private void manager_view_all_assets_Load(object sender, EventArgs e)
        {

        }

        private void manager_view_all_assets_view_btn_Click(object sender, EventArgs e)
        {
            // manager_view_all_assets_select_table.SelectedText;
            if (manager_view_all_assets_select_table.Text != "")
            {
                manager_view_all_assets_datagrid.DataSource = controllerObj.ViewData(manager_view_all_assets_select_table.Text);
                manager_view_all_assets_datagrid.Refresh();
            }
            else
            {
                MessageBox.Show("Select Table");
            }
        }
    }
}
