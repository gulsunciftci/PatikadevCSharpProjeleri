using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTriangleandAvarage
{
    public class Fibonacci
    {
        public int _count { get; set; }
        public int[] f;
        public double avarage;
        public Fibonacci(int count, int n)
        {
            _count = count;
            this.f = new int[n];
        }
        public void fib(int[] f, int count)
        {

            f[1] = 1;
            f[2] = 1;

            for (int i = 3; i <= count; i++)
            {


                f[i] = f[i - 1] + f[i - 2];
            }
        }
        public void avarageFunction()
        {
            avarage = f.Average();
            Console.Write("Fibonacci dizi ortalaması:{0}    ", avarage);
        }
    }
}

