using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.StrategyDesignPattern
{
    class DuckCanFlySoHigh : IFlyStrategy
    {
        public void fly()
        {
            Console.WriteLine("This duck can fly so high");
        }
    }
}
