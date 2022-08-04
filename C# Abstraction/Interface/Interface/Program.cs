using System;

namespace Interface
{
    public interface Shape
    {
        void Draw();
    }
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle...!");
        }
    }
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle...!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.Draw();
            s = new Circle();
            s.Draw();
            Console.ReadLine();
        }
    }
}
