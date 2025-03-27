using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floatdatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 123.15F;
            double number2 = 5689.26D;
            decimal number3 = 89325.73M;


            Console.WriteLine("Input values for all floating type of variables");
            //parsing using convert class
            string numberfloat = Console.ReadLine();
            number=Convert.ToSingle(numberfloat);

            //parsing using parse method
            string numberdouble = Console.ReadLine();
            number2 = double.Parse(numberdouble);

            //parsing using parse method
            string numberdecimal = Console.ReadLine();
            number3 = decimal.Parse(numberdecimal);

            int number5=Int16.Parse(Console.ReadLine());
            Int32 number6 = Int32.Parse(Console.ReadLine());
            Int64 number7 = Convert.ToInt64(Console.ReadLine());

            //parsing string

            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            Console.ReadKey();
        }
    }
}
