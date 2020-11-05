using System;

namespace ConsoleCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var name=Console.ReadLine(); 
            Console.WriteLine(ClassLibTest.Class1.DisplayGreeting(name));
        }
    }
}
