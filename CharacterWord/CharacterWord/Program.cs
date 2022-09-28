using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char c1=Convert.ToChar(Console.ReadLine());
            string str2=Char.ToString(c1);
            if(str2.Contains(str));
            Console.WriteLine("true");
            
            Console.ReadLine();
        }
    }
}
