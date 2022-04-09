using System;
namespace Den.Class
{
    internal class Predator : Animal,IActionsPredator
    {
        private int meatHungry;
        public int MeatHungry
        {
            get { return meatHungry; }
            set
            {
                if(value < 0)
                {
                    meatHungry = 0;
                }
                else
                {
                    meatHungry = value;
                }
            }
        }
        public int Energy
        {
            get
            {
                if (Days < 50)
                {
                    return (100 - MeatHungry) * Days;
                }
                else
                {
                    return (100 - MeatHungry) * (100 - Days);
                }
            }
        }
        public Predator()
        {
            MeatHungry = 0;
        }
        public Predator(string name, int age) 
            : base(name, age)
        {
            MeatHungry = 0;
        }
        public override void Live()
        {
            base.Live();
            MeatHungry++;
        }
        public override void Live(int days)
        {
            base.Live(days);
            MeatHungry += days;
        }
        public static Predator operator +(Predator animal1, Herbivore animal2)
        {
            animal1.MeatHungry -= 1;
            return animal1;
        }
        public static Predator operator +(Predator animal1, Predator animal2)
        {
            if (animal1 >= animal2)
            {
                animal1.MeatHungry -= 2;
                return animal1;
            }
            else
            {
                return animal1;
            }
        }
        public static bool operator >=(Predator animal1, Predator animal2)
        {
            if (animal1.Energy >= animal2.Energy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Predator animal1, Predator animal2)
        {
            if (animal1.Energy <= animal2.Energy)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            return $"Predator.{base.ToString()}.Hungry={MeatHungry}";
        }

        public void Run()
        {
            MeatHungry += 3;
            Console.WriteLine($"{Name} пробежался");
        }

        public void Walk()
        {
            MeatHungry += 2;
            Console.WriteLine($"{Name} прошелся");
        }

        public bool Hunt()
        {
            var random=new Random();
            if (random.Next(0,2)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
