
namespace Den.Class
{
    internal class AnimalReproduction<TAnimal>
        where TAnimal:Animal, new()
    {
        public TAnimal reproduction(TAnimal animal1,TAnimal animal2)
        {
            // TODO: Ребенку присвоить имя родителей
            return new TAnimal();
        }
    }
}
