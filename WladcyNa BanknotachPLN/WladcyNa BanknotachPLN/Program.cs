using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WladcyNa_BanknotachPLN
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
                {
                //wczytanie nominalu
                Console.WriteLine("Podaj nominał: ");
                string nominal = Console.ReadLine();
                int wartoscNominalu = Convert.ToInt16(nominal);
                //interpretacja nominalu - sprawdzenie

                switch (wartoscNominalu)
                {
                    case 10:
                        Console.WriteLine(" Na banknocie jest Mieszko I");
                        break;
                    case 20:
                        Console.WriteLine(" Na banknocie jest Bolesław Chrobry");
                        break;
                    case 50:
                        Console.WriteLine(" Na banknocie jest Kazimierz Wielki");
                        break;
                    case 100:
                        Console.WriteLine(" Na banknocie jest Władysław Jagiełło");
                        break;
                    case 200:
                        Console.WriteLine(" Na banknocie jest Zygmunt  III Waza");
                        break;
                    case 500:
                        Console.WriteLine(" Na banknocie jest Jan III Sobieski");
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego nominalu");
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
