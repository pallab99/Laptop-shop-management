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
    public partial class UC_Accessories : UserControl
    {
        function fn = new function();
        string query;
        public UC_Accessories()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtIteam.Text!="" && txtCompany.Text!="" && txtModel.Text!="" && txtPrice.Text!="")
            {
                string iteam = txtIteam.Text;
                string company = txtCompany.Text;
                string model = txtModel.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query ="insert into newAccessories(itemname,cname,mname,price) values('"+iteam+"','"+company+"','"+model+"',"+price+")";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Please fill with all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIteam.Clear();
            txtCompany.Clear();
            txtModel.Clear();
            txtPrice.Clear();
        }
    }
}
