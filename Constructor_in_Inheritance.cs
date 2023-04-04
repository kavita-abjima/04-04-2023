using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_in_Inheritance
{
    class BaseClass
    {
        public BaseClass(string message){
            Console.WriteLine(message);
        }
    }

    class DerivedClass:BaseClass
    {
        public DerivedClass():base("Hello C#")
        {
            Console.WriteLine("This is the constructor of DerivedClass");

        }
    }

    
}
