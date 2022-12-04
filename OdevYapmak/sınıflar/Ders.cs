
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevYapmak.sınıflar
{
    public class Ders
    {
        public string Ad { get; set; }
        public string Kod { get; set; }
        public int Kredi { get; set; }
        public bool ZorunluMu { get; set; }
        public override string ToString()
        {
            return "Ad: " + Ad + " Kod: " + Kod + " Kredisi: " + Kredi + " Türü: " + (ZorunluMu?"Zorunlu":"Seçmeli");
        }
    }
}
