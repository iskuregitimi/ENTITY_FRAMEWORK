namespace Iskur_EF.UI.Win
{
    partial class dlg_siparisDetails
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
            this.dvg_siparisdetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_siparisdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_siparisdetails
            // 
            this.dvg_siparisdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_siparisdetails.Location = new System.Drawing.Point(43, 101);
            this.dvg_siparisdetails.Name = "dvg_siparisdetails";
            this.dvg_siparisdetails.Size = new System.Drawing.Size(713, 337);
            this.dvg_siparisdetails.TabIndex = 0;
            // 
            // dlg_siparisDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvg_siparisdetails);
            this.Name = "dlg_siparisDetails";
            this.Text = "dlg_siparisDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_siparisdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_siparisdetails;
    }
}