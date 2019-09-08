using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {;
            Console.WriteLine(" Podaj 1 liczbe: ");
            string liczba1 = Console.ReadLine();
            int var1 = int.Parse(liczba1);

            Console.WriteLine(" Podaj 2 liczbe: ");
            string liczba2 = Console.ReadLine();
            int var2 = int.Parse(liczba2);

            while(var1 != var2)
            {
                if(var1>var2)
                {
                    var1 -= var2;
                }else
                {
                    var2 -= var1;
                }
            }

            Console.WriteLine($"NWD wynosi {var1}");
            Console.ReadKey();
        }
    }
}
