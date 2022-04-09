using System;

namespace Den.Class
{
    internal class Herbivore : Animal,IActionsAnimal
    {
        private int grassHungry;
        public int GrassHungry
        {
            get { return grassHungry; }
            set 
            {
                if (value < 0)
                {
                    grassHungry = 0;
                }
                else 
                { 
                    grassHungry = value; 
                }
            }
        }

        public Herbivore()
        {
            GrassHungry = 0;
        }
        public Herbivore(string name, int age) 
            : base(name, age)
        {
            GrassHungry = 0;
        }
        protected int HerbivoreHungryFibonacci(int value)
        {
            if (value == 0) return 0;
            if (value == 1) return 1;
            return HerbivoreHungryFibonacci(value - 1) + HerbivoreHungryFibonacci(value - 2);
        }
        public override void Live()
        {
            base.Live();
            GrassHungry++;
        }
        public override void Live(int days)
        {
            base.Live(days);
            GrassHungry += HerbivoreHungryFibonacci(days);
        }
        public void EatGrass()
        {

        }
        public void EatGrass(int count)
        {

            GrassHungry = GrassHungry >= count ? GrassHungry - count : 0;
        }
        public override string ToString()
        {
            return $"Herbivore.{base.ToString()}.Hungry={GrassHungry}";
        }

        public void Run()
        {
            GrassHungry += 2;
            Console.WriteLine($"{Name} пробежался");
        }

        public void Walk()
        {
            GrassHungry += 1;
            Console.WriteLine($"{Name} прошелся");
        }
    }
}
