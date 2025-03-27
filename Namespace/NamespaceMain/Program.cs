using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Namespace1;
using Namespace2;
using Namespace3;

namespace NamespaceMain
{
    class Program
    {
        static void Main(string[] args)
        {
           Namespace1.Math mathobj1 = new Namespace1.Math();
            Namespace2.Math mathobj2 = new Namespace2.Math();
            Namespace3.Math mathobj3 = new Namespace3.Math();

            Console.WriteLine(mathobj1);
            Console.WriteLine(mathobj2);
            Console.WriteLine(mathobj3);



        Namespace1.Math obj = new Namespace1.Math();
            Namespace2.Math obj1 = new Namespace2.Math();        }
    }
}
