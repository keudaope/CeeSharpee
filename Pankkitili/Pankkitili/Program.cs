using System;

namespace Pankkitili
{
    public class Pankki
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;

        private Pankki() { }
        public Pankki(string asiakkaanimi, double saldo)
        {
            m_asiakkaanNimi = asiakkaanimi;
            m_saldo = saldo;
        }
        public string Asiakkaannimi
        {
            get
            {
                return m_asiakkaanNimi;
            }
        }
        public double Saldo
        {
            get
            {
                return m_saldo;
            }
        }
        public void Otto(double summa)
        {
            if(summa > m_saldo)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            if(summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo -= summa; // tässä vaiheessa väärä laskutapa
        }
        public void Pano(double summa)
        {
            if(summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo += summa;
        }
        static void Main(string[] args)
        {
            Pankki pt = new Pankki("Jyri Lindroos", 300.12);
            pt.Pano(500);
            pt.Otto(252.34);
            Console.WriteLine("Nykyinen saldo on {0} euroa", pt.Saldo);
        }
    }
}
