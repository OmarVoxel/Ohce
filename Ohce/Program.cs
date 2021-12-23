using System;

namespace Ohce
{
    class Program
    {
        static void Main(string[] args)
        {
            var echo = new Echo(args[0], new Clock());
            Console.WriteLine(echo.Answer());

            while (!echo.Stopped)
            {
                string word = Console.ReadLine();
                Console.WriteLine(echo.Reply(word));;
            }
                
            
        }
    }
}