using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDrawing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PİRAMİT:");
            pyramid(height);
            Console.WriteLine("ÜÇGEN:");
            triangle(height);
            Console.WriteLine("TERS ÜÇGEN:");
            invertedTriangle(height);
            Console.WriteLine("İÇİ BOŞ ÜÇGEN:");
            emptyTriangle(height);
            Console.WriteLine("SAĞA DAYALI ÜÇGEN:");
            rightJustifiedTriangle(height);
        }
        public static void rightJustifiedTriangle(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int k = i; k < height; k++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("*");
                    Console.Write(""); //sağa yaslamak için boşluğu kaldır
                }
                Console.WriteLine();
            }
        }
        public static void emptyTriangle(int height)
        {
            int i, j;
            // satır için döngü
            for (i = 1; i <= height; i++) 
            {
             
                for (j = 1; j < 2 * height; j++) 
                {
                    // Eşit tarafları yazdırmak için 
                    if (j == (height - i + 1) // sol kısımdaki yıldızları oluşturur
                        || j == (height + i - 1)) // sağ kısımdaki yıldızları oluşturur
                    {
                        Console.Write("* ");
                    }
                    // dış üçgen için
                    else if (i == height)

                    {

                        Console.Write("* ");
                    }

                    // boşluklar için kullanılan kod satırları alt tarafta verilmiştir
                    else
                    {
                        Console.Write(" " + " ");
                    }
                }
                Console.Write("\n"); // bu kod satırını silersek üçgen bozuluyor metinde bir alt satıra geçmesini sağlayan kısımdır
            }
        }
        public static void triangle(int height)
        {
            for (int i = 1; i <= height; i++) // yukarıdan aşağıya tek tek 10 satır ataması için 
            {
                for (int j = 0; j < i; j++) // soldan sağa yıldızları teker teker arttırarak yazdırdığı kısım 
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
            Console.Read();

        }
        public static void invertedTriangle(int height)
        {
            for (int i = 0; i <= height; i++) // bu kod satırımızda i degeri 10 tane satırı yazdırdı
            {
                for (int j = height; j > i; j--) // bu kod satırında ise j değeri ilk satırı 10 yıldız ile başlattı ve her seferinde birer azaltma işlemi uyguladı
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
        }
        public static void pyramid(int height)
        {
           
                for (int i = 0; i < height; i++) // 20 adet satır ve sütün oluşması için 
                {
                    for (int k = i; k < height; k++) // soldaki boşluklar için 
                    {
                        Console.Write(" ");
                    }
                    for (int x = 0; x <= i; x++)
                    {
                        Console.Write("*"); // üçgenimizdeki yıldız şekilleri için 
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
               
            
        }

    }

}
