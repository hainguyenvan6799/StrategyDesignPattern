using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.StrategyDesignPattern
{
    class Duck
    {
        private string _name;
        private IFlyStrategy _flyStrategy;

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetFlyStrategy(IFlyStrategy flyStrategy)
        {
            _flyStrategy = flyStrategy;
        }

        public IFlyStrategy GetFlyStrategy()
        {
            return _flyStrategy;
        }

        public Duck(string name, IFlyStrategy flyStrategy) 
        {
            _name = name;
            _flyStrategy = flyStrategy;
        }

        public Duck()
        {

        }

        public void ShowFlyable()
        {
            _flyStrategy.fly();
        }


    }
}
