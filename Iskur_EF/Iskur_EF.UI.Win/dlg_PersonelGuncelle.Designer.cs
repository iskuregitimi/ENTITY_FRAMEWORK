namespace Iskur_EF.UI.Win
{
    partial class dlg_PersonelGuncelle
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_midlename = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(137, 14);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(126, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_midlename
            // 
            this.txt_midlename.Location = new System.Drawing.Point(137, 50);
            this.txt_midlename.Name = "txt_midlename";
            this.txt_midlename.Size = new System.Drawing.Size(126, 20);
            this.txt_midlename.TabIndex = 0;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(137, 86);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(126, 20);
            this.txt_lastname.TabIndex = 0;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(137, 122);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(126, 20);
            this.txt_phonenumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "LAST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "MİDLLE NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "PHONE NUMBER";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(137, 163);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(126, 23);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Personel Guncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // dlg_PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 232);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_midlename);
            this.Controls.Add(this.txt_name);
            this.Name = "dlg_PersonelGuncelle";
            this.Text = "dlg_PersonelGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_midlename;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_guncelle;
    }
}