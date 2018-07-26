using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testService1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if (!DEBUG)
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new TestService()
            };
            ServiceBase.Run(ServicesToRun);
#else
            new Thread(delegate ()
            {
                TestService service = new TestService();
                service.Process();
            }).Start();
            while(true)
            {
                Thread.Sleep(340);
            }
#endif
        }
    }
}
