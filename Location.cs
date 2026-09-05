namespace LivingBookLab
{
    internal class Location
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<NPC> Npcs {get; set; }

        public Location(string name, string description)
        {
            Name = name;
            Description = description;
            Npcs = new List<NPC>();
        }

        public void Enter()
        {
            Console.WriteLine($"Ви увійшли до локції: {Name}");
            Console.WriteLine(Description);

            if (Npcs.Count > 0)
            {
                Console.WriteLine($"Тут ти бачиш:  ");
                foreach (var npc in Npcs)
                {
                    Console.WriteLine($"- {npc.Name}");
                }
            }
        }
    }
}