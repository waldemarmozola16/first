using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty = string.Empty;
            string description = "Ola ma kota";
            Console.WriteLine(description);
            string description2 = description;
            description = "Kot ma ala";

            //Wniosek! Nie możemy
            
            Console.WriteLine(empty);
            Console.WriteLine(description);
            Console.WriteLine(description2);

           // Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(description));

            int indeks = 123456787;
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(indeks));

            Console.ReadKey();

        }
    }
}
