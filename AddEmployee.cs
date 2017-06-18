using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentManager
{
    public partial class AddEmployee : Form
    {
        private SqlConnection myCon = null;
        public AddEmployee()
        {
            InitializeComponent();
            this.myCon = new SqlConnection(dbConnection.connection);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "" || txtPassword.Text.Trim() == "" )
                MessageBox.Show("请填写完整信息", "提示");
            else
            {
                myCon.Open();
                string sql = "select * from Employee where EmpID='" + txtId.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, myCon);
                if (cmd.ExecuteScalar() != null)
                    MessageBox.Show("身份重复", "提示");
                else
                {
                    sql = "insert into Employee values ('"+ txtId.Text.Trim() + "','" + txtPassword.Text.Trim() +"','" + txtName.Text.Trim() + "','" + txtAge.Text.Trim() + "','" + txtWorkYear.Text.Trim() + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功", "提示");
                    txtId.Text = "";
                    txtPassword.Text = "";
                    txtName.Text = ""; 
                    txtAge.Text = "";
                    txtWorkYear.Text = "";
                }
                myCon.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
