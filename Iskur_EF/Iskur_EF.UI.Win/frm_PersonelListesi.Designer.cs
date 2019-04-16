namespace Iskur_EF.UI.Win
{
    partial class frm_PersonelListesi
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
            this.dgvPersonelListesi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personelDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonelListesi
            // 
            this.dgvPersonelListesi.AllowUserToAddRows = false;
            this.dgvPersonelListesi.AllowUserToDeleteRows = false;
            this.dgvPersonelListesi.AllowUserToOrderColumns = true;
            this.dgvPersonelListesi.AllowUserToResizeRows = false;
            this.dgvPersonelListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonelListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPersonelListesi.Location = new System.Drawing.Point(9, 32);
            this.dgvPersonelListesi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersonelListesi.Name = "dgvPersonelListesi";
            this.dgvPersonelListesi.RowTemplate.Height = 24;
            this.dgvPersonelListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonelListesi.Size = new System.Drawing.Size(582, 323);
            this.dgvPersonelListesi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelDetayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // personelDetayToolStripMenuItem
            // 
            this.personelDetayToolStripMenuItem.Name = "personelDetayToolStripMenuItem";
            this.personelDetayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personelDetayToolStripMenuItem.Text = "Personel Detay";
            this.personelDetayToolStripMenuItem.Click += new System.EventHandler(this.personelDetayToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(9, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 20);
            this.textBox1.TabIndex = 1;
            // 
            // frm_PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvPersonelListesi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_PersonelListesi";
            this.Text = "frm_PersonelListesi";
            this.Load += new System.EventHandler(this.frm_PersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonelListesi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelDetayToolStripMenuItem;
    }
}