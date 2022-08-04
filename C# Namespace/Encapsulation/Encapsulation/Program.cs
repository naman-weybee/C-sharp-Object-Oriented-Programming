using System;

namespace Encapsulation
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 30;
            student.Name = "jonas";
            student.Email = "jonas1979@gmail.com";
            Console.WriteLine("student Id: " + student.Id);
            Console.WriteLine("student Name: " + student.Name);
            Console.WriteLine("student Email: " + student.Email);
            Console.ReadLine();
        }
    }


    //class Balance
    //{
    //    int AccountBalance = 1000;
    //    public void SetBalance(int balance)
    //    {
    //        if(balance < 0)
    //        {
    //            Console.WriteLine("You can't Pass Nagative Value...!");
    //        }
    //        else
    //        {
    //        AccountBalance = balance;
    //        }
    //    }
    //    public void GetBalance()
    //    {
    //        Console.WriteLine("Your Account Balance is: " + AccountBalance);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Balance balance = new Balance();
    //        balance.SetBalance(-5000);
    //        balance.GetBalance();
    //        Console.ReadLine();
    //    }
    //}


    //class Balance
    //{
    //    int AccountBalance = 1000;
    //    public int MyBalance
    //    {
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                Console.WriteLine("You can't Pass Nagative Value...!");
    //            }
    //            else
    //            {
    //                AccountBalance = value;
    //            }
    //        }
    //        get
    //        {
    //            return AccountBalance;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Balance balance = new Balance();
    //        balance.MyBalance = -5000;
    //        Console.WriteLine("Your Account Balance is: " + balance.MyBalance);
    //        Console.ReadLine();
    //    }
    //}
}
