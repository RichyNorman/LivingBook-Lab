namespace LivingBookLab
{
    internal class Player
    {
        // Властивості
        public string Name { get; set; }
        public int Health { get; set; }
        public List<string> Inventory {get; set;}

        public Player(string name)
        {
            Name = name;
            Health = 100; // Початкове здоров'я
            Inventory = new List<string>(); // Початковий інвентар
        }

        // Метод дфї
        public void PerformAction(string action)
        {
            Console.WriteLine($"{Name} виконує дію: {action}");
        }
    }
}