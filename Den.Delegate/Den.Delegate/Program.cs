using System;

namespace Den.Delegate
{
    internal class Program
    {
        delegate void Morning();
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void DisplayMessage(object person, EventArgs e)
        {
            if (person is Person)
            {
                Console.WriteLine($"Что то случилось c хозяином-{((Person)person).Name}!"); ;
            }
        }
        static void DisplayBlueMessage(string message) 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Person person = new Person("Даня");
            person.GoToWork += DisplayMessage;
            person.GoToWork += DisplayBlueMessage;
            person.SleepToWork += DisplayMessage;
            Morning morningPerson = null;
            morningPerson?.Invoke();
            morningPerson += person.GetOutBed;
            morningPerson += person.EatBreakfast;
            morningPerson += person.BrushTeeth;
            morningPerson?.Invoke();
            Predicate<bool> work = new Predicate<bool>(person.DoWork);
            if (work(false))
            {
                Console.WriteLine("Работа завершена");
                Action eveningPerson = null;
                eveningPerson += person.EatDinner;
                eveningPerson += person.BrushTeeth;
                eveningPerson += person.GetInBed;
                eveningPerson();
            }
            //Func<bool,bool> doWork = new Func<bool,bool>(person.DoWork);
            //if (doWork(true))
            //{
            //    Console.WriteLine("Работа завершена");
            //    Action eveningPerson = null;
            //    eveningPerson += person.EatDinner;
            //    eveningPerson += person.BrushTeeth;
            //    eveningPerson += person.GetInBed;
            //    eveningPerson();
            //}

            Console.ReadKey();
        }
    }
}
