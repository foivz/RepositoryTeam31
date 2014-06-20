namespace Bastion
{
    partial class dodajArtikl
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uREDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.djelatniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.naruciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eVIDENCIJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obracuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisNarudzbiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZVJESTAJIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojGostijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najprodavanijiArtiklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oDJAVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alkoholno pice",
            "Bezalkoholno pice",
            "Hrana"});
            this.comboBox1.Location = new System.Drawing.Point(410, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Tip artikla";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(261, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Naziv";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(410, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(75, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(261, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Cijena";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(410, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(261, 20);
            this.textBox5.TabIndex = 5;
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
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
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
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "Spremi";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Zatvori";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // uREDIToolStripMenuItem
            // 
            this.uREDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.djelatniciToolStripMenuItem,
            this.artikliToolStripMenuItem});
            this.uREDIToolStripMenuItem.Enabled = false;
            this.uREDIToolStripMenuItem.Name = "uREDIToolStripMenuItem";
            this.uREDIToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.uREDIToolStripMenuItem.Text = "UREDI";
            // 
            // djelatniciToolStripMenuItem
            // 
            this.djelatniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.urediToolStripMenuItem1,
            this.izbrisiToolStripMenuItem});
            this.djelatniciToolStripMenuItem.Enabled = false;
            this.djelatniciToolStripMenuItem.Name = "djelatniciToolStripMenuItem";
            this.djelatniciToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.djelatniciToolStripMenuItem.Text = "Djelatnici";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // urediToolStripMenuItem1
            // 
            this.urediToolStripMenuItem1.Name = "urediToolStripMenuItem1";
            this.urediToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.urediToolStripMenuItem1.Text = "Uredi";
            // 
            // izbrisiToolStripMenuItem
            // 
            this.izbrisiToolStripMenuItem.Name = "izbrisiToolStripMenuItem";
            this.izbrisiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.izbrisiToolStripMenuItem.Text = "Izbrisi";
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1,
            this.urediToolStripMenuItem2,
            this.izbrisiToolStripMenuItem1,
            this.naruciToolStripMenuItem});
            this.artikliToolStripMenuItem.Enabled = false;
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.artikliToolStripMenuItem.Text = "Artikli";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            // 
            // urediToolStripMenuItem2
            // 
            this.urediToolStripMenuItem2.Name = "urediToolStripMenuItem2";
            this.urediToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.urediToolStripMenuItem2.Text = "Uredi";
            // 
            // izbrisiToolStripMenuItem1
            // 
            this.izbrisiToolStripMenuItem1.Name = "izbrisiToolStripMenuItem1";
            this.izbrisiToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.izbrisiToolStripMenuItem1.Text = "Izbrisi";
            // 
            // naruciToolStripMenuItem
            // 
            this.naruciToolStripMenuItem.Name = "naruciToolStripMenuItem";
            this.naruciToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.naruciToolStripMenuItem.Text = "Naruci";
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
            this.oDJAVAToolStripMenuItem.Enabled = false;
            this.oDJAVAToolStripMenuItem.Name = "oDJAVAToolStripMenuItem";
            this.oDJAVAToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.oDJAVAToolStripMenuItem.Text = "ODJAVA";
            // 
            // dodajArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 326);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dodajArtikl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj artikl";
            this.Load += new System.EventHandler(this.dodajArtikl_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uREDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem djelatniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izbrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem izbrisiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem naruciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eVIDENCIJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obracuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisNarudzbiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZVJESTAJIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojGostijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najprodavanijiArtiklToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oDJAVAToolStripMenuItem;
    }
}