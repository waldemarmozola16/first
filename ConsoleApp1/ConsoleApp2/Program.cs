using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //int var1 = 5;
            // int var2 = 6;
            Console.WriteLine("Podaj 1 liczbę:");
            string liczba1 = Console.ReadLine();
            int var1 = Convert.ToInt16(liczba1);

            Console.WriteLine("Podaj 2 liczbę:");
            string liczba2 = Console.ReadLine();
            int var2 = Convert.ToInt16(liczba2);

            int result = var1 + var2;
            //result.WriteLine()
            Console.WriteLine(result);
            // + 
            Console.WriteLine("Wynik dodawania wynosi:" + ( var1 + var2));
            Console.WriteLine($"Wynik dodawania wynosi: {var1 + var2}");
            Console.WriteLine("Wynik odejmowania wynosi:" + (var1 - var2));
            Console.WriteLine($"Wynik odejmowania wynosi: {var1 - var2}");
            Console.WriteLine("Wynik dzielenie wynosi:" + (var1 / var2));
            Console.WriteLine($"Wynik dzielenie wynosi: {var1 / var2}");
            Console.WriteLine($"Wynik mnozenie wynosi: {var1 * var2}");
            //Zadajemy pytanie czy to  prawda

            if(var2 == 0 || var1==0 )
            {
                Console.WriteLine("Nasz dzielni i dzielna nie moze być  0");
            }
            else
            {

            }
            double result2 = (double) var1 / var2;
            Console.WriteLine(result2);
            Console.ReadKey();
        }
    }
}
