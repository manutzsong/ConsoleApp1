using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {

        
        public List<Class1> report(List<Class1> list1)
        {
            list1 = list1.OrderByDescending(x => x.index_me).ToList();
            return list1;
        }
       


    }
}
