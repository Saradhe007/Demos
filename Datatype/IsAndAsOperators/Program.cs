using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAndAsOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic average = 156.89F;
            Boolean inttype = average is Int32;
             bool floattype = average is float;
            Boolean stringtype = average is string;
            Boolean booltype = average is Boolean;

            if(inttype == true || inttype == false)
            {
                Console.WriteLine("is an integer-"+inttype);
            }
            if(floattype == true || floattype == false)
            {
                Console.WriteLine("is a float-" + floattype);
            }
            if(stringtype == true || stringtype == false)
            {
                Console.WriteLine("is a string-" + stringtype);
            }
            if (booltype == true || booltype == false)
            {
                Console.WriteLine("is a boolean-" + booltype);
            }
            if(average is char)
            {
                Console.WriteLine("is a char");
            }

            Console.ReadKey();
        }
    }
}
