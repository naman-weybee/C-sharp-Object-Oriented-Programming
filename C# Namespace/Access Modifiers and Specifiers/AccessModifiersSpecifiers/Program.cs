using System;

namespace AccessModifiersSpecifiers
{
    class PublicTest
    {
        public string name = "devvy jons";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicTest test = new PublicTest();
            Console.WriteLine("Hello " + test.name);
            test.Msg("jonny depp");
            Console.ReadLine();
        }
    }

    //class ProtectedTest
    //{
    //    protected string name = "devvy jons";
    //    protected void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ProtectedTest test = new ProtectedTest();
    //        Console.WriteLine("Hello " + test.name);
    //        test.Msg("jonny depp");
    //        Console.ReadLine();
    //    }
    //}

    //class ProtectedTest
    //{
    //    protected string name = "devvy jons";
    //    protected void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}
    //class Program : ProtectedTest
    //{
    //    static void Main(string[] args)
    //    {
    //        Program test = new Program();
    //        Console.WriteLine("Hello " + test.name);
    //        test.Msg("jonny depp");
    //        Console.ReadLine();
    //    }
    //}

    //class InternalTest
    //{
    //    internal string name = "devvy jons";
    //    internal void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        InternalTest test = new InternalTest();
    //        Console.WriteLine("Hello " + test.name);
    //        test.Msg("jonny depp");
    //        Console.ReadLine();
    //    }
    //}

    //class ProtectedInternalTest
    //{
    //    protected internal string name = "devvy jons";
    //    protected internal void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ProtectedInternalTest test = new ProtectedInternalTest();
    //        Console.WriteLine("Hello " + test.name);
    //        test.Msg("jonny depp");
    //        Console.ReadLine();
    //    }
    //}

    //class PrivateTest
    //{
    //    private string name = "devvy jons";
    //    private void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PrivateTest test = new PrivateTest();
    //        Console.WriteLine("Hello " + test.name);
    //        test.Msg("jonny depp");
    //        Console.ReadLine();
    //    }
    //}

    //class PrivateTest
    //{
    //    private string name = "devvy jons";
    //    private void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //}
    //class Program : PrivateTest
    //{
    //    static void Main(string[] args)
    //    {
    //        Program test = new Program();
    //        Console.WriteLine("Hello " + test.name);
    //        test.Msg("jonny depp");
    //        Console.ReadLine();
    //    }
    //}

    //class PrivateTest
    //{
    //    private string name = "devvy jons";
    //    private void Msg(string msg)
    //    {
    //        Console.WriteLine("Hello " + msg);
    //    }
    //    static void Main(string[] args)
    //    {
    //        PrivateTest test = new PrivateTest();
    //        Console.WriteLine("Hello " + test.name);
    //        test.Msg("jonny depp");
    //        Console.ReadLine();
    //    }
    //}
}
