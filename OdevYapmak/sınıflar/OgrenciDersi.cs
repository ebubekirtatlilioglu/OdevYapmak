using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevYapmak.sınıflar
{
    public class OgrenciDersi
    {
        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }
        public override string ToString()
        {
            return "Ad: " + Ogrenci.Ad + " Soyad: " + Ogrenci.Soyad + " Öğrenci Numarası: " +Ogrenci.OgrenciNumarasi + " Bölüm: " +Ogrenci.Bolumu + " Danışman Ad: " +Ogrenci.Danisman.Ad +" Danışman Soyad: " + Ogrenci.Danisman.Soyad + " Ders Ad: " + Ders.Ad + " Ders kodu: " + Ders.Kod + " Kredisi: " + Ders.Kredi + " Türü: " + Ders.ZorunluMu;
        }
    }
}
