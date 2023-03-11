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
            int index=0;
            int unsuzSayisi=0;
            string sonuc = "";
            
            for(int i=0; i < strings.Length; i++)
            {
                string b = "";
                unsuzSayisi = 0;
       
                for (int j = 0; j < strings[i].Length; j++)
                {
                    if (unluler.Contains(strings[i][j]))
                    {
                        if (unsuzSayisi == 1)
                        {
                            unsuzSayisi = 0;
                        }
                        continue;
                    }
                    if (unsuzSayisi!=2)
                    {
                        unsuzSayisi++;
               
                        if (unsuzSayisi == 1)
                        {
                            index = j;             
                        }

                        else if (unsuzSayisi == 2)
                        {
                            if ((j - index) == 1)
                            {
                                 b+= "true" + " ";    
                            }
                            else
                            {
                                index = j;
                            }
                        }
                    }
                  
                }
                if (b == "")
                {
                     b+= "false" + " ";
                }
                
                sonuc += b;
            }
            Console.WriteLine(sonuc);
        }
    }
}
