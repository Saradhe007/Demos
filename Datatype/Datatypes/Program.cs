using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 m_math = 50;
            Int32 m_science = 75;
            Int64 m_english = 90;

            Int64 total_mark = m_math + m_science + m_english;

            Console.WriteLine("Output Using Writeline");
            Console.WriteLine(m_math);
            Console.WriteLine(m_science);
            Console.WriteLine(m_english);

            //output with write method
            Console.Write("m_math");
            Console.Write(m_science);
            Console.Write(m_english);

            //formatting output with functions

            Console.WriteLine("\n Math \t Science \t English \t Total\n " + 
                "{0} \t {1} \t\t {2} \t\t {3}",m_math, m_science,m_english,total_mark);
            string tableformat = string.Format("\n\n Math \t Science \t English \t Total\n " +
                "{0} \t {1} \t\t {2} \t\t {3}", m_math, m_science, m_english, total_mark);
            Console.WriteLine(tableformat);

        }
    }
}
