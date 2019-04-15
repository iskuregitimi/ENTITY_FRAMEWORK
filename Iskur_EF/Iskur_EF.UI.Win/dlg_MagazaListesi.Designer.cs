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
            this.dgv_magazalistesi = new System.Windows.Forms.DataGridView();
            this.txt_Magaza = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magazalistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_magazalistesi
            // 
            this.dgv_magazalistesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_magazalistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_magazalistesi.Location = new System.Drawing.Point(3, 28);
            this.dgv_magazalistesi.Name = "dgv_magazalistesi";
            this.dgv_magazalistesi.Size = new System.Drawing.Size(793, 410);
            this.dgv_magazalistesi.TabIndex = 0;
            // 
            // txt_Magaza
            // 
            this.txt_Magaza.Location = new System.Drawing.Point(3, 2);
            this.txt_Magaza.Name = "txt_Magaza";
            this.txt_Magaza.Size = new System.Drawing.Size(793, 20);
            this.txt_Magaza.TabIndex = 1;
            this.txt_Magaza.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dlg_MagazaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.txt_Magaza);
            this.Controls.Add(this.dgv_magazalistesi);
            this.Name = "dlg_MagazaListesi";
            this.Text = "dlg_MagazaListesi";
            this.Load += new System.EventHandler(this.dlg_MagazaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magazalistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_magazalistesi;
        private System.Windows.Forms.TextBox txt_Magaza;
    }
}