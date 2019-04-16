namespace Iskur_EF.UI.Win
{
    partial class Siparisler
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
            this.dgv_Siparis = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparisDetayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Siparis)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Siparis
            // 
            this.dgv_Siparis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Siparis.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Siparis.Location = new System.Drawing.Point(12, 12);
            this.dgv_Siparis.Name = "dgv_Siparis";
            this.dgv_Siparis.Size = new System.Drawing.Size(776, 426);
            this.dgv_Siparis.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisDetayıToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // siparisDetayıToolStripMenuItem
            // 
            this.siparisDetayıToolStripMenuItem.Name = "siparisDetayıToolStripMenuItem";
            this.siparisDetayıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparisDetayıToolStripMenuItem.Text = "Siparis Detayı";
            this.siparisDetayıToolStripMenuItem.Click += new System.EventHandler(this.siparisDetayıToolStripMenuItem_Click);
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Siparis);
            this.Name = "Siparisler";
            this.Text = "Siparisler";
            this.Load += new System.EventHandler(this.Siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Siparis)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Siparis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisDetayıToolStripMenuItem;
    }
}