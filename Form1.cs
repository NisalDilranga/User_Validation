using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loging_vali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String name = txtUser.Text;
            String password = txtPass.Text;

            if( name == "banda" && password == "baN12")
            {
                MessageBox.Show("your Valid User");
            }
            else
            {
                MessageBox.Show("Check Your Login Details");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
