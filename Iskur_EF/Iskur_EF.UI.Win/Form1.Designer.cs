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
            this.personDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterileriGetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.storeGösterToolStripMenuItem,
            this.müşterileriGetirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListesiToolStripMenuItem,
            this.personDetailToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // personDetailToolStripMenuItem
            // 
            this.personDetailToolStripMenuItem.Name = "personDetailToolStripMenuItem";
            this.personDetailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personDetailToolStripMenuItem.Text = "PersonDetail";
            this.personDetailToolStripMenuItem.Click += new System.EventHandler(this.personDetailToolStripMenuItem_Click);
            // 
            // storeGösterToolStripMenuItem
            // 
            this.storeGösterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeSalesToolStripMenuItem});
            this.storeGösterToolStripMenuItem.Name = "storeGösterToolStripMenuItem";
            this.storeGösterToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.storeGösterToolStripMenuItem.Text = "Store Göster";
            this.storeGösterToolStripMenuItem.Click += new System.EventHandler(this.storeGösterToolStripMenuItem_Click);
            // 
            // storeSalesToolStripMenuItem
            // 
            this.storeSalesToolStripMenuItem.Name = "storeSalesToolStripMenuItem";
            this.storeSalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.storeSalesToolStripMenuItem.Text = "Store Sales";
            this.storeSalesToolStripMenuItem.Click += new System.EventHandler(this.storeSalesToolStripMenuItem_Click);
            // 
            // müşterileriGetirToolStripMenuItem
            // 
            this.müşterileriGetirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem});
            this.müşterileriGetirToolStripMenuItem.Name = "müşterileriGetirToolStripMenuItem";
            this.müşterileriGetirToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.müşterileriGetirToolStripMenuItem.Text = "Müşterileri getir";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 582);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Personel V2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterileriGetirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
    }
}

