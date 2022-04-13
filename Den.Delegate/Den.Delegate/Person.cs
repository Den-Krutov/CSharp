using System;

namespace Den.Delegate
{
    internal class Person
    {
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
            Console.WriteLine($"{Name} поработал");
            if (check)
                return true; 
            else
                return false;
        }
    }
}
