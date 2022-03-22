using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pankkitili;

namespace Pankkitili
{
    [TestClass]
    public class PankkitiliTesti
    {
        [TestMethod]
        public void Otto_OikeallaSummalla_PaivitaSaldo()
        {
            //Alkuvalmistelut
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            Pankki tili = new Pankki("Jaakko Tarvainen", alkusaldo);

            // Toiminto
            tili.Otto(ottoSumma);

            // Oletettu lopputulos
            double todellinen = tili.Saldo;

            Assert.AreEqual(oletettu, todellinen, 0.001, "Tililtä otto ei onnistunut");

        }
    }
}
