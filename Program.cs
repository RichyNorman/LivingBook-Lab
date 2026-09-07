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

            //Основний цикл гри
            bool isRunning = true;
            location.Enter();

            while (isRunning)
            {
                Console.WriteLine("\nДоступні команди: look, talk, exit");
                Console.Write("Веди команду: ");
                string? command = Console.ReadLine()?.ToLower();

                switch (command)
                {
                    case "look":
                        location.Enter();
                        break;
                    
                    case "talk":
                        npc.Interact(player);
                        break;

                    case "exit":
                        isRunning = false;
                        Console.WriteLine("Ти залишаєш гру...");
                        break;

                    default:
                        Console.WriteLine("Невідома командаю спробуй ще раз.");
                        break;
                }

                // Показати інвентар гравця після кожної дій.
                Console.WriteLine("Інвентар гравця:");
                foreach (string item in player.Inventory)
                {
                    Console.WriteLine($"- {item}");
                }

                Console.WriteLine("\nГра завешена. Натисни Enter для виходу");
                Console.ReadLine();
           }
        }
    }
}