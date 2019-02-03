using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace brsystems
{
    class Program
    {
        static void Main(string[] args)
        {//Превръщане от десетично в двоично число
            int n; string s = "";
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int r = n % 2;
                s = s + r.ToString();
                n = n / 2;
            }
            //Console.WriteLine(s);

            for (int i = s.Length - 1; i >= 0; i--)
                Console.Write(s[i]);
            //Втори начин на дес в двоично без низове
/*
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
       
            long S = 0;
            long n = 1;

                while (a != 0)
                {
                    S = S + a % 2 * n;
                    n = n * 10;
                    a = a / 2;
                }
                Console.WriteLine(S);
        }
*/
            //Превръщане от десетично в шестнадесетично число
            Console.WriteLine();
            int n1; string s1 = "";
            n1 = int.Parse(Console.ReadLine());
            while (n1 > 0)
            {
                int r1 = n1 % 16;
                if (r1 < 10)
                    s1 = s1 + r1.ToString();
                else
                    s1 = s1 + (char)(r1 + 55);
                n1 = n1 / 16;
            }
            //Console.WriteLine(s);

            for (int j = s1.Length - 1; j >= 0; j--)
                Console.Write(s1[j]);

            Console.WriteLine();
        }
    }
}
 