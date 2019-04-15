namespace Iskur_EF.UI.Win
{
    partial class Siparişler_genel_
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
            this.dgv_siparis = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparişDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siparis)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_siparis
            // 
            this.dgv_siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_siparis.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_siparis.Location = new System.Drawing.Point(48, 115);
            this.dgv_siparis.Name = "dgv_siparis";
            this.dgv_siparis.Size = new System.Drawing.Size(647, 299);
            this.dgv_siparis.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişDetailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // siparişDetailToolStripMenuItem
            // 
            this.siparişDetailToolStripMenuItem.Name = "siparişDetailToolStripMenuItem";
            this.siparişDetailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişDetailToolStripMenuItem.Text = "SiparişDetail";
            this.siparişDetailToolStripMenuItem.Click += new System.EventHandler(this.siparişDetailToolStripMenuItem_Click);
            // 
            // Siparişler_genel_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_siparis);
            this.Name = "Siparişler_genel_";
            this.Text = "Siparişler_genel_";
            this.Load += new System.EventHandler(this.Siparişler_genel__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siparis)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_siparis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişDetailToolStripMenuItem;
    }
}