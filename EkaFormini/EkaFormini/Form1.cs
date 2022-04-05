using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkaFormini
{
    public partial class EkaLomakeFm : Form
    {
        public EkaLomakeFm()
        {
            InitializeComponent();
        }

        private void PainikeBT_Click(object sender, EventArgs e)
        {
            TekstiLB.Text = "Heippa maailma!";
            TekstiLB.Visible = true;
        }
    }
}
