using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            char ch = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Console.WriteLine("yes");
                }
            }          
          }
            
    }
}









