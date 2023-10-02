using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StopWatch
    {
        private DateTime StartTime;
        private bool IsRunning;

        public void Start() {

            if(!IsRunning) {
                StartTime = DateTime.Now;
                IsRunning = true;
                Console.WriteLine($"Run time: {StartTime:HH:MM:SS.fff}");
            }
            else
            {
                Console.WriteLine("Stopwatch is already running.");
            }

        }
        public void Stop()
        {

            if (IsRunning)
            {
                IsRunning = false;
                TimeSpan _timeSpan = DateTime.Now - StartTime;
                Console.WriteLine($"Elapsed Time:{_timeSpan.TotalSeconds:F2} second");
               
            }

        }



        public void GetIntervalTime()
        {
                TimeSpan _timeSpan = DateTime.Now - StartTime;
                Console.WriteLine($"Elapsed Time:{_timeSpan.TotalSeconds:F2} second");
        }

    }
}
