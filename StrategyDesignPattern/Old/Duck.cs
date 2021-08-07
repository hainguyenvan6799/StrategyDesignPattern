using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Old
{
    class Duck
    {
        private string _name;
                 
        public void setName(string name)
        {
            _name = name;
        } 

        public string getName()
        {
            return _name;
        }

        public void eat()
        {
            Console.WriteLine("Duck can eat");
        }

        public virtual void fly()
        {
            Console.WriteLine("Duck can fly in the sky");
        }
        // You have some child classes extends Duck class, but can not fly ( GrassDuck, PickDuck ), later if you want to change the text with the
        // Duck that can not fly, you have to go into each child classes and change many times. Later if you want to change again that is very
        // painful. And if you want to have a duck that fly so high or so low, it's so hard to add. So you need Strategy Design Pattern. 
    }
}
