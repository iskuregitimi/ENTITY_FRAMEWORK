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
            this.dgv_PersonelListesi = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personelDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelListesi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PersonelListesi
            // 
            this.dgv_PersonelListesi.AllowUserToAddRows = false;
            this.dgv_PersonelListesi.AllowUserToDeleteRows = false;
            this.dgv_PersonelListesi.AllowUserToOrderColumns = true;
            this.dgv_PersonelListesi.AllowUserToResizeRows = false;
            this.dgv_PersonelListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PersonelListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonelListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_PersonelListesi.Location = new System.Drawing.Point(9, 32);
            this.dgv_PersonelListesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_PersonelListesi.Name = "dgv_PersonelListesi";
            this.dgv_PersonelListesi.RowTemplate.Height = 24;
            this.dgv_PersonelListesi.Size = new System.Drawing.Size(582, 323);
            this.dgv_PersonelListesi.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(9, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelDetayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // personelDetayToolStripMenuItem
            // 
            this.personelDetayToolStripMenuItem.Name = "personelDetayToolStripMenuItem";
            this.personelDetayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelDetayToolStripMenuItem.Text = "Personel Detay";
            this.personelDetayToolStripMenuItem.Click += new System.EventHandler(this.personelDetayToolStripMenuItem_Click);
            // 
            // frm_PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_PersonelListesi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_PersonelListesi";
            this.Text = "frm_PersonelListesi";
            this.Load += new System.EventHandler(this.frm_PersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelListesi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PersonelListesi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelDetayToolStripMenuItem;
    }
}