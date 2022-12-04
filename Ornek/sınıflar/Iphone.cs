using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek.sınıflar
{
    public class Iphone:BasePhone
    {
        public override void CallSound()
        {
            MessageBox.Show("Iphone çalıyor...");
        }
    }
}
