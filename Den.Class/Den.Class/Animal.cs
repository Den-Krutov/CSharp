namespace Den.Class
{
    internal abstract class Animal
    {
        public string Name { get; protected set; }
        public int Days { get; private set; }
        public Animal()
        {
            Name = "Unknown";
            Days = 0;
        }
        public Animal(string name, int days)
        {
            Name = name;
            Days = days;
        }
        public virtual void Live()
        {
            Days++;
        }
        public virtual void Live(int days)
        {
            Days += days;
        }

        public override string ToString()
        {
            return $"{Name.ToString()}({Days.ToString()})";
        }
    }
}
