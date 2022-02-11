using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _KitapDukkani
{
    class Müşteri
    {
        public string MüşteriAdi { get; set; }
        public string Meslek { get; set; }
        public Kitaplar Kitap { get; set; }
        public int Yaş { get; set; }
        
    }
}
