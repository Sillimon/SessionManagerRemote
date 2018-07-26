using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testService1
{
    class MyServer
    {
        public void start()
        {

        }

        public void stop()
        {

        }

        private static string CurrentCPUUsage
        {
            get
            {
                PerformanceCounter cpuCounter;
                cpuCounter = new PerformanceCounter();
                cpuCounter.CategoryName = "Processor";
                cpuCounter.CounterName = "% Processor Time";
                cpuCounter.InstanceName = "_Total";
                return cpuCounter.NextValue() + "%";
            }
        }
    }
}
