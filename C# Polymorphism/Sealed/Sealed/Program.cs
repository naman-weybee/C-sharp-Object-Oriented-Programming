using System;

namespace Sealed
{
    sealed public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...!");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            Console.ReadLine();
        }
    }

    //public class Animal
    //{
    //    public virtual void Eat()
    //    {
    //        Console.WriteLine("Eating...!");
    //    }
    //    public virtual void Run()
    //    {
    //        Console.WriteLine("Running...!");
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eating Bread...!");
    //    }
    //    public sealed override void Run()
    //    {
    //        Console.WriteLine("Running Fast...!");
    //    }
    //}
    //public class BabyDog : Dog
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eating Biscuit...!");
    //    }
    //    public override void Run()
    //    {
    //        Console.WriteLine("Running Slowly...!");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BabyDog babydog = new BabyDog();
    //        babydog.Eat();
    //        babydog.Run();
    //        Console.ReadLine();
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        sealed int x = 10;
    //        x++;  
    //        Console.WriteLine(x);  
    //        Console.ReadLine();
    //    }
    //}
}
