using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating Bread...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Eat();
            Console.ReadLine();
        }
    }
}
