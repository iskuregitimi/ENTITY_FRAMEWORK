namespace Iskur_EF.UI.Win
{
    partial class frm_Magazalar
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
            this.dgv_Magazalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Magazalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Magazalar
            // 
            this.dgv_Magazalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Magazalar.Location = new System.Drawing.Point(13, 13);
            this.dgv_Magazalar.Name = "dgv_Magazalar";
            this.dgv_Magazalar.Size = new System.Drawing.Size(775, 425);
            this.dgv_Magazalar.TabIndex = 0;
            // 
            // frm_Magazalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Magazalar);
            this.Name = "frm_Magazalar";
            this.Text = "frm_Magazalar";
            this.Load += new System.EventHandler(this.frm_Magazalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Magazalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Magazalar;
    }
}