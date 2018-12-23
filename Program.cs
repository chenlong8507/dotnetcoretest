using System;

namespace HelloDotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            System.Console.WriteLine("2");
            Console.ReadLine();

            Person person = new Person(){
                Id=1,
                Name="chenlong"
            };
            System.Console.WriteLine(person.Name);
            Console.ReadLine();
            
        }
    }
}
