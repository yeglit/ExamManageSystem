using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 试题库管理系统
{
    public partial class Admin_ManageUser : Form
    {
        public Admin_ManageUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_AddUser admin_adduser = new Admin_AddUser();
            admin_adduser.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_ResetPassword admin_resetpassword = new Admin_ResetPassword();
            admin_resetpassword.Visible = true;

        }
    }
}
