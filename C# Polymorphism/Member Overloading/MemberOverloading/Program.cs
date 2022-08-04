using System;

namespace MemberOverloading
{
    public class Program
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.add(2, 3));
            Console.WriteLine(Program.add(2, 3, 4));
            Console.ReadLine();
        }
    }

    //public class Program
    //{
    //    public static int add(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //    public static float add(float a, float b, float c)
    //    {
    //        return a + b + c;
    //    }
    //}
    //class NewProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(Program.add(2, 3, 5));
    //        Console.WriteLine(Program.add(20f, 30f, 50f));
    //        Console.ReadLine();
    //    }
    //}
}
