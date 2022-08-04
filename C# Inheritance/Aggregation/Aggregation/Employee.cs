using System;

namespace Aggregation
{
    public class Address
    {
        public string addressline, city, state;
        public Address(string addressline, string city, string state)
        {
            this.addressline = addressline;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Address address;
        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + address.addressline + ", " + address.city + ", " + address.state);
        }
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("GJ03 Section-A", "Rajkot", "Gujarat");
            Employee emp1 = new Employee(23, "jonas", a1);
            emp1.display();
            Console.ReadLine();
        }
    }
}
