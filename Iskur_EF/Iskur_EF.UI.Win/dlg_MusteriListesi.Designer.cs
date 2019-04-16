namespace Iskur_EF.UI.Win
{
    partial class dlg_MusteriListesi
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
            this.dgvMusteriListesi = new System.Windows.Forms.DataGridView();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMusteriListesi
            // 
            this.dgvMusteriListesi.AllowUserToAddRows = false;
            this.dgvMusteriListesi.AllowUserToDeleteRows = false;
            this.dgvMusteriListesi.AllowUserToResizeRows = false;
            this.dgvMusteriListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusteriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMusteriListesi.Location = new System.Drawing.Point(21, 47);
            this.dgvMusteriListesi.Name = "dgvMusteriListesi";
            this.dgvMusteriListesi.ReadOnly = true;
            this.dgvMusteriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriListesi.Size = new System.Drawing.Size(682, 301);
            this.dgvMusteriListesi.TabIndex = 0;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(21, 12);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(682, 20);
            this.txtMusteriAdi.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişlerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // dlg_MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 360);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.dgvMusteriListesi);
            this.Name = "dlg_MusteriListesi";
            this.Text = "dlg_MusteriListesi";
            this.Load += new System.EventHandler(this.dlg_MusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriListesi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
    }
}