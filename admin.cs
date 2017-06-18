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
    public partial class admin : Form
    { 
        //SqlConnection conn = new SqlConnection(dbConnection.connection);
        //SqlCommand cmd = new SqlCommand();
        //conn.Open();
        //SqlConnection conn = new SqlConnection(dbConnection.connection);
        private string ID;

        public admin(string ID)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.ID = ID;
        }

        private void 购买信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InfoPurchase = new InfoPurchase();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            //InfoPurchase.MdiParent = this;
            // Help.MdiParent = this;
            //InfoPurchase.WindowState = FormWindowState.Maximized;
            InfoPurchase.Show();
        }

        private void 审核购买ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PendingPurchase = new PendingPurchase();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //PendingPurchase.MdiParent = this;
            // Help.MdiParent = this;
            //PendingPurchase.WindowState = FormWindowState.Maximized;
            PendingPurchase.Show();
        }

        private void 维修信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InfoMaintain = new InfoMaintain();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //InfoMaintain.MdiParent = this;
            // Help.MdiParent = this;
            //InfoMaintain.WindowState = FormWindowState.Maximized;
            InfoMaintain.Show();
        }

        private void 转借信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InfoTransfer = new InfoTransfer();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //InfoTransfer.MdiParent = this;
            // Help.MdiParent = this;
            //InfoTransfer.WindowState = FormWindowState.Maximized;
            InfoTransfer.Show();

        }

        private void 审核转借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PendingTransfer = new PendingTransfer();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //PendingTransfer.MdiParent = this;
            // Help.MdiParent = this;
            //PendingTransfer.WindowState = FormWindowState.Maximized;
            PendingTransfer.Show();
        }

        private void 报废信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InfoScrap = new InfoScrap();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //InfoScrap.MdiParent = this;
            // Help.MdiParent = this;
            //InfoScrap.WindowState = FormWindowState.Maximized;
            InfoScrap.Show();
        }

        private void 审核报废ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PendingScrap = new PendingScrap();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //PendingScrap.MdiParent = this;
            // Help.MdiParent = this;
            //PendingScrap.WindowState = FormWindowState.Maximized;
            PendingScrap.Show();
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InfoEquipmnet = new InfoEquipmnet();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //InfoEquipmnet.MdiParent = this;
            // Help.MdiParent = this;
            //InfoEquipmnet.WindowState = FormWindowState.Maximized;
            InfoEquipmnet.Show();
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InfoEmployee = new InfoEmployee();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            //InfoEmployee.MdiParent = this;
            //// Help.MdiParent = this;
            //InfoEmployee.WindowState = FormWindowState.Maximized;
            InfoEmployee.Show();
        }

        private void 用户添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddEmployee = new AddEmployee();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            //AddEmployee.MdiParent = this;
            // Help.MdiParent = this;
            //AddEmployee.WindowState = FormWindowState.Maximized;
            AddEmployee.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
            Form mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

    }
}
