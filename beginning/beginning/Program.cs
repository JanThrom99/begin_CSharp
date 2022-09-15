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
            //asking the user how old he is
            Console.WriteLine("wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());

            // check whether the user can enter the club or has to stay outside 
            if (age > 18)
            {
                //check whether the user needs to show his ID or nor 
                if (age >28)
                {
                    Console.WriteLine("kommste rein kannste rausschauen");
                }
                else
                {
                    Console.WriteLine("ausweis bidde");
                }
            }
            else
            {
                Console.WriteLine("geh weg");
            }

            Console.ReadKey();
        }
    }
}
