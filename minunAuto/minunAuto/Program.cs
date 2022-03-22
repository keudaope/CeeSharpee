using System;

namespace minunAuto
{
    
    public class minunAuto
    {
        int huippunopeus;
        string vari;

        public minunAuto(int syotettyNopeus, string syotettyVari)
        {
            huippunopeus = syotettyNopeus;
            vari = syotettyVari;
        }

        public void naytaTiedot()
        {
            Console.Write("Auton huippunopeus on: {0} ja väri on {1}.\n", huippunopeus, vari);
        }

        public int haeHuippuNopeus()
        {
            return huippunopeus;
        }

        public void maalaaAuto(string uusivari)
        {
            vari = uusivari;
        }
        public static void Main()
        {

            minunAuto tesla = new minunAuto(225, "Punainen");
            tesla.naytaTiedot();
            tesla.maalaaAuto("Musta");
            tesla.naytaTiedot();
            minunAuto audi = new minunAuto(180, "Valkoinen");
            audi.naytaTiedot();
            tesla.naytaTiedot();
        }
    }
    
}
