using PatternStrategy.Interfaces;
using PatternStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Services
{
    public class EmailService : IStrategy
    {
        public void Execute(Info info)
        {
            Console.WriteLine($"Sending email to {info.email} with text{info.text}");
        }
    }
}
