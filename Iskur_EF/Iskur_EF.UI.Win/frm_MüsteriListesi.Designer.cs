namespace Iskur_EF.UI.Win
{
    partial class frm_MüsteriListesi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_MüsteriListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MüsteriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(11, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dgv_MüsteriListesi
            // 
            this.dgv_MüsteriListesi.AllowUserToAddRows = false;
            this.dgv_MüsteriListesi.AllowUserToDeleteRows = false;
            this.dgv_MüsteriListesi.AllowUserToOrderColumns = true;
            this.dgv_MüsteriListesi.AllowUserToResizeRows = false;
            this.dgv_MüsteriListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MüsteriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MüsteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MüsteriListesi.Location = new System.Drawing.Point(11, 43);
            this.dgv_MüsteriListesi.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_MüsteriListesi.Name = "dgv_MüsteriListesi";
            this.dgv_MüsteriListesi.RowTemplate.Height = 24;
            this.dgv_MüsteriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MüsteriListesi.Size = new System.Drawing.Size(616, 323);
            this.dgv_MüsteriListesi.TabIndex = 2;
            this.dgv_MüsteriListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MüsteriListesi_CellContentClick);
            // 
            // frm_MüsteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_MüsteriListesi);
            this.Name = "frm_MüsteriListesi";
            this.Text = "MüsteriListesi";
            this.Load += new System.EventHandler(this.frm_MüsteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MüsteriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_MüsteriListesi;
    }
}