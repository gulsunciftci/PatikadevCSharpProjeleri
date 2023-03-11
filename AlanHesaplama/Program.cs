using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi şekil için işlem yapmak istersiniz:");
            var inputSekil = Console.ReadLine();
            Console.WriteLine("Hangi işlemi yapmak istersiniz(alan,hacim,cevre):");
            var metod = Console.ReadLine();

            if (inputSekil.ToLower() == "kare")
            {
                Kare kare = new Kare();
                Console.WriteLine("Kenar bilgisini giriniz: ");
                kare.kenar=Convert.ToInt32(Console.ReadLine());
                switch (metod.ToLower())
                {
                    case "alan":
                        kare.Alan();
                        break;
                    case "çevre":
                        kare.Cevre();
                        break;
                    case "hacim":
                        Console.WriteLine("Karenin hacmi hesaplanamaz");
                        break;
                    default:
                        Console.WriteLine("Geçerli bir işlem yazınız!");
                        break;
                }
                
                
            }
            else if (inputSekil.ToLower() == "dikdörtgen")
            {
                Dikdortgen dikdortgen = new Dikdortgen();
                Console.WriteLine("2 Kenar bilgisini giriniz: ");
                var kenar1 = Convert.ToInt32(Console.ReadLine());
                var kenar2 = Convert.ToInt32(Console.ReadLine());
                dikdortgen.kenar1 = kenar1;
                dikdortgen.kenar2 = kenar2;
                
                switch (metod.ToLower())
                {
                    case "alan":
                        dikdortgen.Alan();
                        break;
                    case "çevre":
                        dikdortgen.Cevre();
                        break;
                    case "hacim":
                        Console.WriteLine("Dikdortgenin hacmi hesaplanamaz");
                        break;
                    default:
                        Console.WriteLine("Geçerli bir işlem yazınız!");
                        break;
                }


            }

            else if (inputSekil.ToLower() == "daire")
            {
                Daire daire = new Daire();
                Console.WriteLine("Yarıçap bilgisini giriniz: ");
                daire.r = Convert.ToInt32(Console.ReadLine());
                switch (metod.ToLower())
                {
                    case "alan":
                        daire.Alan();
                        break;
                    case "çevre":
                        daire.Cevre();
                        break;
                    case "hacim":
                        Console.WriteLine("Kurenin hacmi hesaplanamaz");
                        break;
                    default:
                        Console.WriteLine("Geçerli bir işlem yazınız!");
                        break;
                }


            }


        }
    }
}
