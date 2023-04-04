using Constructor_in_Inheritance;
using Inheritance2;
using System;

namespace INHERITANCE
{

    class Employee
    {
        public int EmpId;
        public string Name;
        public int ContactNo;
        public int Age;

        public void Show() {
            Console.WriteLine("This is the method of baseclass");
        }

    }

    class PermanenetEmployee : Employee
    {
        public int PermanentSalary;
        public int PermanentHours;
        public void Show1()
        {

            Console.WriteLine("This is the method of IntermidiateClass");
        }


    }
    class VisitingEmployee : PermanenetEmployee
    {
        public int VisitingSalary;
        public int VisitingHours;

        public void Show2()
        {

            Console.WriteLine("This is the method of derived class");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            PermanenetEmployee Kavita = new PermanenetEmployee();
            Kavita.EmpId = 23;
            VisitingEmployee Soniya = new VisitingEmployee();
            Soniya.EmpId = 34;
            DerivedClass3 Kavya = new DerivedClass3();
            Console.WriteLine(Kavita.EmpId);
            Console.WriteLine(Soniya.EmpId);
            Kavita.Show();
            Soniya.Show();
            Soniya.Show1();
            Soniya.Show2();

            Kavya.show3();
        
                DerivedClass obj1 = new DerivedClass(); //calling constructors


    }
    }
}



