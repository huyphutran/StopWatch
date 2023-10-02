using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            Console.WriteLine("Press S to Start the stopwatch");
            Console.WriteLine("Press P to Stop the stopwatch");
            Console.WriteLine("Press Q to Start the stopwatch");

            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                char key = char.ToUpper(consoleKeyInfo.KeyChar);
                   switch (key)
                {
                    case 'S':
                            stopWatch.Start();
                        break;

                    case 'P':
                        stopWatch.Stop();
                        break;
                    case 'Q':
                        return;

                    default:
                        Console.WriteLine("Invalid please press the following key in Structure");
                        break;

                }
            }

        }
    }
}
