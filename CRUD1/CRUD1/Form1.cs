using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD1
{
    public partial class CRUDFM : Form
    {
        Kayttaja user = new Kayttaja();
        public CRUDFM()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            TervetuloPL.Visible = false;
            KirjauduPL.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String osoite = LahiosoiteTB.Text;
            String pnro = PostinumeroTB.Text;
            String ptp = PostitoimipaikkaTB.Text;
            String puh = PuhelinTB.Text;
            String email = EmailTB.Text;
            user.lisaaKayttaja(enimi, snimi, osoite, pnro, ptp, puh, email);
        }

        private void UusiKTBT_Click(object sender, EventArgs e)
        {
            TervetuloPL.Visible = false;
            UusiKayttajaPL.Visible = true;
        }
    }
}
