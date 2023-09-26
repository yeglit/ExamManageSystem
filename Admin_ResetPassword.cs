using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace 试题库管理系统
{
    public partial class Admin_ResetPassword : Form
    {
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;
        public Admin_ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = txt_account.Text;
            string oldpas = txt_oldpass.Text;
            string newpas = txt_newpass.Text;
            string renewpas = txt_renewpass.Text;

            builder.UserID = "root";//用户
            builder.Password = "123456";//密码
            builder.Server = "localhost";
            builder.Database = "test_database";//数据库名
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            string sql = "select * from user";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            mda.Fill(ds, "user");

            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (txt_account.Text == dr["account"].ToString() && txt_oldpass.Text == dr["password"].ToString())
                    {
                        sql = "update user set password = '" + newpas + "' where account = '" + acc + "'";
                        MySqlCommand cmd = new MySqlCommand(sql,connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功");

                    }
}
            }
            connection.Close();
    }
    }
}
