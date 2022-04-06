using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Apinako
{
    public partial class Apilomake : Form
    {
        public Apilomake()
        {
            InitializeComponent();
        }

        private void haeBT_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            HttpResponseMessage response = client.GetAsync("users").Result;
            var kayttajat = response.Content.ReadAsAsync<IEnumerable<Users>>().Result;
            tulostusalueDGV.DataSource = kayttajat;
            tulostusalueDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void tulostusalueDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Apilomake_Load(object sender, EventArgs e)
        {

        }
    }
}
