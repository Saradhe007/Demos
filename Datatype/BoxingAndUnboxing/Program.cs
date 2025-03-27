using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            //converting value type to reference type is boxing
            Int32 boxvalue = 789;
            object boxvalue2 = boxvalue;
            Console.WriteLine(boxvalue2);

            //converting reference type to value type is unboxing
            Int32 unboxvalue = (Int32)boxvalue2;
            Console.WriteLine(unboxvalue);
            Console.WriteLine("After Explicit conversion to unbox Value" + unboxvalue);

            unboxvalue = Convert.ToInt32(boxvalue2);

            Console.WriteLine("Conversion to unbox value using convert class" + unboxvalue);

            Console.ReadKey();



        }
    }
}
