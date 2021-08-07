using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Old
{
    class PickDuck : Duck
    {
        public override void fly()
        {
            Console.WriteLine("This duck can not fly");
        }
    }
}
