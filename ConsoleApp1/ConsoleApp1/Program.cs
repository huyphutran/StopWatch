using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static StopWatch stopWatch = new StopWatch();
        private static bool _run = false;

        static void Main(string[] args)
        {
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
                        if (!_run)
                        {
                            _run = true;
                            StartStopwatch();
                        }
                        break;

                    case 'P':
                        _run = false;
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
        static void StartStopwatch()
        {
            var stopwatchThread = new Thread(() =>
            {
                stopWatch.Start();
                while (_run)
                {
                    stopWatch.GetIntervalTime();
                    Thread.Sleep(1000);
                }
            });
            stopwatchThread.Start();
        }
    }
}
