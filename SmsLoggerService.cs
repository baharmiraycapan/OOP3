using System;

namespace OOP3;

public class SmsLoggerService: ILoggerService
{
    public void Log(){
        System.Console.WriteLine("Kredi başvurusunun SMS'i gönderildi.");
    }


}
