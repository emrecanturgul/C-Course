using System;

namespace OOP3_
{
    class FileLoggerService : ILoggerService
    {
        public void Log(ICrediManager crediManager)
        {
            Console.WriteLine($"Log to File for {crediManager.Name()}");

        }
    }
}
