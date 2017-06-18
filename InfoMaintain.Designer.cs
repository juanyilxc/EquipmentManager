namespace EquipmentManager
{
    partial class InfoMaintain
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
            this.components = new System.ComponentModel.Container();
            //this.maintainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //((System.ComponentModel.ISupportInitialize)(this.maintainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maintainBindingSource
            // 
            //this.maintainBindingSource.DataMember = "Maintain";
            // 
            // InfoMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 289);
            this.Name = "InfoMaintain";
            this.Text = "InfoMaintain";
            this.Load += new System.EventHandler(this.InfoMaintain_Load);
            //((System.ComponentModel.ISupportInitialize)(this.maintainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      
        //private System.Windows.Forms.BindingSource maintainBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn mDateDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
    }
}