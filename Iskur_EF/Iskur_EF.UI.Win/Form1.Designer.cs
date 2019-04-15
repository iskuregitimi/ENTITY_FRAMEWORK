namespace Iskur_EF.UI.Win
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazaLİstesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musterileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.magazaToolStripMenuItem,
            this.musterilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListesiToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // magazaToolStripMenuItem
            // 
            this.magazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magazaLİstesiToolStripMenuItem});
            this.magazaToolStripMenuItem.Name = "magazaToolStripMenuItem";
            this.magazaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.magazaToolStripMenuItem.Text = "Magaza";
            // 
            // magazaLİstesiToolStripMenuItem
            // 
            this.magazaLİstesiToolStripMenuItem.Name = "magazaLİstesiToolStripMenuItem";
            this.magazaLİstesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.magazaLİstesiToolStripMenuItem.Text = "Magaza Lİstesi";
            this.magazaLİstesiToolStripMenuItem.Click += new System.EventHandler(this.magazaLİstesiToolStripMenuItem_Click);
            // 
            // musterilerToolStripMenuItem
            // 
            this.musterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musterileriListeleToolStripMenuItem});
            this.musterilerToolStripMenuItem.Name = "musterilerToolStripMenuItem";
            this.musterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.musterilerToolStripMenuItem.Text = "Musteriler";
            // 
            // musterileriListeleToolStripMenuItem
            // 
            this.musterileriListeleToolStripMenuItem.Name = "musterileriListeleToolStripMenuItem";
            this.musterileriListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musterileriListeleToolStripMenuItem.Text = "Müsteri Listesi";
            this.musterileriListeleToolStripMenuItem.Click += new System.EventHandler(this.musterileriListeleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 582);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Personel V2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazaLİstesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musterileriListeleToolStripMenuItem;
    }
}

