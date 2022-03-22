using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Muistio
{
    public partial class Muistio : Form
    {
        string tiedostopolku = "";
        public Muistio()
        {
            InitializeComponent();
        }

        private void avaaValikkoMK_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog atk = new OpenFileDialog() { Filter = "Tekstidokumentti (*.txt)|*.txt|Rikastekstiformaatti (*.rtf)|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if(atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader jonolukija = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> text = jonolukija.ReadToEndAsync();
                        TekstilaatikkoRTB.Rtf = text.Result; // Näin tuodaan muotoiltuteksti
                    }
                }
            }
        }

        private void tallennaValikkoMK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tiedostopolku))
            {
                using(SaveFileDialog ttk = new SaveFileDialog() { Filter = "Tekstidokumentti (*.txt)|*.txt|Rikastekstiformaatti (*.rtf)|*.rtf", ValidateNames = true })
                {
                    if(ttk.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                        {
                            jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                        }
                    }
                    else
                    {
                        using (StreamWriter jonokirjoittaja = new StreamWriter(tiedostopolku))
                        {
                            jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                        }
                    }
                }
            }
        }

        private void tallennaNimellaValikkoMK_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog() { Filter = "Tekstidokumentti (*.txt)|*.txt|Rikastekstiformaatti (*.rtf)|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluValikkoMK_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaValikkoMK_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuValikkoMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB != null)
            {
                tallennaValikkoMK_Click(sender, e);
                TekstilaatikkoRTB.Rtf = "";
            }
            else
            {
                TekstilaatikkoRTB.Rtf = "";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstilaatikkoRTB.Rtf, TekstilaatikkoRTB.Font, Brushes.Black, 12, 10);
        }

        private void peruValikkoMK_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Undo();
        }

        private void teeUudelleenValikkoMK_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Redo();
        }

        private void kopioiValikkoMK_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Copy();
        }

        private void leikkaaValikkoMK_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Cut();
        }

        private void liitäValikkoMK_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Paste();
        }

        private void poistaValikkoMK_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectedText = "";
        }

        private void valitseKaikkValikkoMK_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectAll();
        }

        private void TekstilaatikkoRTB_TextChanged(object sender, EventArgs e)
        {
            if(TekstilaatikkoRTB.Text.Length > 0)
            {
                kopioiValikkoMK.Enabled = true;
                leikkaaValikkoMK.Enabled = true;
            }
            else
            {
                kopioiValikkoMK.Enabled = false;
                leikkaaValikkoMK.Enabled = false;
            }
        }

        private void kirjasinValikkoMK_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstilaatikkoRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusValikkoMK_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectionBackColor = Color.Yellow;
        }

        private void tekstinRivitysValikkoMK_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysValikkoMK.Checked == true)
            {
                tekstinRivitysValikkoMK.Checked = false;
                TekstilaatikkoRTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysValikkoMK.Checked = true;
                TekstilaatikkoRTB.WordWrap = true;
            }
        }
    }
}
