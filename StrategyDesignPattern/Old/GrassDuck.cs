using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Old
{
    class GrassDuck: Duck
    {

        public override void fly()
        {
            Console.WriteLine("This bird can not fly");
        }
    }
}
