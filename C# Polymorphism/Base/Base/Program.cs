using System;

namespace Base
{
    public class Animal
    {
        public string color = "Black";
    }
    public class Dog : Animal
    {
        string color = "White";
        public void display()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.display();
            Console.ReadLine();
        }
    }

    //public class Animal
    //{
    //    public virtual void Eat()
    //    {
    //        Console.WriteLine("Eating...!");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public override void Eat()
    //    {
    //        base.Eat();
    //        Console.WriteLine("Eating Bread...!");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Dog d = new Dog();
    //        d.Eat();
    //        Console.ReadLine();
    //    }
    //}

    //public class Animal
    //{
    //    public Animal()
    //    {
    //        Console.WriteLine("Animal...!");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public Dog()
    //    {
    //        Console.WriteLine("Dog...!");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Dog dog = new Dog();
    //        Console.ReadLine();
    //    }
    //}
}
