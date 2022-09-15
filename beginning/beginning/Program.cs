using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib mit ein Wort/satz");
            string entry = Console.ReadLine();

            string subEntry = entry.Substring(3,1);

            Console.WriteLine("old: " + entry + ":");
            Console.WriteLine("new: " + subEntry + ":");

            Console.ReadKey();
        }
    }
}
