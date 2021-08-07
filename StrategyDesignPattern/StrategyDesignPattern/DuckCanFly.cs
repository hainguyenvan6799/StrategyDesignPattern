using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.StrategyDesignPattern
{
    class DuckCanFly : IFlyStrategy
    {
        public void fly()
        {
            Console.WriteLine("This duck can fly");
        }
    }
}
