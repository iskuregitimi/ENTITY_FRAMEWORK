namespace Iskur_EF.UI.Win
{
    partial class CustomerListesi
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
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparislerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Customer.Location = new System.Drawing.Point(12, 12);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.Size = new System.Drawing.Size(776, 426);
            this.dgv_Customer.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparislerToolStripMenuItem,
            this.siparisEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // siparislerToolStripMenuItem
            // 
            this.siparislerToolStripMenuItem.Name = "siparislerToolStripMenuItem";
            this.siparislerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparislerToolStripMenuItem.Text = "Siparisler";
            this.siparislerToolStripMenuItem.Click += new System.EventHandler(this.siparislerToolStripMenuItem_Click);
            // 
            // siparisEkleToolStripMenuItem
            // 
            this.siparisEkleToolStripMenuItem.Name = "siparisEkleToolStripMenuItem";
            this.siparisEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparisEkleToolStripMenuItem.Text = "Siparis Ekle";
            this.siparisEkleToolStripMenuItem.Click += new System.EventHandler(this.siparisEkleToolStripMenuItem_Click);
            // 
            // CustomerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Customer);
            this.Name = "CustomerListesi";
            this.Text = "CustomerListesi";
            this.Load += new System.EventHandler(this.CustomerListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparislerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisEkleToolStripMenuItem;
    }
}