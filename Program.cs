using PatternStrategy.Models;
using PatternStrategy.Services;
using System;

namespace PatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern Strategy");
            Console.WriteLine("------------------------------------\n");
            var info = new Info();
            info.name = "First Comunicate";
            info.email = "contato@myemail.com.br";
            info.phone = "55119999999";
            info.text = "Hello World!!!";

            var context = new Context();

            context.setStrategy(new SMSService());
            context.executeStrategy(info);
            Console.WriteLine("------------------------------------");
            context.setStrategy(new PrintService());
            context.executeStrategy(info);
            Console.WriteLine("------------------------------------");
            context.setStrategy(new EmailService());
            context.executeStrategy(info);
            Console.WriteLine("------------------------------------");
        }
    }
}
