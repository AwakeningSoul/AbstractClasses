using System;

namespace AbstractClasses
{
       class Program
        {
        static void Main(string[] args)
        {
            //Inside the Main() method, instantiate an Employee object 
            Employee sam = new Employee() { firstName = "Sample", lastName = " Student" };
            //Call the SayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }   
}

