using StrategyDesignPattern.StrategyDesignPattern;
using System;

namespace StrategyDesignPattern
{
    class Program
    {        
        public static void GenerateFlyStrategy(Random rand, Duck duck)
        {
            int randomNumber = rand.Next(0, 4);
            switch (randomNumber)
            {
                case 0:
                    duck.SetName("GrassDuck");
                    duck.SetFlyStrategy(new DuckCanNotFly());
                    break;
                case 1:
                    duck.SetName("SkyDuck");
                    duck.SetFlyStrategy(new DuckCanFly());
                    break;
                case 2:
                    duck.SetName("HighDuck");
                    duck.SetFlyStrategy(new DuckCanFlySoHigh());
                    break;
                case 3:
                    duck.SetName("LowDuck");
                    duck.SetFlyStrategy(new DuckCanFlySoLow());
                    break;
                default:
                    Console.WriteLine("Something wrongs");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            for (int i = 1; i <= 5; i++)
            {
                
                var duck = new Duck();
                GenerateFlyStrategy(rand, duck);
                duck.ShowFlyable();
                Console.WriteLine(duck.GetFlyStrategy().GetType().Name);

                //You can also change in run time
                GenerateFlyStrategy(rand, duck);
                duck.ShowFlyable();
                Console.WriteLine(duck.GetFlyStrategy().GetType().Name);
            }
        }
    }
}
