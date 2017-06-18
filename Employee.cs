using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EquipmentManager
{
    public partial class Employee : Form
    {
        public String EmpID;
        public Employee(String EmployeeID)
        {
            InitializeComponent();
            EmpID = EmployeeID;
        }

        private void 提交购买记录ToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            AddPurchse AddPurchse = new AddPurchse();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //AddPurchse.MdiParent = this;
            // Help.MdiParent = this;
            //AddPurchse.WindowState = FormWindowState.Maximized;
            AddPurchse.Show();
        }

        private void 提交转借记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTransfer AddTransfer = new AddTransfer();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //AddTransfer.MdiParent = this;
            // Help.MdiParent = this;
            //AddTransfer.WindowState = FormWindowState.Maximized;
            AddTransfer.Show();

        }

        private void 提交维修记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMaintain AddMaintain = new AddMaintain();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //AddMaintain.MdiParent = this;
            // Help.MdiParent = this;
            //AddMaintain.WindowState = FormWindowState.Maximized;
            AddMaintain.Show();
        }

        private void 提交报废记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddScrap = new AddScrap();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //AddScrap.MdiParent = this;
            // Help.MdiParent = this;
            //AddScrap.WindowState = FormWindowState.Maximized;
            AddScrap.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

    }
}
