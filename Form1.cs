using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laptopmanagementshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            uC_AddNewPhone1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Stock1.Visible = false;
            uC_CustomerRecords1.Visible = false;
            uC_DeletePhoneRecord1.Visible = false;
            enableddisabled(false, false, false);
            uC_Accessories1.Visible = false;
            uC_Accessories_Purchase1.Visible = false;
            uC_Accessories_Stock1.Visible = false;
        }

        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = true;
            uC_AddNewPhone1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void btnCustomerRecords_Click(object sender, EventArgs e)
        {
            uC_CustomerRecords1.Visible = true;
            uC_CustomerRecords1.BringToFront();
        }
        public void enableddisabled(Boolean txtbox,Boolean btn1,Boolean btn2)
        {
            txtPassword.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enableddisabled(true, true, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enableddisabled(false, false, false);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text=="admin")
            {
                panel2.Enabled = true;
                uC_DeletePhoneRecord1.Visible = true;
                uC_DeletePhoneRecord1.BringToFront();
                enableddisabled(false, false, false);
                txtPassword.Clear();
            }
            else
            {
                txtPassword.Clear();
            }
        }

        private void btnAccessories_Click(object sender, EventArgs e)
        {
            uC_Accessories1.Visible = true;
            uC_Accessories1.BringToFront();

        }

        private void btnAccessoriespurchase_Click(object sender, EventArgs e)
        {
            uC_Accessories_Purchase1.Visible = true;
            uC_Accessories_Purchase1.BringToFront();
        }

        private void btnStoredaccessories_Click(object sender, EventArgs e)
        {
            uC_Accessories_Stock1.Visible = true;
            uC_Accessories_Stock1.BringToFront();
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void uC_login1_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnAddNewPhone.PerformClick();

        }
    }
}
