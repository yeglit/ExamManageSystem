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
    public partial class begin : Form
    {
        public begin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    this.Visible = false;
            User user = new User();
            user.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    this.Visible = false;
            Admin admin = new Admin();
            admin.Visible = true;
        }
    }
}
