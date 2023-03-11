using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Kare
    {
        public double kenar { get; set; }
        public double alan { get; set; }
        public double cevre { get; set; }
        public void Alan()
        {
            alan = kenar * kenar;
            Console.WriteLine("Alan:{0}", alan);

        }
        public void Cevre()
        {
             cevre= kenar * 4;
            Console.WriteLine("Çevre:{0}", cevre);

        }

    }
    
}
