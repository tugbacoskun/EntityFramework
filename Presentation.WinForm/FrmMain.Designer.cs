namespace Presentation.WinForm
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKategoriSayısı = new System.Windows.Forms.Label();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.siparişlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriİşlemleriToolStripMenuItem,
            this.kategoriEkleToolStripMenuItem});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            // 
            // kategoriEkleToolStripMenuItem
            // 
            this.kategoriEkleToolStripMenuItem.Name = "kategoriEkleToolStripMenuItem";
            this.kategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriEkleToolStripMenuItem.Text = "Kategori Ekle";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünİşlemleriToolStripMenuItem,
            this.ürünEkleToolStripMenuItem});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem,
            this.müşteriEkleToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişİşlemleriToolStripMenuItem,
            this.siparişEkleToolStripMenuItem});
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            this.siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            this.siparişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // siparişEkleToolStripMenuItem
            // 
            this.siparişEkleToolStripMenuItem.Name = "siparişEkleToolStripMenuItem";
            this.siparişEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişEkleToolStripMenuItem.Text = "Sipariş Ekle";
            // 
            // lblKategoriSayısı
            // 
            this.lblKategoriSayısı.AutoSize = true;
            this.lblKategoriSayısı.Location = new System.Drawing.Point(32, 73);
            this.lblKategoriSayısı.Name = "lblKategoriSayısı";
            this.lblKategoriSayısı.Size = new System.Drawing.Size(83, 15);
            this.lblKategoriSayısı.TabIndex = 1;
            this.lblKategoriSayısı.Text = "Kategori Sayısı";
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Location = new System.Drawing.Point(147, 73);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(0, 15);
            this.lblCategoryCount.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCategoryCount);
            this.Controls.Add(this.lblKategoriSayısı);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Satış Programı";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategorilerToolStripMenuItem;
        private ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kategoriEkleToolStripMenuItem;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private ToolStripMenuItem siparişlerToolStripMenuItem;
        private ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private ToolStripMenuItem siparişEkleToolStripMenuItem;
        private Label lblKategoriSayısı;
        private Label lblCategoryCount;
    }
}