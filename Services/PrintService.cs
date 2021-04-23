using PatternStrategy.Interfaces;
using PatternStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Services
{
    public class PrintService : IStrategy
    {
        public void Execute(Info info)
        {
            Console.WriteLine($"Printing text{info.text}");
            
        }
    }
}
