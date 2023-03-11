using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Daire
    {
        public double r { get; set; }
        public double alan { get; set; }
        public double cevre { get; set; }
        public const double pi = 3.14;

        public void Alan()
        {
            alan = 4*pi*(r*r);
            Console.WriteLine("Alan:{0}", alan);

        }
        public void Cevre()
        {
            cevre = 2*pi*r;
            Console.WriteLine("Çevre:{0}", cevre);

        }
    }

}
