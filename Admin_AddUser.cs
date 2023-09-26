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
using NPOI.XWPF.UserModel;

namespace 试题库管理系统
{
    public partial class Admin_AddUser : Form
    {
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;
        public Admin_AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = txt_account.Text;
            string pas = txt_password.Text;

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
            bool flag = true;
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (txt_account.Text == dr["account"].ToString())
                    {
                        MessageBox.Show("该用户名已存在");
                        flag = false; break;
                    }
                }
            }
            
            if(flag){
                sql = "insert into user(account, password) VALUES ('" + acc + "', '" + pas + "');";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("添加成功");
            }
            
            
            connection.Close();
        }
    }
}
