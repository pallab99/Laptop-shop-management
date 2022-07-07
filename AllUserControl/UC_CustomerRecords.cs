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
    public partial class UC_CustomerRecords : UserControl
    {
        function fn = new function();
        string query;
        int  id;
        public UC_CustomerRecords()
        {
            InitializeComponent();
        }
        public void enableddisabled(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtPassword.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }
        private void UC_CustomerRecords_Enter(object sender, EventArgs e)
        {
           
            query = "select * from customerPurchase";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        Boolean flag;
        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex==0)
            {
                flag = false;
                labelTOSET.Text = "Enter Customer Name";
            }
            else if(txtSearchBy.SelectedIndex == 1)
            {
                flag = true;
                labelTOSET.Text = "Enter Serial Number";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                query = "select * from customerPurchase where cname like '" + txtSearch.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from customerPurchase where imei like '" + txtSearch.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value != null)
            {
                id = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            if (id.ToString() != null)
            {
                query = "update customerPurchase set cname='" + guna2DataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "',gender='"+ guna2DataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString()+"',contact='"+ guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString() + "',email='"+ guna2DataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString() + "',caddress='"+ guna2DataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString() + "' where cid=" + id + "";
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            enableddisabled(true, true, true);
            guna2DataGridView2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
        }

        private void UC_CustomerRecords_Load(object sender, EventArgs e)
        {
            enableddisabled(false, false, false);
            label4.Visible = false;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "pallab")
            {
                fn.setData(query);
                guna2DataGridView2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                enableddisabled(false, false, false);
            }
            else
                MessageBox.Show("Enter correct password");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableddisabled(false, false, false);
            label3.Visible = true;
            label4.Visible = false;
            guna2DataGridView2.Visible = true;
        }
    }
}
