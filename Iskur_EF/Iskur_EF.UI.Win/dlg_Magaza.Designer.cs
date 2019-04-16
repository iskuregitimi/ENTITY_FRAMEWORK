namespace Iskur_EF.UI.Win
{
    partial class dlg_Magaza
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
            this.dgv_Magaza = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.satışPersoneliGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Magaza)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Magaza
            // 
            this.dgv_Magaza.AllowUserToAddRows = false;
            this.dgv_Magaza.AllowUserToDeleteRows = false;
            this.dgv_Magaza.AllowUserToOrderColumns = true;
            this.dgv_Magaza.AllowUserToResizeRows = false;
            this.dgv_Magaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Magaza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Magaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Magaza.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Magaza.Location = new System.Drawing.Point(12, 59);
            this.dgv_Magaza.Name = "dgv_Magaza";
            this.dgv_Magaza.Size = new System.Drawing.Size(705, 370);
            this.dgv_Magaza.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışPersoneliGösterToolStripMenuItem,
            this.satışDetayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 48);
            // 
            // satışPersoneliGösterToolStripMenuItem
            // 
            this.satışPersoneliGösterToolStripMenuItem.Name = "satışPersoneliGösterToolStripMenuItem";
            this.satışPersoneliGösterToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.satışPersoneliGösterToolStripMenuItem.Text = "Satış Personeli Göster";
            this.satışPersoneliGösterToolStripMenuItem.Click += new System.EventHandler(this.satışPersoneliGösterToolStripMenuItem_Click);
            // 
            // satışDetayToolStripMenuItem
            // 
            this.satışDetayToolStripMenuItem.Name = "satışDetayToolStripMenuItem";
            this.satışDetayToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.satışDetayToolStripMenuItem.Text = "Satış Detay";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(705, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dlg_Magaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_Magaza);
            this.Name = "dlg_Magaza";
            this.Text = "dlg_Magaza";
            this.Load += new System.EventHandler(this.dlg_Magaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Magaza)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Magaza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satışPersoneliGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışDetayToolStripMenuItem;
    }
}