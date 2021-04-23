using PatternStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Interfaces
{
    public interface IStrategy
    {
        public void Execute(Info info);
    }
}
