using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Dikdortgen
    {
        public double kenar1 { get; set; }
        public double kenar2 { get; set; }
        public double alan { get; set; }
        public double cevre { get; set; }

        public void Alan()
        {
            alan = kenar1 * kenar2;
            Console.WriteLine("Alan:{0}", alan);

        }
        public void Cevre()
        {
            cevre = (kenar1+kenar2) * 2;
            Console.WriteLine("Çevre:{0}", cevre);

        }
    }
}
