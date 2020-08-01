using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            try
            {
                int y = 0;
                x /= y;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Message: {0}",e.Message);
                Console.WriteLine("Source: {0}",e.Source);
                Console.WriteLine("StackTrace: {0}",e.StackTrace);
                Console.WriteLine("请重新输入");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine($"{x} / {y} = {x / y}");
                Console.WriteLine("Handling all exceptions - Keep on Running");
            }
        }
    }
}
