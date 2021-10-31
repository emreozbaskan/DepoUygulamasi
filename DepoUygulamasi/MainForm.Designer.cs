
namespace DepoUygulamasi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.depoİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişÇıkışİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depolarArasıTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depoİşlemleriToolStripMenuItem,
            this.girişÇıkışİşlemleriToolStripMenuItem1,
            this.transferİşlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // depoİşlemleriToolStripMenuItem
            // 
            this.depoİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniDepoToolStripMenuItem,
            this.depoListesiToolStripMenuItem});
            this.depoİşlemleriToolStripMenuItem.Name = "depoİşlemleriToolStripMenuItem";
            this.depoİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.depoİşlemleriToolStripMenuItem.Text = "Depo İşlemleri";
            // 
            // yeniDepoToolStripMenuItem
            // 
            this.yeniDepoToolStripMenuItem.Name = "yeniDepoToolStripMenuItem";
            this.yeniDepoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniDepoToolStripMenuItem.Text = "Yeni Depo";
            this.yeniDepoToolStripMenuItem.Click += new System.EventHandler(this.yeniDepoToolStripMenuItem_Click);
            // 
            // depoListesiToolStripMenuItem
            // 
            this.depoListesiToolStripMenuItem.Name = "depoListesiToolStripMenuItem";
            this.depoListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.depoListesiToolStripMenuItem.Text = "Depo Listesi";
            this.depoListesiToolStripMenuItem.Click += new System.EventHandler(this.depoListesiToolStripMenuItem_Click);
            // 
            // girişÇıkışİşlemleriToolStripMenuItem1
            // 
            this.girişÇıkışİşlemleriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışİşlemiToolStripMenuItem,
            this.girişİşlemiToolStripMenuItem});
            this.girişÇıkışİşlemleriToolStripMenuItem1.Name = "girişÇıkışİşlemleriToolStripMenuItem1";
            this.girişÇıkışİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(117, 20);
            this.girişÇıkışİşlemleriToolStripMenuItem1.Text = "Giriş Çıkış İşlemleri";
            // 
            // çıkışİşlemiToolStripMenuItem
            // 
            this.çıkışİşlemiToolStripMenuItem.Name = "çıkışİşlemiToolStripMenuItem";
            this.çıkışİşlemiToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.çıkışİşlemiToolStripMenuItem.Text = "Çıkış İşlemi";
            // 
            // girişİşlemiToolStripMenuItem
            // 
            this.girişİşlemiToolStripMenuItem.Name = "girişİşlemiToolStripMenuItem";
            this.girişİşlemiToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.girişİşlemiToolStripMenuItem.Text = "Giriş İşlemi";
            // 
            // transferİşlemleriToolStripMenuItem
            // 
            this.transferİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depolarArasıTransferToolStripMenuItem});
            this.transferİşlemleriToolStripMenuItem.Name = "transferİşlemleriToolStripMenuItem";
            this.transferİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.transferİşlemleriToolStripMenuItem.Text = "Transfer İşlemleri";
            // 
            // depolarArasıTransferToolStripMenuItem
            // 
            this.depolarArasıTransferToolStripMenuItem.Name = "depolarArasıTransferToolStripMenuItem";
            this.depolarArasıTransferToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.depolarArasıTransferToolStripMenuItem.Text = "Depolar Arası Transfer";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 603);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Uygulamasi V1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depoİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişÇıkışİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transferİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniDepoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depolarArasıTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoListesiToolStripMenuItem;
    }
}

