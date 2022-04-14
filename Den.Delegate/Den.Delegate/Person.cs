using System;

namespace Den.Delegate
{
    internal class Person
    {
        public delegate void HomeHundler(string message);
        public event HomeHundler GoToWork;
        public string Name { get; set; }
        public Person(string name) { Name = name; }
        public void GetOutBed()
        {
            Console.WriteLine($"{Name} встал с кровати");
        }
        public void GetInBed()
        {
            Console.WriteLine($"{Name} лег в кровать");
        }
        public void BrushTeeth()
        {
            Console.WriteLine($"{Name} почистил зубы");
        }
        public void EatBreakfast()
        {
            Console.WriteLine($"{Name} позавтракал");
        }
        public void EatDinner()
        {
            Console.WriteLine($"{Name} поужинал");
        }
        public bool DoWork(bool check)
        {
            GoToWork?.Invoke("Дом закрыт");
            Console.WriteLine($"{Name} поработал");
            if (check)
            {
                GoToWork?.Invoke("Дом открыт");
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}
