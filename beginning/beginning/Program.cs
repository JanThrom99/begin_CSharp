using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bitte gib deinen Namen ein");
            string userName = Console.ReadLine();
            Console.WriteLine("hallo "+userName);
            Console.ReadKey();
        }
    }
}
