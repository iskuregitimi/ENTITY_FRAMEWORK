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
            this.lbl_FrsName = new System.Windows.Forms.Label();
            this.lbl_MidName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_JobTitle = new System.Windows.Forms.Label();
            this.dgv_Phone = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phone)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FrsName
            // 
            this.lbl_FrsName.AutoSize = true;
            this.lbl_FrsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_FrsName.Location = new System.Drawing.Point(50, 40);
            this.lbl_FrsName.Name = "lbl_FrsName";
            this.lbl_FrsName.Size = new System.Drawing.Size(101, 25);
            this.lbl_FrsName.TabIndex = 0;
            this.lbl_FrsName.Text = "FirstName";
            // 
            // lbl_MidName
            // 
            this.lbl_MidName.AutoSize = true;
            this.lbl_MidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_MidName.Location = new System.Drawing.Point(40, 84);
            this.lbl_MidName.Name = "lbl_MidName";
            this.lbl_MidName.Size = new System.Drawing.Size(122, 25);
            this.lbl_MidName.TabIndex = 1;
            this.lbl_MidName.Text = "MiddleName";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_LastName.Location = new System.Drawing.Point(50, 132);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(101, 25);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "LastName";
            // 
            // lbl_JobTitle
            // 
            this.lbl_JobTitle.AutoSize = true;
            this.lbl_JobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_JobTitle.Location = new System.Drawing.Point(60, 180);
            this.lbl_JobTitle.Name = "lbl_JobTitle";
            this.lbl_JobTitle.Size = new System.Drawing.Size(82, 25);
            this.lbl_JobTitle.TabIndex = 3;
            this.lbl_JobTitle.Text = "JobTitle";
            // 
            // dgv_Phone
            // 
            this.dgv_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phone.Location = new System.Drawing.Point(12, 254);
            this.dgv_Phone.Name = "dgv_Phone";
            this.dgv_Phone.Size = new System.Drawing.Size(776, 184);
            this.dgv_Phone.TabIndex = 4;
            // 
            // dlg_PersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 470);
            this.Controls.Add(this.dgv_Phone);
            this.Controls.Add(this.lbl_JobTitle);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_MidName);
            this.Controls.Add(this.lbl_FrsName);
            this.Name = "dlg_PersonelDetay";
            this.Text = "dlg_PersonelDetay";
            this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FrsName;
        private System.Windows.Forms.Label lbl_MidName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_JobTitle;
        private System.Windows.Forms.DataGridView dgv_Phone;
    }
}