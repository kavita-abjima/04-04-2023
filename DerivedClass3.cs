using INHERITANCE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class DerivedClass3:VisitingEmployee
    {
        public void show3()
        {
            Console.WriteLine("Method of third derive class");
        }
    }
}
