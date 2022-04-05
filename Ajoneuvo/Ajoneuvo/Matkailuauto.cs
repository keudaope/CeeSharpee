using System;
using System.Collections.Generic;
using System.Text;

namespace Ajoneuvo
{
    class Matkailuauto : Pakettiauto
    {
        private int makuupaikkoja;

        public int Makuupaikkoja { get => makuupaikkoja; set => makuupaikkoja = value; }
    }
}
