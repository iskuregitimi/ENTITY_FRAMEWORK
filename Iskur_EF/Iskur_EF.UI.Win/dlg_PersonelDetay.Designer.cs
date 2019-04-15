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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_PersonelDetay = new System.Windows.Forms.DataGridView();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_MiddleName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_JobTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MiddleName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "JobTitle";
            // 
            // dgv_PersonelDetay
            // 
            this.dgv_PersonelDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonelDetay.Location = new System.Drawing.Point(37, 167);
            this.dgv_PersonelDetay.Name = "dgv_PersonelDetay";
            this.dgv_PersonelDetay.Size = new System.Drawing.Size(698, 234);
            this.dgv_PersonelDetay.TabIndex = 1;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(106, 31);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(54, 13);
            this.lbl_FirstName.TabIndex = 0;
            this.lbl_FirstName.Text = "FirstName";
            // 
            // lbl_MiddleName
            // 
            this.lbl_MiddleName.AutoSize = true;
            this.lbl_MiddleName.Location = new System.Drawing.Point(106, 65);
            this.lbl_MiddleName.Name = "lbl_MiddleName";
            this.lbl_MiddleName.Size = new System.Drawing.Size(66, 13);
            this.lbl_MiddleName.TabIndex = 0;
            this.lbl_MiddleName.Text = "MiddleName";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(106, 99);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(55, 13);
            this.lbl_LastName.TabIndex = 0;
            this.lbl_LastName.Text = "LastName";
            // 
            // lbl_JobTitle
            // 
            this.lbl_JobTitle.AutoSize = true;
            this.lbl_JobTitle.Location = new System.Drawing.Point(106, 133);
            this.lbl_JobTitle.Name = "lbl_JobTitle";
            this.lbl_JobTitle.Size = new System.Drawing.Size(44, 13);
            this.lbl_JobTitle.TabIndex = 0;
            this.lbl_JobTitle.Text = "JobTitle";
            // 
            // dlg_PersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 433);
            this.Controls.Add(this.dgv_PersonelDetay);
            this.Controls.Add(this.lbl_JobTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_MiddleName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dlg_PersonelDetay";
            this.Text = "dlg_PersonelDetay";
            this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_PersonelDetay;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_MiddleName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_JobTitle;
    }
}