using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testService1
{
    public partial class TestService : ServiceBase
    {
        Stopwatch timer = new Stopwatch();

        Thread thd = null;

        public TestService()
        {
            InitializeComponent();
        }

        public void Process()
        {
            String[] debugArray = new String[1];
            debugArray[0] = "debug";
            
            OnStart(debugArray);
        }

        protected override void OnStart(string[] args)
        {
            thd = new Thread(new ThreadStart(InitWebService));
            thd.Start();
            timer.Start();
            
        }

        protected override void OnStop()
        {
            timer.Stop();
            TimeSpan ts = timer.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            ManagerLib.Utils.LogService("Uptime : " + elapsedTime);

            UnInitWebService();
        }

        private void InitWebService()
        {
            UnInitWebService();

            try
            {
                Server.Listener service = new Server.Listener();

                //Check if valid connection (response == OK)

                //Then Add HostName to historic
            }
            catch(Exception ex)
            {
                ManagerLib.Utils.LogService("InitWebService error : " + ex.Message);
            }
        }

        
        private void UnInitWebService()
        {
            try
            {
                if (false) //Temporary dirty stuff - keeping functions Init/UnInit in case of extended features on Startup/Exit
                {
                    thd.Abort();
                    thd = null;
                }
            }
            catch(Exception ex)
            {
                ManagerLib.Utils.LogService("UnInitWebService error : " + ex.Message);
            }

            ManagerLib.Utils.LogService("UnInitWebService finished");
        }
    }
}
