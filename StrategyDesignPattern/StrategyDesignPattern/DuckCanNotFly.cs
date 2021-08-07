using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.StrategyDesignPattern
{
    class DuckCanNotFly : IFlyStrategy
    {
        public void fly()
        {
            Console.WriteLine("This duck can not fly");
        }
    }
}
