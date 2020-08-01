using System;
using MyLibrary;
namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 class1 = new Class1();
            int a = Class1.Sum(class1);
            Console.WriteLine(a);
        }
    }
}
