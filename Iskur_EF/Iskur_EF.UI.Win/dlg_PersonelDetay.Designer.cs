namespace Iskur_EF.UI.Win
{
    partial class dlg_PersonelDetay
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
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_middlename = new System.Windows.Forms.Label();
            this.lbl_JobTitle = new System.Windows.Forms.Label();
            this.dgv_PersonelDetay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(51, 63);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(54, 13);
            this.lbl_firstname.TabIndex = 0;
            this.lbl_firstname.Text = "FirstName";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(51, 103);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(55, 13);
            this.lbl_lastname.TabIndex = 1;
            this.lbl_lastname.Text = "LastName";
            // 
            // lbl_middlename
            // 
            this.lbl_middlename.AutoSize = true;
            this.lbl_middlename.Location = new System.Drawing.Point(51, 145);
            this.lbl_middlename.Name = "lbl_middlename";
            this.lbl_middlename.Size = new System.Drawing.Size(66, 13);
            this.lbl_middlename.TabIndex = 2;
            this.lbl_middlename.Text = "MiddleName";
            // 
            // lbl_JobTitle
            // 
            this.lbl_JobTitle.AutoSize = true;
            this.lbl_JobTitle.Location = new System.Drawing.Point(51, 186);
            this.lbl_JobTitle.Name = "lbl_JobTitle";
            this.lbl_JobTitle.Size = new System.Drawing.Size(44, 13);
            this.lbl_JobTitle.TabIndex = 4;
            this.lbl_JobTitle.Text = "JobTitle";
            // 
            // dgv_PersonelDetay
            // 
            this.dgv_PersonelDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonelDetay.Location = new System.Drawing.Point(42, 258);
            this.dgv_PersonelDetay.Name = "dgv_PersonelDetay";
            this.dgv_PersonelDetay.Size = new System.Drawing.Size(726, 150);
            this.dgv_PersonelDetay.TabIndex = 5;
            // 
            // dlg_PersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_PersonelDetay);
            this.Controls.Add(this.lbl_JobTitle);
            this.Controls.Add(this.lbl_middlename);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Name = "dlg_PersonelDetay";
            this.Text = "dlg_PersonelDetay";
            this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_middlename;
        private System.Windows.Forms.Label lbl_JobTitle;
        private System.Windows.Forms.DataGridView dgv_PersonelDetay;
    }
}