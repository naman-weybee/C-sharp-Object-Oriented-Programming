using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public float salary = 60000;
    }
    public class Program : Employee
    {
        public float bonus = 10000;
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            Program emp1 = new Program();
            Console.WriteLine("Salary : " + emp1.salary);
            Console.WriteLine("Bonus : " + emp1.bonus);
            Console.ReadLine();
        }
    }

    //public class Employee
    //{
    //    public void Work()
    //    {
    //        Console.WriteLine("At Work...!");
    //    }
    //}
    //public class Program : Employee
    //{
    //    public void Hollyday()
    //    {
    //        Console.WriteLine("No Work Today...!");
    //    }
    //}
    //class NewProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Program emp1 = new Program();
    //        emp1.Work();
    //        emp1.Hollyday();
    //        Console.ReadLine();
    //    }
    //}

    //public class Grandpa
    //{
    //    public void First()
    //    {
    //        Console.WriteLine("Hi i am jonas");
    //    }
    //}
    //public class Father : Grandpa
    //{
    //    public void Second()
    //    {
    //        Console.WriteLine("Hi i am stive, son of jonas");
    //    }
    //}
    //public class Son : Father
    //{
    //    public void Third()
    //    {
    //        Console.WriteLine("Hi i am oggy, son of stive and grandson of jonas");
    //    }
    //}
    //class NewProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Son emp1 = new Son();
    //        emp1.First();
    //        emp1.Second();
    //        emp1.Third();
    //        Console.ReadLine();
    //    }
    //}
}
