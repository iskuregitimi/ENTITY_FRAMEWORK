namespace Iskur_EF.UI.Win
{
    partial class frm_PersonelGüncelle
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
            this.txt_Jobtitle = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.txt_Middlename = new System.Windows.Forms.TextBox();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PersonelGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Jobtitle
            // 
            this.txt_Jobtitle.Location = new System.Drawing.Point(114, 120);
            this.txt_Jobtitle.Name = "txt_Jobtitle";
            this.txt_Jobtitle.Size = new System.Drawing.Size(436, 20);
            this.txt_Jobtitle.TabIndex = 8;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(114, 83);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(436, 20);
            this.txt_Lastname.TabIndex = 9;
            // 
            // txt_Middlename
            // 
            this.txt_Middlename.Location = new System.Drawing.Point(114, 47);
            this.txt_Middlename.Name = "txt_Middlename";
            this.txt_Middlename.Size = new System.Drawing.Size(436, 20);
            this.txt_Middlename.TabIndex = 10;
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(114, 12);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(436, 20);
            this.txt_Firstname.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 170);
            this.dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job Title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LastName : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MiddleName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Firstname :";
            // 
            // btn_PersonelGüncelle
            // 
            this.btn_PersonelGüncelle.Location = new System.Drawing.Point(447, 351);
            this.btn_PersonelGüncelle.Name = "btn_PersonelGüncelle";
            this.btn_PersonelGüncelle.Size = new System.Drawing.Size(103, 23);
            this.btn_PersonelGüncelle.TabIndex = 12;
            this.btn_PersonelGüncelle.Text = "Güncelle";
            this.btn_PersonelGüncelle.UseVisualStyleBackColor = true;
            this.btn_PersonelGüncelle.Click += new System.EventHandler(this.btn_PersonelGüncelle_Click);
            // 
            // frm_PersonelGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 402);
            this.Controls.Add(this.btn_PersonelGüncelle);
            this.Controls.Add(this.txt_Jobtitle);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Middlename);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_PersonelGüncelle";
            this.Text = "PersonelGüncelle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Jobtitle;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.TextBox txt_Middlename;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PersonelGüncelle;
    }
}