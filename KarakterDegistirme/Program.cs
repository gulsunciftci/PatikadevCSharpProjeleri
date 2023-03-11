using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterDegistirme
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cumle = Console.ReadLine().Split(' ');
            string yeniCumle = "";
            char ilkharfTutucu=' ';
            char sonharfTutucu=' ';
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j< cumle[i].Length;j++ )
                {
                    if (j == 0)
                    {
                        ilkharfTutucu = cumle[i][j];
                    }
                    else if (j == cumle[i].Length-1)
                    {
                        sonharfTutucu = cumle[i][j];
                        yeniCumle += sonharfTutucu + cumle[i].Substring(1, cumle[i].Length - 2) + ilkharfTutucu + " ";
                        
                    }

                }
            }
            Console.WriteLine(yeniCumle);


        }
    }
}
