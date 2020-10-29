using System;

namespace ConsoleApp1
{
    class Program
    {
       /// <summary>
       /// Outputs a message
       /// </summary>
       /// <param name="message"></param>
        static void OutputMessage(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// This is a classic test program, that prints hello world
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var message = "Hello World!";
            OutputMessage(message);
            
            Console.ReadLine();
        }
    }
}
