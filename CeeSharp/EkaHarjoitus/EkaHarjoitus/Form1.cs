using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkaHarjoitus
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void painikeBT_Click(object sender, EventArgs e)
        {
            VaihdettavaLB.Text = "Menit sittenkin painamaan!";
        }

        private void lukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Int32.Parse(lukuTB.Text);
                    if(lukuTB.Text == "-999")
                    {
                        lukuTB.Text = "";
                        int[] taulukko = jono.ToArray();
                        Array.Sort(taulukko);
                        foreach(var jasen in taulukko)
                        {
                            vastausLB.Text += jasen + " ";
                        }
                        vastausLB.ForeColor = System.Drawing.Color.Black;
                        vastausLB.Visible = true;
                    }
                    else
                    {
                        vastausLB.Text = "";
                        vastausLB.Visible = false;
                        jono.Add(Int32.Parse(lukuTB.Text));
                        lukuTB.Text = "";
                    }  
                }
                catch
                {
                    vastausLB.Text = "Virhe!";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = System.Drawing.Color.Red;
                }
            }
            
        }
    }
}
