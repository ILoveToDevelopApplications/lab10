using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {

           //private static double radius;

            Console.WriteLine("\nWelcome to the Circle Tester");

            bool toContinue = false;
         
           while(toContinue)
          {

             try
                {
             

                    var cicumference = new Circle(radius);
                    var area  = new Circle(radius);
                    var areaResult = area.CalculateArea();
                    var circumferenceResult = circumferenceResult.CalculatedFormatted();

                }
                catch(Exception e)
                {


                    Console.WriteLine(e.Messege);

                }


                Console.WriteLine("Contine y/n\t/");

                var restart = char.ToLower(Console.ReadKey().KeyChar);

                if (restart == 'y')
                {
                    toContinue = true;

                }

           }

            
  

            Console.ReadKey();
        }
    }
}
