using System;

namespace OOP3_
{
    class SmsLoggerService:ILoggerService { 
        public void Log(ICrediManager crediManager)
        {
            Console.WriteLine($"Sms atıldı for {crediManager.Name()} ");
        }
    }
}
