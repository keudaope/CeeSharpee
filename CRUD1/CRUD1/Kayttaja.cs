using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD1
{
    internal class Kayttaja
    {
        Yhdista yhteys = new Yhdista(); // Luodaan yhteys Yhdista-luokkaan, jotta voidaan käyttää sen komentoja
        CRUDFM lomake = new CRUDFM();

          

        public bool lisaaKayttaja(String enimi, String snimi, String osoite, String pnro, String ppaikka, String puhelin, string email)
        {
            String ktunnus = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            String salasana = luoSalasana();
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO kayttajatiedot " +
                "(kayttajatunnus, salasana, etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, puhelin, email) " +
                "VALUES (@ktu, @ssa, @enm, @snm, @oso, @pno, @ptp, @puh, @eml); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu,@enm, @snm, @oso, @pno, @ptp, @ssa
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasana;
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            MessageBox.Show("Käyttäjätunnuksesi on {0}", ktunnus);
            MessageBox.Show("Salasanasi on {0}", salasana);


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public String luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#€?0123456789".ToCharArray();
            Random satunnaisluku = new Random();
            String salasana = "";
            for (int i = 0; i < 12; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }
    }
}
