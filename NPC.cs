namespace LivingBookLab
{
    internal class NPC
    {
        // Властивості
        public string Name { get; set; }
        public string Role { get; set; }
        public string Dialogue { get; set; }

        // Конструктор
        public NPC(string name, string role, string dialogue)
        {
            Name = name;
            Role = role;
            Dialogue = dialogue;
        }

        // Метод взаємодії
        public void Interact(Player player)
        {
            Console.WriteLine($"{Name} ({Role}) каже: {Dialogue}");

            Console.WriteLine("Вибір: [1] Відповісти позитивно, [2] Відповісти негативно");
            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine($"{player.Name} погоджується допомогти {Name}.");
                player.Inventory.Add("Маленький ключ");
                Console.WriteLine("Ти отримав предмет: Маленький ключ!");
            }
            else
            {
                Console.WriteLine($"{player.Name} відмовляється від допомоги.");
            }
        }
    }
}
