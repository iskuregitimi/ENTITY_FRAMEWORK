namespace Iskur_EF.UI.Win
{
    partial class dlg_MagazaListesi
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
            this.dgvPersonelMagaza = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mağazaDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelMagaza)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonelMagaza
            // 
            this.dgvPersonelMagaza.AllowUserToAddRows = false;
            this.dgvPersonelMagaza.AllowUserToDeleteRows = false;
            this.dgvPersonelMagaza.AllowUserToOrderColumns = true;
            this.dgvPersonelMagaza.AllowUserToResizeRows = false;
            this.dgvPersonelMagaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonelMagaza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonelMagaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelMagaza.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPersonelMagaza.Location = new System.Drawing.Point(25, 23);
            this.dgvPersonelMagaza.Name = "dgvPersonelMagaza";
            this.dgvPersonelMagaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonelMagaza.Size = new System.Drawing.Size(567, 301);
            this.dgvPersonelMagaza.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mağazaDetayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // mağazaDetayToolStripMenuItem
            // 
            this.mağazaDetayToolStripMenuItem.Name = "mağazaDetayToolStripMenuItem";
            this.mağazaDetayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mağazaDetayToolStripMenuItem.Text = "Mağaza Detay";
            this.mağazaDetayToolStripMenuItem.Click += new System.EventHandler(this.mağazaDetayToolStripMenuItem_Click);
            // 
            // dlg_MagazaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 336);
            this.Controls.Add(this.dgvPersonelMagaza);
            this.Name = "dlg_MagazaListesi";
            this.Text = "dlg_PersonelMagaza";
            this.Load += new System.EventHandler(this.dlg_PersonelMagaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelMagaza)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonelMagaza;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mağazaDetayToolStripMenuItem;
    }
}