using System;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Outputs a message, with an upper case option
        /// </summary>
        /// <param name="message"></param>
        static void OutputMessage(string message, bool inUpper = false)
        {
            if (inUpper)
                message = message.ToUpper();
            Console.WriteLine(message);
        }
        /// <summary>
        /// This is a classic test program, that prints hello world
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // specify message
            var message = "Hello World!";
            OutputMessage(message);
            
            Console.ReadLine();
        }
    }
}
