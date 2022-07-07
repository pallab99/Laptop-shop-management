using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laptopmanagementshop.AllUserControl
{
    public partial class UC_Accessories_Purchase : UserControl
    {
        function fn = new function();
        String query;
        public UC_Accessories_Purchase()
        {
            InitializeComponent();
        }
        public void setComboBOX(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getforCombo(query);//select model from newMobile
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtIteam.Text !="" && txtCompany.Text != "" && txtModel.Text != "" && txtSeriel.Text != "")
            {
                string name = txtName.Text;
                string gender = txtGender.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                string iteam = txtIteam.Text;
                string company = txtCompany.Text;
                string model = txtModel.Text;
                string imei = txtSeriel.Text;

                query = "insert into Purchase (cname,gender,contact,email,caddress,item,company,model,imei) values ('" + name + "','" + gender + "'," + contact + ",'" + email + "','" + address + "','"+iteam+"','" + company + "','" + model + "','" + imei + "') ";
                fn.setData(query);
                txtName.Clear();
                txtGender.SelectedIndex = -1;
                txtContact.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtSeriel.Clear();
            }
            else
            {
                MessageBox.Show("Please fill with all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_Accessories_Purchase_Enter(object sender, EventArgs e)
        {
            txtIteam.Items.Clear();//if we don't write it then every time we switch to customer table then it's box data will stored multiple time
            query = "select distinct itemname from newAccessories";//i did this bcz company name is one we don't repeatedly need to select that
            setComboBOX(query, txtIteam);
        }

        private void txtIteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            String itemname = txtIteam.Text;
            query = "select distinct cname from newAccessories where itemname = '" + itemname + "'";
            setComboBOX(query, txtCompany);
        }

        private void txtCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            String cname = txtCompany.Text;
            query = "select distinct mname from newAccessories where cname = '" + cname + "'";
            setComboBOX(query, txtModel);
        }
    }
}
