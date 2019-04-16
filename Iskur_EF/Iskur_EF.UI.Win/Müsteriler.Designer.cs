namespace Iskur_EF.UI.Win
{
    partial class Müsteriler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparisDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.siparisVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisDetayToolStripMenuItem,
            this.siparisVerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // siparisDetayToolStripMenuItem
            // 
            this.siparisDetayToolStripMenuItem.Name = "siparisDetayToolStripMenuItem";
            this.siparisDetayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.siparisDetayToolStripMenuItem.Text = "Siparis Detay";
            this.siparisDetayToolStripMenuItem.Click += new System.EventHandler(this.siparisDetayToolStripMenuItem_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 28);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(625, 20);
            this.txt_search.TabIndex = 1;
            // 
            // siparisVerToolStripMenuItem
            // 
            this.siparisVerToolStripMenuItem.Name = "siparisVerToolStripMenuItem";
            this.siparisVerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.siparisVerToolStripMenuItem.Text = "Siparis Ver";
            this.siparisVerToolStripMenuItem.Click += new System.EventHandler(this.siparisVerToolStripMenuItem_Click);
            // 
            // Müsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 354);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Müsteriler";
            this.Text = "Müsteriler";
            this.Load += new System.EventHandler(this.Müsteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisDetayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisVerToolStripMenuItem;
    }
}