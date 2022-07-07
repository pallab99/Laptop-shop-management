using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laptopmanagementshop.AllUserControl
{
    public partial class UC_Accessories_Stock : UserControl
    {
        function fn = new function();
        string query;
        public UC_Accessories_Stock()
        {
            InitializeComponent();
        }

        private void UC_Accessories_Stock_Enter(object sender, EventArgs e)
        {
            query = "select * from newAccessories";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
    }
}
