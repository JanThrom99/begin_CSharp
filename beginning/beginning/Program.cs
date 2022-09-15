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
            Console.WriteLine("wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("du kommst hier net rein");
            }
            else
            {
                Console.WriteLine("kommste rein kannste rausschauen ");
            }

            Console.ReadKey();
        }
    }
}
