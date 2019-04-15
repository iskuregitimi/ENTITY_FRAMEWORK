namespace Iskur_EF.UI.Win
{
    partial class dlg_Sales
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
            this.dgv_store = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.storeDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_store
            // 
            this.dgv_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_store.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_store.Location = new System.Drawing.Point(61, 44);
            this.dgv_store.Name = "dgv_store";
            this.dgv_store.Size = new System.Drawing.Size(606, 361);
            this.dgv_store.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeDetayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // storeDetayToolStripMenuItem
            // 
            this.storeDetayToolStripMenuItem.Name = "storeDetayToolStripMenuItem";
            this.storeDetayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.storeDetayToolStripMenuItem.Text = "StoreDetay";
            this.storeDetayToolStripMenuItem.Click += new System.EventHandler(this.storeDetayToolStripMenuItem_Click);
            // 
            // dlg_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_store);
            this.Name = "dlg_Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.dlg_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_store;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem storeDetayToolStripMenuItem;
    }
}