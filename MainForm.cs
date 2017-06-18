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
    public partial class MainForm : Form
    {
        public static string ID;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbConnection.connection);
            conn.Open();
            //SqlCommand cmd = new SqlCommand();
            if (txtname.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("请不要遗漏信息！");
                this.txtname.Focus();
            }
            else
            {
                try
                {
                    if (adminn.Checked)
                    {
                        string cstr = "select * from Admin where name='" + txtname.Text.Trim() + "'and password='" + txtpassword.Text.Trim() + "'";
                        SqlCommand comm = new SqlCommand(cstr, conn);
                        SqlDataReader dr = comm.ExecuteReader();
                        if (dr.Read())
                        {
                            ID = txtname.Text.Trim();
                            admin mainform = new admin(ID);
                            mainform.Show();
                            this.Hide();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("输入有误，请重新输入！");
                            txtname.Text = ""; txtpassword.Text = "";
                        }
                    }

                    else
                    {
                        if (EmployeeRB.Checked)
                        {
                            string cstr2 = "select * from Employee where EmpID='" + txtname.Text.Trim() + "'and password='" + txtpassword.Text.Trim() + "'";
                            SqlCommand comm2 = new SqlCommand(cstr2, conn);
                            SqlDataReader dr2 = comm2.ExecuteReader();
                            if (dr2.Read())
                            {
                                ID = txtname.Text.Trim();
                                Employee mainform = new Employee(ID);
                                mainform.Show();
                                this.Hide();
                                conn.Close();
                            }
                            else
                            {
                                MessageBox.Show("输入有误，请重新输入！");
                                txtname.Text = ""; txtpassword.Text = "";
                            }
                        }
                    }
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }





    }
}

