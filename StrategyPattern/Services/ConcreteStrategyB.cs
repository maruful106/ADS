﻿using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services
{
    internal class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing Concrete Strategy B");
        }
    }
}
