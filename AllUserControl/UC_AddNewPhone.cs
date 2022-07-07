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
    public partial class UC_AddNewPhone : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void UC_AddNewPhone_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtModel.Clear();
            txtRam.StartIndex = -1;//because it is combo box
            txtInternal.StartIndex = -1;
            txtExpandable.StartIndex = -1;
            txtDisplay.StartIndex = -1;
            txtFingerprint.StartIndex = -1;
            txtFront.StartIndex = -1;
            txtRear.StartIndex = -1;
            txtSim.StartIndex = -1;
            txtNetwork.StartIndex = -1;
            txtPrice.Clear();
        }

        /*private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModel.Text != "" && txtRam.Text != "" && txtInternal.Text != "" && txtExpandable.Text != "" && txtDisplay.Text != "" && txtRear.Text != "" && txtFront.Text != "" && txtFingerprint.Text != "" && txtSim.Text != "" && txtNetwork.Text != "" && txtPrice.Text != "")
            {//change
                String company = txtCompany.Text;
                String model = txtModel.Text;
                String ram = txtRam.Text;
                String intel = txtInternal.Text;//here using intel variable
                String expandable = txtExpandable.Text;
                String display = txtDisplay.Text;
                String rear = txtRear.Text;
                String front = txtFront.Text;
                String fingerprint = txtFingerprint.Text;
                String sim = txtSim.Text;
                String network = txtNetwork.Text;
                Int64 price = Int64.Parse(txtPrice.Text);//here parse is a function which is converter string to int

                query = "insert into newMobile (cname,mname,ram,interval,expandable,display,rear,front,finger,sim,network,price) values('" + company + "','" + model + "','" + ram + "','" + intel + "','" + expandable + "','" + display + "','" + rear + "','" + front + "','" + fingerprint + "','" + sim + "','" + network + "'," + price + ")";
                fn.setData(query);//change
            }
            else
            {
                MessageBox.Show("Please fill with all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       */

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModel.Text != "" && txtRam.Text != "" && txtInternal.Text != "" && txtExpandable.Text != "" && txtDisplay.Text != "" && txtRear.Text != "" && txtFront.Text != "" && txtFingerprint.Text != "" && txtSim.Text != "" && txtNetwork.Text != "" && txtPrice.Text != "")
            {//change
                String company = txtCompany.Text;
                String model = txtModel.Text;
                String ram = txtRam.Text;
                String intel = txtInternal.Text;//here using intel variable
                String expandable = txtExpandable.Text;
                String display = txtDisplay.Text;
                String rear = txtRear.Text;
                String front = txtFront.Text;
                String fingerprint = txtFingerprint.Text;
                String sim = txtSim.Text;
                String network = txtNetwork.Text;
                Int64 price = Int64.Parse(txtPrice.Text);//here parse is a function which is converter string to int

                query = "insert into newMobile (cname,mname,ram,internal,expandable,display,rear,front,finger,sim,network,price) values('" + company + "','" + model + "','" + ram + "','" + intel + "','" + expandable + "','" + display + "','" + rear + "','" + front + "','" + fingerprint + "','" + sim + "','" + network + "'," + price + ")";
                fn.setData(query);//change
            }
            else
            {
                MessageBox.Show("Please fill with all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

       
    }
}
