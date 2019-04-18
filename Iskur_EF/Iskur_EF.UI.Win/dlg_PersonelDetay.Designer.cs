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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.txt_Middlename = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.txt_Jobtitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MiddleName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "LastName : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Job Title :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(18, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(89, 16);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(436, 20);
            this.txt_Firstname.TabIndex = 2;
            // 
            // txt_Middlename
            // 
            this.txt_Middlename.Location = new System.Drawing.Point(89, 51);
            this.txt_Middlename.Name = "txt_Middlename";
            this.txt_Middlename.Size = new System.Drawing.Size(436, 20);
            this.txt_Middlename.TabIndex = 2;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(89, 87);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(436, 20);
            this.txt_Lastname.TabIndex = 2;
            // 
            // txt_Jobtitle
            // 
            this.txt_Jobtitle.Location = new System.Drawing.Point(89, 124);
            this.txt_Jobtitle.Name = "txt_Jobtitle";
            this.txt_Jobtitle.Size = new System.Drawing.Size(436, 20);
            this.txt_Jobtitle.TabIndex = 2;
            // 
            // dlg_PersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 419);
            this.Controls.Add(this.txt_Jobtitle);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Middlename);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dlg_PersonelDetay";
            this.Text = "dlg_PersonelDetay";
            this.Load += new System.EventHandler(this.dlg_PersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.TextBox txt_Middlename;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.TextBox txt_Jobtitle;
    }
}