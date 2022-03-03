using System;
using System.Collections.Generic;
using System.Text;

namespace Ajoneuvo
{
    class TestaaAjoneuvoja
    {
        static void Main()
        {
            Auto minunAutoni = new Auto();
            minunAutoni.Kaynnista();
            minunAutoni.Aja();
            minunAutoni.Kiihdyta();
            minunAutoni.Jarruta();
            minunAutoni.Sammuta();
            minunAutoni.Istuimia = 5;
            Urheiluauto ferrari = new Urheiluauto();
            ferrari.Aja();
            ferrari.Istuimia = 2;
            ferrari.Huippunopeus=350;
            Pakettiauto transporter = new Pakettiauto();
            transporter.Kuutiotilavuus = 4.6;
            transporter.Aja();
            Tila_auto pikkubussi = new Tila_auto();
            pikkubussi.Kuutiotilavuus = 5.5;
            pikkubussi.Istuimia = 9;
            pikkubussi.Aja();
            Matkailuauto dethleffs = new Matkailuauto();
            dethleffs.Kuutiotilavuus = 6.9;
            dethleffs.Makuupaikkoja = 4;
            dethleffs.Aja();
        }
    }
}
