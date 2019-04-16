namespace Iskur_EF.UI.Win
{
    partial class SalesPersonDetay
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
            this.dgv_salesPerson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salesPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_salesPerson
            // 
            this.dgv_salesPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salesPerson.Location = new System.Drawing.Point(12, 95);
            this.dgv_salesPerson.Name = "dgv_salesPerson";
            this.dgv_salesPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_salesPerson.Size = new System.Drawing.Size(531, 329);
            this.dgv_salesPerson.TabIndex = 0;
            // 
            // SalesPersonDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 436);
            this.Controls.Add(this.dgv_salesPerson);
            this.Name = "SalesPersonDetay";
            this.Text = "SalesPersonDetay";
            this.Load += new System.EventHandler(this.SalesPersonDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salesPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_salesPerson;
    }
}