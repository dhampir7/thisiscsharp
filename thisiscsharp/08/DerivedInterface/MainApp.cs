using System;

namespace DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine( "{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params O)
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(
                new FileLogger("MyLog.txt"));

            monitor.start();
        }
    }
}