using System;

namespace ConsoleApplication1.Session10
{
    internal class Calculator
    {
        event WriteLog WriteLogEvent;
        public void InvokeMethod()
        {
            WriteLogEvent += new WriteLog(Log);
        }

        void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    internal class ChildCalculator : Calculator
    {

    }
}
