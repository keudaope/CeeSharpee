namespace Muistio
{
    partial class Muistio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muistio));
            this.TekstilaatikkoRTB = new System.Windows.Forms.RichTextBox();
            this.ValikkoMS = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaNimellaValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tulostuksenEsikatseluValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.poistuValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peruValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.teeUudelleenValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.kopioiValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.leikkaaValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.liitäValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.valitseKaikkValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjasinValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinKorostusValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinRivitysValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaValikkoMK = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ValikkoMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TekstilaatikkoRTB
            // 
            this.TekstilaatikkoRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TekstilaatikkoRTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekstilaatikkoRTB.Location = new System.Drawing.Point(0, 24);
            this.TekstilaatikkoRTB.Name = "TekstilaatikkoRTB";
            this.TekstilaatikkoRTB.Size = new System.Drawing.Size(556, 320);
            this.TekstilaatikkoRTB.TabIndex = 0;
            this.TekstilaatikkoRTB.Text = "";
            this.TekstilaatikkoRTB.WordWrap = false;
            this.TekstilaatikkoRTB.TextChanged += new System.EventHandler(this.TekstilaatikkoRTB_TextChanged);
            // 
            // ValikkoMS
            // 
            this.ValikkoMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.muokkaaToolStripMenuItem,
            this.muotoileToolStripMenuItem,
            this.tietoaToolStripMenuItem});
            this.ValikkoMS.Location = new System.Drawing.Point(0, 0);
            this.ValikkoMS.Name = "ValikkoMS";
            this.ValikkoMS.Size = new System.Drawing.Size(556, 24);
            this.ValikkoMS.TabIndex = 1;
            this.ValikkoMS.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.avaaValikkoMK,
            this.tallennaValikkoMK,
            this.tallennaNimellaValikkoMK,
            this.toolStripMenuItem1,
            this.tulostuksenEsikatseluValikkoMK,
            this.tulostaValikkoMK,
            this.toolStripMenuItem2,
            this.poistuValikkoMK});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "&Tiedosto";
            // 
            // avaaValikkoMK
            // 
            this.avaaValikkoMK.Name = "avaaValikkoMK";
            this.avaaValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaValikkoMK.Size = new System.Drawing.Size(191, 22);
            this.avaaValikkoMK.Text = "Avaa";
            this.avaaValikkoMK.Click += new System.EventHandler(this.avaaValikkoMK_Click);
            // 
            // tallennaValikkoMK
            // 
            this.tallennaValikkoMK.Name = "tallennaValikkoMK";
            this.tallennaValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallennaValikkoMK.Size = new System.Drawing.Size(191, 22);
            this.tallennaValikkoMK.Text = "Tallenna";
            this.tallennaValikkoMK.Click += new System.EventHandler(this.tallennaValikkoMK_Click);
            // 
            // tallennaNimellaValikkoMK
            // 
            this.tallennaNimellaValikkoMK.Name = "tallennaNimellaValikkoMK";
            this.tallennaNimellaValikkoMK.Size = new System.Drawing.Size(191, 22);
            this.tallennaNimellaValikkoMK.Text = "Tallenna nimellä...";
            this.tallennaNimellaValikkoMK.Click += new System.EventHandler(this.tallennaNimellaValikkoMK_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // tulostuksenEsikatseluValikkoMK
            // 
            this.tulostuksenEsikatseluValikkoMK.Name = "tulostuksenEsikatseluValikkoMK";
            this.tulostuksenEsikatseluValikkoMK.Size = new System.Drawing.Size(191, 22);
            this.tulostuksenEsikatseluValikkoMK.Text = "Tulostuksen esikatselu";
            this.tulostuksenEsikatseluValikkoMK.Click += new System.EventHandler(this.tulostuksenEsikatseluValikkoMK_Click);
            // 
            // tulostaValikkoMK
            // 
            this.tulostaValikkoMK.Name = "tulostaValikkoMK";
            this.tulostaValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tulostaValikkoMK.Size = new System.Drawing.Size(191, 22);
            this.tulostaValikkoMK.Text = "Tulosta";
            this.tulostaValikkoMK.Click += new System.EventHandler(this.tulostaValikkoMK_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // poistuValikkoMK
            // 
            this.poistuValikkoMK.Name = "poistuValikkoMK";
            this.poistuValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.poistuValikkoMK.Size = new System.Drawing.Size(191, 22);
            this.poistuValikkoMK.Text = "Poistu";
            this.poistuValikkoMK.Click += new System.EventHandler(this.poistuValikkoMK_Click);
            // 
            // muokkaaToolStripMenuItem
            // 
            this.muokkaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peruValikkoMK,
            this.teeUudelleenValikkoMK,
            this.toolStripMenuItem3,
            this.kopioiValikkoMK,
            this.leikkaaValikkoMK,
            this.liitäValikkoMK,
            this.poistaValikkoMK,
            this.valitseKaikkValikkoMK});
            this.muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            this.muokkaaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.muokkaaToolStripMenuItem.Text = "&Muokkaa";
            // 
            // peruValikkoMK
            // 
            this.peruValikkoMK.Name = "peruValikkoMK";
            this.peruValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.peruValikkoMK.Size = new System.Drawing.Size(187, 22);
            this.peruValikkoMK.Text = "Peru";
            this.peruValikkoMK.Click += new System.EventHandler(this.peruValikkoMK_Click);
            // 
            // teeUudelleenValikkoMK
            // 
            this.teeUudelleenValikkoMK.Name = "teeUudelleenValikkoMK";
            this.teeUudelleenValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.teeUudelleenValikkoMK.Size = new System.Drawing.Size(187, 22);
            this.teeUudelleenValikkoMK.Text = "Tee uudelleen";
            this.teeUudelleenValikkoMK.Click += new System.EventHandler(this.teeUudelleenValikkoMK_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(184, 6);
            // 
            // kopioiValikkoMK
            // 
            this.kopioiValikkoMK.Enabled = false;
            this.kopioiValikkoMK.Name = "kopioiValikkoMK";
            this.kopioiValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopioiValikkoMK.Size = new System.Drawing.Size(187, 22);
            this.kopioiValikkoMK.Text = "Kopioi";
            this.kopioiValikkoMK.Click += new System.EventHandler(this.kopioiValikkoMK_Click);
            // 
            // leikkaaValikkoMK
            // 
            this.leikkaaValikkoMK.Enabled = false;
            this.leikkaaValikkoMK.Name = "leikkaaValikkoMK";
            this.leikkaaValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.leikkaaValikkoMK.Size = new System.Drawing.Size(187, 22);
            this.leikkaaValikkoMK.Text = "Leikkaa";
            this.leikkaaValikkoMK.Click += new System.EventHandler(this.leikkaaValikkoMK_Click);
            // 
            // liitäValikkoMK
            // 
            this.liitäValikkoMK.Name = "liitäValikkoMK";
            this.liitäValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.liitäValikkoMK.Size = new System.Drawing.Size(187, 22);
            this.liitäValikkoMK.Text = "Liitä";
            this.liitäValikkoMK.Click += new System.EventHandler(this.liitäValikkoMK_Click);
            // 
            // poistaValikkoMK
            // 
            this.poistaValikkoMK.Name = "poistaValikkoMK";
            this.poistaValikkoMK.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.poistaValikkoMK.Size = new System.Drawing.Size(187, 22);
            this.poistaValikkoMK.Text = "Poista";
            this.poistaValikkoMK.Click += new System.EventHandler(this.poistaValikkoMK_Click);
            // 
            // valitseKaikkValikkoMK
            // 
            this.valitseKaikkValikkoMK.Name = "valitseKaikkValikkoMK";
            this.valitseKaikkValikkoMK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.valitseKaikkValikkoMK.Size = new System.Drawing.Size(187, 22);
            this.valitseKaikkValikkoMK.Text = "Valitse kaikki";
            this.valitseKaikkValikkoMK.Click += new System.EventHandler(this.valitseKaikkValikkoMK_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjasinValikkoMK,
            this.tekstinKorostusValikkoMK,
            this.tekstinRivitysValikkoMK});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.muotoileToolStripMenuItem.Text = "M&uotoile";
            // 
            // kirjasinValikkoMK
            // 
            this.kirjasinValikkoMK.Name = "kirjasinValikkoMK";
            this.kirjasinValikkoMK.Size = new System.Drawing.Size(180, 22);
            this.kirjasinValikkoMK.Text = "Kirjasin";
            this.kirjasinValikkoMK.Click += new System.EventHandler(this.kirjasinValikkoMK_Click);
            // 
            // tekstinKorostusValikkoMK
            // 
            this.tekstinKorostusValikkoMK.Name = "tekstinKorostusValikkoMK";
            this.tekstinKorostusValikkoMK.Size = new System.Drawing.Size(180, 22);
            this.tekstinKorostusValikkoMK.Text = "Tekstin korostus";
            this.tekstinKorostusValikkoMK.Click += new System.EventHandler(this.tekstinKorostusValikkoMK_Click);
            // 
            // tekstinRivitysValikkoMK
            // 
            this.tekstinRivitysValikkoMK.Name = "tekstinRivitysValikkoMK";
            this.tekstinRivitysValikkoMK.Size = new System.Drawing.Size(180, 22);
            this.tekstinRivitysValikkoMK.Text = "Tekstin rivitys";
            this.tekstinRivitysValikkoMK.Click += new System.EventHandler(this.tekstinRivitysValikkoMK_Click);
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoaValikkoMK});
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tietoaToolStripMenuItem.Text = "&Tietoa";
            // 
            // tietoaValikkoMK
            // 
            this.tietoaValikkoMK.Name = "tietoaValikkoMK";
            this.tietoaValikkoMK.Size = new System.Drawing.Size(180, 22);
            this.tietoaValikkoMK.Text = "Tietoa";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.uusiToolStripMenuItem.Text = "Uusi";
            this.uusiToolStripMenuItem.Click += new System.EventHandler(this.uusiToolStripMenuItem_Click);
            // 
            // Muistio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 344);
            this.Controls.Add(this.TekstilaatikkoRTB);
            this.Controls.Add(this.ValikkoMS);
            this.MainMenuStrip = this.ValikkoMS;
            this.Name = "Muistio";
            this.Text = "Muistio";
            this.ValikkoMS.ResumeLayout(false);
            this.ValikkoMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TekstilaatikkoRTB;
        private System.Windows.Forms.MenuStrip ValikkoMS;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaaValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem tallennaValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem tallennaNimellaValikkoMK;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tulostuksenEsikatseluValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem tulostaValikkoMK;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem poistuValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem muokkaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peruValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem teeUudelleenValikkoMK;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem kopioiValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem leikkaaValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem liitäValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem poistaValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem valitseKaikkValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem muotoileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirjasinValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem tekstinKorostusValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem tekstinRivitysValikkoMK;
        private System.Windows.Forms.ToolStripMenuItem tietoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietoaValikkoMK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem uusiToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

