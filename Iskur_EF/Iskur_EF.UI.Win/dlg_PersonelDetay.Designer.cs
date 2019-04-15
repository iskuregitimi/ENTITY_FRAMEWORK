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
            this.lbl_jobtitle = new System.Windows.Forms.Label();
            this.lbl_middlename = new System.Windows.Forms.Label();
            this.dgv_PhoneNumbers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhoneNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_firstname.Location = new System.Drawing.Point(12, 9);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(90, 20);
            this.lbl_firstname.TabIndex = 0;
            this.lbl_firstname.Text = "First Name:";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lastname.Location = new System.Drawing.Point(12, 70);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(90, 20);
            this.lbl_lastname.TabIndex = 1;
            this.lbl_lastname.Text = "Last Name:";
            // 
            // lbl_jobtitle
            // 
            this.lbl_jobtitle.AutoSize = true;
            this.lbl_jobtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_jobtitle.Location = new System.Drawing.Point(12, 101);
            this.lbl_jobtitle.Name = "lbl_jobtitle";
            this.lbl_jobtitle.Size = new System.Drawing.Size(72, 20);
            this.lbl_jobtitle.TabIndex = 2;
            this.lbl_jobtitle.Text = "Job Title:";
            // 
            // lbl_middlename
            // 
            this.lbl_middlename.AutoSize = true;
            this.lbl_middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_middlename.Location = new System.Drawing.Point(12, 38);
            this.lbl_middlename.Name = "lbl_middlename";
            this.lbl_middlename.Size = new System.Drawing.Size(105, 20);
            this.lbl_middlename.TabIndex = 3;
            this.lbl_middlename.Text = "Middle Name:";
            // 
            // dgv_PhoneNumbers
            // 
            this.dgv_PhoneNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhoneNumbers.Location = new System.Drawing.Point(16, 139);
            this.dgv_PhoneNumbers.Name = "dgv_PhoneNumbers";
            this.dgv_PhoneNumbers.Size = new System.Drawing.Size(772, 286);
            this.dgv_PhoneNumbers.TabIndex = 4;
            // 
            // dlg_PersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_PhoneNumbers);
            this.Controls.Add(this.lbl_middlename);
            this.Controls.Add(this.lbl_jobtitle);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Name = "dlg_PersonelDetay";
            this.Text = "dlg_PersonelDetay";
            this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhoneNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_firstname;
        public System.Windows.Forms.Label lbl_lastname;
        public System.Windows.Forms.Label lbl_jobtitle;
        public System.Windows.Forms.Label lbl_middlename;
        private System.Windows.Forms.DataGridView dgv_PhoneNumbers;
    }
}