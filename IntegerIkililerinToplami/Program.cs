using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerIkililerinToplami
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var strings = input.Split(' ');
            String str = String.Empty;
            for(int i=0;i<strings.Length;i+=2)
            {

                if (strings[i] == strings[i + 1])
                {
                    str += Math.Pow((Convert.ToInt32(strings[i]) + Convert.ToInt32(strings[i + 1])), 2) + " ";
                }
                else
                {
                    str += Convert.ToInt32(strings[i]) + Convert.ToInt32(strings[i + 1]) + " ";
                }
            }
            Console.WriteLine(str);
        }
    }
}
