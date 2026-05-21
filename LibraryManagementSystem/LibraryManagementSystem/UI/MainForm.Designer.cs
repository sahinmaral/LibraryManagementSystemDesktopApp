namespace LibraryManagementSystem.UI.Mainpage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBookProcesses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBookQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonProcesses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPersonQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.adminİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özetİstatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iadesiGecikmişKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenu,
            this.menuBookProcesses,
            this.menuPersonProcesses,
            this.adminİşlemleriToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mainMenuStrip.Size = new System.Drawing.Size(1264, 29);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "Ana Menü";
            // 
            // homeMenu
            // 
            this.homeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuItem,
            this.aboutMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(149, 23);
            this.homeMenu.Text = "Anasayfa ve Diğerleri";
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.Size = new System.Drawing.Size(180, 24);
            this.homeMenuItem.Text = "Anasayfa";
            this.homeMenuItem.Click += new System.EventHandler(this.HomeMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(180, 24);
            this.aboutMenuItem.Text = "Hakkında";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // menuBookProcesses
            // 
            this.menuBookProcesses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBookQuery});
            this.menuBookProcesses.Name = "menuBookProcesses";
            this.menuBookProcesses.Size = new System.Drawing.Size(106, 23);
            this.menuBookProcesses.Text = "Kitap İşlemleri";
            // 
            // menuItemBookQuery
            // 
            this.menuItemBookQuery.Name = "menuItemBookQuery";
            this.menuItemBookQuery.Size = new System.Drawing.Size(180, 24);
            this.menuItemBookQuery.Text = "Kitap Sorgulama";
            this.menuItemBookQuery.Click += new System.EventHandler(this.MenuItemBookQuery_Click);
            // 
            // menuPersonProcesses
            // 
            this.menuPersonProcesses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPersonQuery});
            this.menuPersonProcesses.Name = "menuPersonProcesses";
            this.menuPersonProcesses.Size = new System.Drawing.Size(95, 23);
            this.menuPersonProcesses.Text = "Kişi İşlemleri";
            // 
            // menuItemPersonQuery
            // 
            this.menuItemPersonQuery.Name = "menuItemPersonQuery";
            this.menuItemPersonQuery.Size = new System.Drawing.Size(180, 24);
            this.menuItemPersonQuery.Text = "Kişi Sorgulama";
            this.menuItemPersonQuery.Click += new System.EventHandler(this.MenuItemPersonQuery_Click);
            // 
            // adminİşlemleriToolStripMenuItem
            // 
            this.adminİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminOluşturToolStripMenuItem});
            this.adminİşlemleriToolStripMenuItem.Name = "adminİşlemleriToolStripMenuItem";
            this.adminİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(115, 23);
            this.adminİşlemleriToolStripMenuItem.Text = "Admin İşlemleri";
            // 
            // adminOluşturToolStripMenuItem
            // 
            this.adminOluşturToolStripMenuItem.Name = "adminOluşturToolStripMenuItem";
            this.adminOluşturToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.adminOluşturToolStripMenuItem.Text = "Admin Oluştur";
            this.adminOluşturToolStripMenuItem.Click += new System.EventHandler(this.adminOluşturToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özetİstatistiklerToolStripMenuItem,
            this.enToolStripMenuItem,
            this.iadesiGecikmişKitaplarToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // özetİstatistiklerToolStripMenuItem
            // 
            this.özetİstatistiklerToolStripMenuItem.Name = "özetİstatistiklerToolStripMenuItem";
            this.özetİstatistiklerToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.özetİstatistiklerToolStripMenuItem.Text = "Özet İstatistikler";
            this.özetİstatistiklerToolStripMenuItem.Click += new System.EventHandler(this.özetİstatistiklerToolStripMenuItem_Click);
            // 
            // enToolStripMenuItem
            // 
            this.enToolStripMenuItem.Name = "enToolStripMenuItem";
            this.enToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.enToolStripMenuItem.Text = "En Çok Alınan 5 Kitap";
            this.enToolStripMenuItem.Click += new System.EventHandler(this.enToolStripMenuItem_Click);
            // 
            // iadesiGecikmişKitaplarToolStripMenuItem
            // 
            this.iadesiGecikmişKitaplarToolStripMenuItem.Name = "iadesiGecikmişKitaplarToolStripMenuItem";
            this.iadesiGecikmişKitaplarToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.iadesiGecikmişKitaplarToolStripMenuItem.Text = "İadesi Gecikmiş Kitaplar";
            this.iadesiGecikmişKitaplarToolStripMenuItem.Click += new System.EventHandler(this.iadesiGecikmişKitaplarToolStripMenuItem_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 29);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1264, 832);
            this.contentPanel.TabIndex = 2;
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstanbul Kütüphanesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeMenu;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBookProcesses;
        private System.Windows.Forms.ToolStripMenuItem menuPersonProcesses;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.ToolStripMenuItem menuItemPersonQuery;
        private System.Windows.Forms.ToolStripMenuItem menuItemBookQuery;
        private System.Windows.Forms.ToolStripMenuItem adminİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özetİstatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iadesiGecikmişKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}