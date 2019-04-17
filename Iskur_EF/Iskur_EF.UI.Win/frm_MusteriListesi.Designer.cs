namespace Iskur_EF.UI.Win
{
    partial class frm_MusteriListesi
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
            this.dgv_musterilistesi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSiparişEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musterilistesi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_musterilistesi
            // 
            this.dgv_musterilistesi.AllowUserToAddRows = false;
            this.dgv_musterilistesi.AllowUserToDeleteRows = false;
            this.dgv_musterilistesi.AllowUserToOrderColumns = true;
            this.dgv_musterilistesi.AllowUserToResizeRows = false;
            this.dgv_musterilistesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_musterilistesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_musterilistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musterilistesi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_musterilistesi.Location = new System.Drawing.Point(27, 39);
            this.dgv_musterilistesi.Name = "dgv_musterilistesi";
            this.dgv_musterilistesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_musterilistesi.Size = new System.Drawing.Size(743, 376);
            this.dgv_musterilistesi.TabIndex = 0;
            this.dgv_musterilistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_musterilistesi_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişlerToolStripMenuItem,
            this.yeniSiparişEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // yeniSiparişEkleToolStripMenuItem
            // 
            this.yeniSiparişEkleToolStripMenuItem.Name = "yeniSiparişEkleToolStripMenuItem";
            this.yeniSiparişEkleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.yeniSiparişEkleToolStripMenuItem.Text = "Yeni Sipariş Ekle";
            this.yeniSiparişEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniSiparişEkleToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(743, 20);
            this.textBox1.TabIndex = 1;
            // 
            // frm_MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_musterilistesi);
            this.Name = "frm_MusteriListesi";
            this.Text = "frm_MusteriListesi";
            this.Load += new System.EventHandler(this.frm_MusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musterilistesi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_musterilistesi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSiparişEkleToolStripMenuItem;
    }
}