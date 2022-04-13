using System;

namespace Den.Delegate
{
    internal class Program
    {
        delegate void Morning();
        static void Main(string[] args)
        {
            Person person = new Person("Даня");
            Morning morningPerson = null;
            morningPerson?.Invoke();
            morningPerson += person.GetOutBed;
            morningPerson += person.EatBreakfast;
            morningPerson += person.BrushTeeth;
            morningPerson?.Invoke();
            Predicate<bool> work = new Predicate<bool>(person.DoWork);
            if (work(true))
            {
                Console.WriteLine("Работа завершена");
                Action eveningPerson = null;
                eveningPerson += person.EatDinner;
                eveningPerson += person.BrushTeeth;
                eveningPerson += person.GetInBed;
                eveningPerson();
            }
            Func<bool,bool> doWork = new Func<bool,bool>(person.DoWork);
            if (doWork(true))
            {
                Console.WriteLine("Работа завершена");
                Action eveningPerson = null;
                eveningPerson += person.EatDinner;
                eveningPerson += person.BrushTeeth;
                eveningPerson += person.GetInBed;
                eveningPerson();
            }
            Console.ReadKey();
        }
    }
}
