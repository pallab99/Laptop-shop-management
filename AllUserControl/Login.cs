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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            ToShowlabel.Visible = false;
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }
        int abc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if (abc == 10)
            {
                abc = 0;
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    panel1.Visible = true;
                    ToShowlabel.Visible = true;
                    timer1.Stop();
                }
            }
        }
    }
}
