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
    public partial class ModifyEmployee : Form
    {
        private SqlConnection myconn = new SqlConnection(dbConnection.connection);
        public ModifyEmployee()
        {
            InitializeComponent();
            string sql = "select * from Employee where EmpID='" + InfoEmployee.Empid + "'";
            SqlCommand cmd = new SqlCommand(sql,myconn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtId.Text = (string)reader.GetValue(0);
                    txtName.Text = (string)reader.GetValue(2);
                    txtPassword.Text = (string)reader.GetValue(1);
                    txtAge.Text = (string)reader.GetValue(3);
                    txtWorkYear.Text = (string)reader.GetValue(4);
                    
                }
            }
            myconn.Close();
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
