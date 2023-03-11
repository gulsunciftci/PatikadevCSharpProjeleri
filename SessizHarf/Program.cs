using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizHarf
{
    public class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split(' ');
            string unluler = "aeoöuüıi";
            string sonuc = "";
            bool[] trueFalse = new bool[strings.Length];
            int sıra = 0; 
            foreach (var item in strings) 
            {
                int counter = 0; 
                foreach (var harf in item)
                {

                    if (unluler.Contains(harf)) 
                    {
                        counter = 0; 
                    }
                    else
                    {
                        counter++; 
                        if (counter == 2) 
                        {
                            trueFalse[sıra] = true;
                            break; 
                        }
                    }
                }
                sıra++; 

            }
            foreach (var item in trueFalse)
            {
                sonuc+=item + " ";
            }
            Console.WriteLine(sonuc);
        }
    }
}
