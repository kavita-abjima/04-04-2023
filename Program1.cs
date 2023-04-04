using System;

namespace AccessSpecifires1
{
    public class Class1
    {
        public void Show1() {
            Console.WriteLine("this is public method");
        }

        protected void Show2()
        {
            Console.WriteLine("This is procted method");
        }

        internal void Show3()
        {
            Console.WriteLine("This is internal Method");
        }


    }

    //class Person:Class1   //want to use protected member of baseclass
    class Person
    {
       public static void Main(string[] args)
        {
            Class1 c= new Class1();
            c.Show1();
            Person p1 = new Person();
            // p1.Show2();
            c.Show3();
        }

    }
}
