using System;

namespace Polymorphism
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Eat();
            Console.ReadLine();
        }
    }

    //public class Shape
    //{
    //    public virtual void Draw()
    //    {
    //        Console.WriteLine("Drawing...");
    //    }
    //}
    //public class Rectangle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Drawing Rectangle...");
    //    }
    //}
    //public class Circle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Drawing Circle...");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Shape s;
    //        s = new Shape();
    //        s.Draw();
    //        s = new Rectangle();
    //        s.Draw();
    //        s = new Circle();
    //        s.Draw();
    //        Console.ReadLine();
    //    }
    //}

    //public class Animal
    //{
    //    public string color = "white";
    //}
    //public class Dog : Animal
    //{
    //    public string color = "Black";
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Animal dog = new Dog();
    //        Console.WriteLine(dog.color);
    //        Console.ReadLine();
    //    }
    //}
}
