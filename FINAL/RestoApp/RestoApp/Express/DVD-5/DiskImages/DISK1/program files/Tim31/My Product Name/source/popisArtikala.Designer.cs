namespace Bastion
{
    partial class popisArtikala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popisArtikala));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uREDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.djelatniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisDjelatnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.naruciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediArtiklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eVIDENCIJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obracuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisNarudzbiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZVJESTAJIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojGostijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najprodavanijiArtiklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oDJAVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.uREDIToolStripMenuItem,
            this.eVIDENCIJAToolStripMenuItem,
            this.iZVJESTAJIToolStripMenuItem,
            this.oDJAVAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fileToolStripMenuItem.Text = "DATOTEKA";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "Otvori";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Zatvori";
            // 
            // uREDIToolStripMenuItem
            // 
            this.uREDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.djelatniciToolStripMenuItem,
            this.artikliToolStripMenuItem,
            this.urediArtiklToolStripMenuItem});
            this.uREDIToolStripMenuItem.Name = "uREDIToolStripMenuItem";
            this.uREDIToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.uREDIToolStripMenuItem.Text = "UREDI";
            this.uREDIToolStripMenuItem.Click += new System.EventHandler(this.uREDIToolStripMenuItem_Click);
            // 
            // djelatniciToolStripMenuItem
            // 
            this.djelatniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.urediToolStripMenuItem1,
            this.izbrisiToolStripMenuItem,
            this.popisDjelatnikaToolStripMenuItem});
            this.djelatniciToolStripMenuItem.Enabled = false;
            this.djelatniciToolStripMenuItem.Name = "djelatniciToolStripMenuItem";
            this.djelatniciToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.djelatniciToolStripMenuItem.Text = "Djelatnici";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // urediToolStripMenuItem1
            // 
            this.urediToolStripMenuItem1.Name = "urediToolStripMenuItem1";
            this.urediToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.urediToolStripMenuItem1.Text = "Uredi";
            // 
            // izbrisiToolStripMenuItem
            // 
            this.izbrisiToolStripMenuItem.Name = "izbrisiToolStripMenuItem";
            this.izbrisiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.izbrisiToolStripMenuItem.Text = "Izbrisi";
            // 
            // popisDjelatnikaToolStripMenuItem
            // 
            this.popisDjelatnikaToolStripMenuItem.Name = "popisDjelatnikaToolStripMenuItem";
            this.popisDjelatnikaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.popisDjelatnikaToolStripMenuItem.Text = "Popis djelatnika";
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1,
            this.urediToolStripMenuItem2,
            this.izbrisiToolStripMenuItem1,
            this.naruciToolStripMenuItem,
            this.popisArtikalaToolStripMenuItem});
            this.artikliToolStripMenuItem.Enabled = false;
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.artikliToolStripMenuItem.Text = "Artikli";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            // 
            // urediToolStripMenuItem2
            // 
            this.urediToolStripMenuItem2.Name = "urediToolStripMenuItem2";
            this.urediToolStripMenuItem2.Size = new System.Drawing.Size(144, 22);
            this.urediToolStripMenuItem2.Text = "Uredi";
            // 
            // izbrisiToolStripMenuItem1
            // 
            this.izbrisiToolStripMenuItem1.Name = "izbrisiToolStripMenuItem1";
            this.izbrisiToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.izbrisiToolStripMenuItem1.Text = "Izbrisi";
            // 
            // naruciToolStripMenuItem
            // 
            this.naruciToolStripMenuItem.Name = "naruciToolStripMenuItem";
            this.naruciToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.naruciToolStripMenuItem.Text = "Naruci";
            // 
            // popisArtikalaToolStripMenuItem
            // 
            this.popisArtikalaToolStripMenuItem.Name = "popisArtikalaToolStripMenuItem";
            this.popisArtikalaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.popisArtikalaToolStripMenuItem.Text = "Popis artikala";
            // 
            // urediArtiklToolStripMenuItem
            // 
            this.urediArtiklToolStripMenuItem.Name = "urediArtiklToolStripMenuItem";
            this.urediArtiklToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.urediArtiklToolStripMenuItem.Text = "Uredi artikl";
            this.urediArtiklToolStripMenuItem.Click += new System.EventHandler(this.urediArtiklToolStripMenuItem_Click);
            // 
            // eVIDENCIJAToolStripMenuItem
            // 
            this.eVIDENCIJAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obracuniToolStripMenuItem,
            this.popisNarudzbiToolStripMenuItem});
            this.eVIDENCIJAToolStripMenuItem.Enabled = false;
            this.eVIDENCIJAToolStripMenuItem.Name = "eVIDENCIJAToolStripMenuItem";
            this.eVIDENCIJAToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.eVIDENCIJAToolStripMenuItem.Text = "EVIDENCIJA";
            // 
            // obracuniToolStripMenuItem
            // 
            this.obracuniToolStripMenuItem.Name = "obracuniToolStripMenuItem";
            this.obracuniToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.obracuniToolStripMenuItem.Text = "Obracuni";
            // 
            // popisNarudzbiToolStripMenuItem
            // 
            this.popisNarudzbiToolStripMenuItem.Name = "popisNarudzbiToolStripMenuItem";
            this.popisNarudzbiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.popisNarudzbiToolStripMenuItem.Text = "Popis narudzbi";
            // 
            // iZVJESTAJIToolStripMenuItem
            // 
            this.iZVJESTAJIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brojGostijuToolStripMenuItem,
            this.zaradaToolStripMenuItem,
            this.najprodavanijiArtiklToolStripMenuItem});
            this.iZVJESTAJIToolStripMenuItem.Enabled = false;
            this.iZVJESTAJIToolStripMenuItem.Name = "iZVJESTAJIToolStripMenuItem";
            this.iZVJESTAJIToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.iZVJESTAJIToolStripMenuItem.Text = "IZVJESTAJI";
            // 
            // brojGostijuToolStripMenuItem
            // 
            this.brojGostijuToolStripMenuItem.Name = "brojGostijuToolStripMenuItem";
            this.brojGostijuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brojGostijuToolStripMenuItem.Text = "Broj gostiju";
            // 
            // zaradaToolStripMenuItem
            // 
            this.zaradaToolStripMenuItem.Name = "zaradaToolStripMenuItem";
            this.zaradaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zaradaToolStripMenuItem.Text = "Zarada";
            // 
            // najprodavanijiArtiklToolStripMenuItem
            // 
            this.najprodavanijiArtiklToolStripMenuItem.Name = "najprodavanijiArtiklToolStripMenuItem";
            this.najprodavanijiArtiklToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.najprodavanijiArtiklToolStripMenuItem.Text = "Najprodavaniji artikl";
            // 
            // oDJAVAToolStripMenuItem
            // 
            this.oDJAVAToolStripMenuItem.Name = "oDJAVAToolStripMenuItem";
            this.oDJAVAToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.oDJAVAToolStripMenuItem.Text = "ODJAVA";
            // 
            // popisArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(445, 309);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "popisArtikala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis artikala";
            this.Load += new System.EventHandler(this.popisArtikala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uREDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem djelatniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izbrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisDjelatnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem izbrisiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem naruciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eVIDENCIJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obracuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisNarudzbiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZVJESTAJIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojGostijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najprodavanijiArtiklToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oDJAVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediArtiklToolStripMenuItem;
    }
}