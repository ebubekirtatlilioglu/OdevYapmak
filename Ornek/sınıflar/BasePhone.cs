using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek.sınıflar
{
    public class BasePhone
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual void CallSound()
        {
            MessageBox.Show("telefon çalıyor...");
        }
    }
}
