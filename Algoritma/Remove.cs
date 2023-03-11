using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    public class Remove
    {
        public int index { get; set; }
        public string str { get; set; }
        public string newStr { get; set; }
        
        public Remove(string str)
        {
            this.str = str;  
        }

        public void removeFunction()
        {
            try
            {
                var strings = str.Split(',');
                index = Convert.ToInt32(strings[1]);
                newStr = strings[0];
                newStr = newStr.Remove(index, 1);
                Console.WriteLine(newStr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
    }
}
