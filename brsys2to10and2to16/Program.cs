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
            //Превръщане от двоично в десетично число
            int n = 0, result = 0; int s;
            s = int.Parse(Console.ReadLine());
            while(s>0)
            {
                result = result + (int)(s%10 * Math.Pow(2, n));
                n++;
                s /= 10;
            }
             Console.WriteLine(result);
            //Превръщане от двоично в шестнадесетично число
            string bin = Console.ReadLine();
            string hex = "";
            while(bin.Length>=4)
            { string sub = bin.Substring(bin.Length - 4, 4);
            switch(sub)
                { case "0000": hex += "0"; break;
                case "0001": hex += "1"; break;
                case "0010": hex += "2"; break;
                case "0011": hex += "3"; break;
                case "0100": hex += "4"; break;
                case "0101": hex += "5"; break;
                case "0110": hex += "6"; break;
                case "0111": hex += "7"; break;
                case "1000": hex += "8"; break;
                case "1001": hex += "9"; break;
                case "1010": hex += "A"; break;
                case "1011": hex += "B"; break;
                case "1100": hex += "C"; break;
                case "1101": hex += "D"; break;
                case "1110": hex += "E"; break;
                case "1111": hex += "F"; break;
                }
                bin = bin.Substring(0, bin.Length - 4);
                
            }
            // На остатък след цепенето добавяме нужния брой нули отпред
            switch (bin.Length)
            {
                case 0: bin = "0000"; break;
                case 1: bin = "000" + bin; break;
                case 2: bin = "00" + bin; break;
                case 3: bin = "0" + bin; break;
            }
            switch (bin)
            {
                case "0000": hex += "0"; break;
                case "0001": hex += "1"; break;
                case "0010": hex += "2"; break;
                case "0011": hex += "3"; break;
                case "0100": hex += "4"; break;
                case "0101": hex += "5"; break;
                case "0110": hex += "6"; break;
                case "0111": hex += "7"; break;
                case "1000": hex += "8"; break;
                case "1001": hex += "9"; break;
                case "1010": hex += "A"; break;
                case "1011": hex += "B"; break;
                case "1100": hex += "C"; break;
                case "1101": hex += "D"; break;
                case "1110": hex += "E"; break;
                case "1111": hex += "F"; break;
            }
            for(int k=hex.Length-1;k>=0;k++)
            Console.Write(hex[k]);
            Console.WriteLine();
        }



    }

}

