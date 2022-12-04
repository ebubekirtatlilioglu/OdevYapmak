using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevYapmak.sınıflar
{
    public class Ogrenci : Kisi
    {
        public Danisman Danisman { get; set; }
        public string OgrenciNumarasi { get; set; }
        public string Bolumu { get; set; }
        public override string ToString()
        {
            return "Ad: "+Ad + " Soyad: " + Soyad + " Öğrenci Numarası: " + OgrenciNumarasi + " Bölüm: " + Bolumu + " Danışmanı: " + Danisman;
        }
    }
}
