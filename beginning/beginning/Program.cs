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

            string replaced_entry = entry.Replace("U", "G").Replace("u", "g");

            Console.WriteLine("der alte Text war: "+entry);
            Console.WriteLine("der neue Text ist: " + replaced_entry);

            Console.ReadKey();
        }
    }
}
