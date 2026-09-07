using System;
using System.Collections.Generic;

namespace LivingBookLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створюємо гравця
            Player player = new Player("Річард");

            // Створюємо NPC
            NPC npc = new NPC("Старий сторож", "охоронець",
                "Привіт, мандрівнику! Чи допоможеш мені знайти загублений ключ?");

            // Створюємо локацію
            Location location = new Location("Стара таверна",
                "Темна кімната з дерев'яними столами та запахом старого вина");
            location.Npcs.Add(npc);

            // Гравець входить у локацію
            location.Enter();

            // Взаємодія з NPC
            Console.WriteLine("Введи команду: talk");
            string? command = Console.ReadLine();

            if (command?.ToLower() == "talk")
            {
                npc.Interact(player);
            }
            else
            {
                Console.WriteLine("Невідома команда.");
            }
            
            // Показати інвентар після взаємодії
            Console.WriteLine("Інвентар гравця:");
            foreach (var item in player.Inventory)
            {
                Console.WriteLine($"- {item}");
            }

            Console.WriteLine("\nГра завершена. Натисни Enter для виходу.");
            Console.ReadLine();
        }
    }
}