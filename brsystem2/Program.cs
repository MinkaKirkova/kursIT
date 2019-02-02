using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace brsystem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Превръщане отдвоично в десетично число
            int n=0,result=0; string s = "";
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {var a=int.Parse(s[i].ToString());
                result=result+(int)(a*Math.Pow(2,n));n++;
            }
                Console.WriteLine(result);

        }
    }
}
