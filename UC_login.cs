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
    public partial class UC_login : UserControl
    {
        public UC_login()
        {
            InitializeComponent();
            ToShowLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_login_Load(object sender, EventArgs e)
        {

        }

        private void ToShowLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            {
             
                if(txtUsername.Text=="admin" && txtPassword.Text == "admin")
                {
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    panel1.Visible = true;
                    ToShowLabel.Visible = true;
                    timer1.Stop();
                }
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
