namespace Iskur_EF.UI.Win
{
    partial class SiparisDetail
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
            this.dgv_siparisDetail = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparişDetayiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siparisDetail)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_siparisDetail
            // 
            this.dgv_siparisDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_siparisDetail.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_siparisDetail.Location = new System.Drawing.Point(12, 84);
            this.dgv_siparisDetail.Name = "dgv_siparisDetail";
            this.dgv_siparisDetail.Size = new System.Drawing.Size(445, 266);
            this.dgv_siparisDetail.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişDetayiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 26);
            // 
            // siparişDetayiToolStripMenuItem
            // 
            this.siparişDetayiToolStripMenuItem.Name = "siparişDetayiToolStripMenuItem";
            this.siparişDetayiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.siparişDetayiToolStripMenuItem.Text = "sipariş detayi";
            this.siparişDetayiToolStripMenuItem.Click += new System.EventHandler(this.siparişDetayiToolStripMenuItem_Click);
            // 
            // SiparisDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 362);
            this.Controls.Add(this.dgv_siparisDetail);
            this.Name = "SiparisDetail";
            this.Text = "SiparisDetail";
            this.Load += new System.EventHandler(this.SiparisDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siparisDetail)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_siparisDetail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişDetayiToolStripMenuItem;
    }
}