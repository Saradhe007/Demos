using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndTryParseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //diferentiating Parse and Try parse method


            //using parse method
            Console.WriteLine("Input value for int32");

            Int32 number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result after parsing using parse method " + number);

            //Using Try parse method

            string input = Console.ReadLine();

            Int64 result;
            bool number2 = Int64.TryParse(input, out result);

            if (number2 == true)
            {
                Console.WriteLine("Result after parsing " + result);
            }
            else
            {
                Console.WriteLine("No input provided");
            }

            Console.ReadKey();


        }
    }
}
