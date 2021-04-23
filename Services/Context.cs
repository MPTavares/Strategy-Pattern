using PatternStrategy.Interfaces;
using PatternStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Services
{
    public class Context
    {
        private IStrategy _strategy;
      
        public void setStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void executeStrategy(Info info)
        {
            _strategy.Execute(info);
        }
    }
}
