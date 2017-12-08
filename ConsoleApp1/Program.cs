using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> list1 = new List<Class1>();

            Class1 a1 = new Class1("aaaa", "bbbb", 15);
            Class1 a4 = new Class1("derp", "notderp", 99);
            Class1 a2 = new Class1("gqwogjp", "wqkhgnklew",2);
            Class1 a3 = new Class1("derp", "notderp", 3);

            list1.Add(a1);
            list1.Add(a2);
            list1.Add(a3);
            list1.Add(a4);

            Class2 m1 = new Class2();

            List<Class1> list2 = m1.report(list1); // Create new list call list2 with the information from processed list1

            foreach (Class1 x in list2)
            {
                Console.WriteLine(x.index_me + " " + x.cid);
            }

            Console.ReadKey(true);
        }
        

    }
}
