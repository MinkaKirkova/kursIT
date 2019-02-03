using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TYPEint3
{
    class Program
    {
        static void Main(string[] args)
        {//От 16 то 10
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s, 16);
            Console.WriteLine(a);
            Console.WriteLine();
            //От 10 то 16
            int s1 = int.Parse(Console.ReadLine());
            string a1 = Convert.ToString(s1, 16).ToUpper();
          string b1 = Convert.ToString(s1, 2).ToUpper();
            Console.WriteLine(a1);
            Console.WriteLine();
            Console.WriteLine(b1);
            Console.WriteLine();
        }
    }
}
