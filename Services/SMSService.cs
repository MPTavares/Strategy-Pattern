using PatternStrategy.Interfaces;
using PatternStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Services
{
    public class SMSService : IStrategy
    {
        public void Execute(Info info)
        {
            Console.WriteLine($"Sending SMS to {info.phone} with text: {info.text}");
        }
       
    }
}
