using System;

namespace LearnRx.Infrastructure
{
    public class ConsoleLogger : ILogger
    {
        public void Log(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}