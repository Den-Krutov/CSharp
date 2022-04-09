using System;

namespace Den.Class
{


    internal class WorldAnimals
    {
        static void Main(string[] args)
        {
            var animal1 = new Predator("Wolf",3);
            var animal2 = new Herbivore("Cow",2);
            var animal3 = new Predator("Bear", 3);
            var animal4 = new Herbivore("Sheep", 1);
            Console.WriteLine(animal1);
            Console.WriteLine(animal2);
            animal1.Live(2);
            animal2.Live(8);
            Console.WriteLine(animal1);
            Console.WriteLine(animal2);
            animal2.EatGrass(3);
            Console.WriteLine(animal2);
            animal1 += animal2;
            Console.WriteLine(animal1);
            animal1 += animal3;
            Console.WriteLine(animal1);
            var animalReproductionPredator = new AnimalReproduction<Predator>();
            var animal5 = animalReproductionPredator.reproduction(animal1, animal3);
            Console.WriteLine(animal5);
            var animalReproductionHerbivore = new AnimalReproduction<Herbivore>();
            var animal6 = animalReproductionHerbivore.reproduction(animal2, animal4);
            Console.WriteLine(animal6);
            animal1.Run();
            animal2.Walk();
            animal6.Run();
            Console.WriteLine(animal1);
            Console.WriteLine(animal1.Hunt());
            Console.ReadKey();
        }
    }
}
