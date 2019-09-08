using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabawaPętle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listInt = new int[] {1,2,3,4,5,6,7,8,9,10 };
            //i=0; i<9; 1


           

            List<int> list = new List<int>()
            {
                10,11,12,13,14,15,15
            };

            list.Add(1);
            list.Remove(15);
            list.OrderBy(x => x);

            foreach(int item in list.OrderByDescending(x=>x))
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadKey();
        }
    }
}
