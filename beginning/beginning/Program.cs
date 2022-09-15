using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace beginning
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------------------");

            int j = 0; 

            while (j < 7)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("------------------------------------------");

            int[] intArray = new []{ 1,2,3};
            foreach (var k in intArray)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("------------------------------------------");

            int l = 0;
            do
            {
                Console.WriteLine(l);
                l++;
            } while (l<15);

            Console.ReadKey();
        }
    }
}
