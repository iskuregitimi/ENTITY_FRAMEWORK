namespace Iskur_EF.UI.Win
{
    partial class frm_magazalistesi
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
            this.dgv_magaza = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salesPersonDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magaza)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_magaza
            // 
            this.dgv_magaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_magaza.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_magaza.Location = new System.Drawing.Point(12, 87);
            this.dgv_magaza.Name = "dgv_magaza";
            this.dgv_magaza.Size = new System.Drawing.Size(575, 322);
            this.dgv_magaza.TabIndex = 0;
            this.dgv_magaza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_magaza_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesPersonDetayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 48);
            // 
            // salesPersonDetayToolStripMenuItem
            // 
            this.salesPersonDetayToolStripMenuItem.Name = "salesPersonDetayToolStripMenuItem";
            this.salesPersonDetayToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.salesPersonDetayToolStripMenuItem.Text = "Sales Person Detay";
            this.salesPersonDetayToolStripMenuItem.Click += new System.EventHandler(this.salesPersonDetayToolStripMenuItem_Click);
            // 
            // frm_magazalistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 421);
            this.Controls.Add(this.dgv_magaza);
            this.Name = "frm_magazalistesi";
            this.Text = "frm_magazalistesi";
            this.Load += new System.EventHandler(this.frm_magazalistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magaza)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_magaza;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salesPersonDetayToolStripMenuItem;
    }
}