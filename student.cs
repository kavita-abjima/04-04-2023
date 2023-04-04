using System;

namespace program
{
    class student
    {
        public string Name;
        public int Age;

        public student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }

        //dstructor
        ~student()
        {
            Console.WriteLine("Destructor has been invoked");

        }
        static void Main(string[] args)
        {
            student kvi = new student("kavita", 27);
            Console.WriteLine(kvi.getName());
            Console.WriteLine(kvi.getAge());
            // kvi = null;
            //GC.Collect();
            //Console.ReadLine();
            //Program kv = new Program("jhj", 78);
        }

    }
}
