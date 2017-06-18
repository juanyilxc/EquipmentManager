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
    public partial class AddMaintain : Form
    {
        public AddMaintain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(dbConnection.connection);
            if (txtID1.Text.Trim() == "" || txtmoney.Text.Trim() == "")
                MessageBox.Show("请填写完整信息", "提示");
            else
            {
                myCon.Open();
                string sql = "select * from Maintain where EID='" + txtID1.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, myCon);
                if (cmd.ExecuteScalar() != null)
                    MessageBox.Show("设备编号重复", "提示");
                else
                {
                    sql = "insert into Maintain values ('" + MainForm.ID + "','" + txtID1.Text.Trim() + "','" + dtpMaintainDate.Text.Trim() + "','" + txtmoney.Text.Trim() + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功", "提示");
                    txtID1.Text = "";
                    dtpMaintainDate.Text = System.DateTime.Now.ToString();
                    txtmoney.Text = "";
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
