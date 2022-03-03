using System;

namespace Ajoneuvo
{
    class Ajoneuvot
    {
        // Kun olet kirjoittanut kunkin rivin, paina CTRL + R
        // ja CTRL + E, niin saat automaattisesti getterit ja setterit
        private string merkki;
        private string malli;
        private int vuosimalli;

        protected string Merkki 
        { 
            get => merkki; 
            set => merkki = value; 
        }
        protected string Malli 
        { 
            get => malli; 
            set => malli = value; 
        }
        protected int Vuosimalli 
        { 
            get => vuosimalli; 
            set => vuosimalli = value; 
        }

        public Ajoneuvot() { }
        public Ajoneuvot(string amerkki, string amalli, int avmalli)
        {
            this.Merkki = amerkki;
            this.Malli = amalli;
            this.Vuosimalli = avmalli;
        }
        public void Kiihdyta() { }
        public void Jarruta() { }
        public void Aja() { }
        public void Kaynnista() { }
        public void Sammuta() { }
    }
}
