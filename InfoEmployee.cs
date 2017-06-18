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
    public partial class InfoEmployee : Form
    {
        private SqlConnection myconn = new SqlConnection(dbConnection.connection);
        public static string Empid;
        public InfoEmployee()
        {
            InitializeComponent();
        }

        private void InfoEmployee_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“shebeiDataSet_Employee.Employee”中。您可以根据需要移动或删除它。
            this.employeeTableAdapter.Fill(this.shebeiDataSet_Employee.Employee);
            // TODO:  这行代码将数据加载到表“shebeiDataSet_Employee.Employee”中。您可以根据需要移动或删除它。
            this.employeeTableAdapter.Fill(this.shebeiDataSet_Employee.Employee);
            // TODO:  这行代码将数据加载到表“shebeiDataSet_Employee.Employee”中。您可以根据需要移动或删除它。
            this.employeeTableAdapter.Fill(this.shebeiDataSet_Employee.Employee);
            // TODO:  这行代码将数据加载到表“shebeiDataSet_Employee.Employee”中。您可以根据需要移动或删除它。
            //this.employeeTableAdapter.Fill(this.shebeiDataSet_Employee.Employee);
            // TODO:  这行代码将数据加载到表“shebeiDataSet.Employee”中。您可以根据需要移动或删除它。
            //this.employeeTableAdapter1.Fill(this.shebeiDataSet.Employee);
            // TODO:  这行代码将数据加载到表“shebeiDataSet_Employee.Employee”中。您可以根据需要移动或删除它。
            //this.employeeTableAdapter.Fill(this.shebeiDataSet_Employee.Employee);

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView1.CurrentRow.Index;
            Empid = this.dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            myconn.Open();
            string sql = "delete from employee where empid='" + Empid + "'";
            SqlCommand cmd = new SqlCommand(sql, myconn);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select * from employee where empid='" + Empid + "'";
            //cmd.executenonquery();
            if (cmd.ExecuteScalar() == null)
                MessageBox.Show("删除成功", "提示");
            else
                MessageBox.Show("删除失败" + Empid + "，请联系管理员", "提示");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int r = this.dataGridView1.CurrentRow.Index;
            Empid = this.dataGridView1.Rows[r].Cells[0].Value.ToString().Trim();
            ModifyEmployee ModifyEmployee = new ModifyEmployee();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempchild = (Form)MdiChildren[x];
                tempchild.Close();
            }
            //addpurchse.mdiparent = this;
            // help.mdiparent = this;
            //addpurchse.windowstate = formwindowstate.maximized;
            ModifyEmployee.Show();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.Fill(this.shebeiDataSet_Employee.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        
    }
}
