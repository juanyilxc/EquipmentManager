namespace EquipmentManager
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.提交购买记录ToolStripMenuItem_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.提交转借记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提交维修记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提交报废记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.提交购买记录ToolStripMenuItem_Click,
            this.提交转借记录ToolStripMenuItem,
            this.提交维修记录ToolStripMenuItem,
            this.提交报废记录ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 提交购买记录ToolStripMenuItem_Click
            // 
            this.提交购买记录ToolStripMenuItem_Click.Name = "提交购买记录ToolStripMenuItem_Click";
            this.提交购买记录ToolStripMenuItem_Click.Size = new System.Drawing.Size(111, 24);
            this.提交购买记录ToolStripMenuItem_Click.Text = "提交购买记录";
            this.提交购买记录ToolStripMenuItem_Click.Click += new System.EventHandler(this.提交购买记录ToolStripMenuItem_Click_Click);
            // 
            // 提交转借记录ToolStripMenuItem
            // 
            this.提交转借记录ToolStripMenuItem.Name = "提交转借记录ToolStripMenuItem";
            this.提交转借记录ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.提交转借记录ToolStripMenuItem.Text = "提交转借记录";
            this.提交转借记录ToolStripMenuItem.Click += new System.EventHandler(this.提交转借记录ToolStripMenuItem_Click);
            // 
            // 提交维修记录ToolStripMenuItem
            // 
            this.提交维修记录ToolStripMenuItem.Name = "提交维修记录ToolStripMenuItem";
            this.提交维修记录ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.提交维修记录ToolStripMenuItem.Text = "提交维修记录";
            this.提交维修记录ToolStripMenuItem.Click += new System.EventHandler(this.提交维修记录ToolStripMenuItem_Click);
            // 
            // 提交报废记录ToolStripMenuItem
            // 
            this.提交报废记录ToolStripMenuItem.Name = "提交报废记录ToolStripMenuItem";
            this.提交报废记录ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.提交报废记录ToolStripMenuItem.Text = "提交报废记录";
            this.提交报废记录ToolStripMenuItem.Click += new System.EventHandler(this.提交报废记录ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 253);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee";
            this.Text = "Employee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 提交购买记录ToolStripMenuItem_Click;
        private System.Windows.Forms.ToolStripMenuItem 提交转借记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提交维修记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提交报废记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}