using PatikadevCSharpProjeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Fibonacci serisinin yüksekliği giriniz:");
            int  height= Convert.ToInt32(Console.ReadLine());
            fiboTriangle(height);

        }
        
        static void fiboTriangle(int n)
        {
            
            int length = n * (n + 1) / 2; //fibonacci üçgen yüksekliğinden serinin eleman sayısını bulduk
        
            Fibonacci fibonacci = new Fibonacci(length,length+1);


            fibonacci.fib(fibonacci.f, length);

            
            int fiboNum = 1;

           
            for (int i = 1; i <= n; i++)
            {
               
                for (int j = 1; j <= i; j++)
                    Console.Write(fibonacci.f[fiboNum++] + " ");

                Console.WriteLine();
            }
        }
    }
}
