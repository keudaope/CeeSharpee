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
        public CRUDFM()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            TervetuloPL.Visible = false;
            KirjauduPL.Visible = true;
        }

    }
}
