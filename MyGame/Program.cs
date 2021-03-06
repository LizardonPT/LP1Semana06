using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy("  heheh  ");
            Console.WriteLine(e1.GetName());
            Enemy loki = new Enemy("Loki");
            loki.SetName("     Grindalokki     ");
            Console.WriteLine($"Name is {loki.GetName()} and HP is {loki.GetHealth()}");

            Console.WriteLine("Insert number of enemies:");
            Console.Write("> ");
            int enemy_number = Convert.ToInt32(Console.ReadLine());

            Enemy[] enemy_list = new Enemy[enemy_number];

            for (int i = 0; i < enemy_number; i++)
            {
                Console.WriteLine($"Give a name to Enemy {i+1}:");
                Console.Write("> ");
                string name = Console.ReadLine();
                Enemy enemy = new Enemy(name);
                enemy_list[i] = enemy;
            }

            for (int i = 0; i < enemy_number; i++)
            {
                Console.WriteLine(enemy_list[i].GetName());
            }

            enemy_list[3].TakeDamage(33);
            enemy_list[3].PickupPowerUp(PowerUp.Shield, 25);
            enemy_list[2].TakeDamage(62);
            enemy_list[2].PickupPowerUp(PowerUp.Health, 50);

            Console.WriteLine($"{enemy_list[3].GetName()}. "
            + $"Shield: {enemy_list[3].GetShield()}; "
            + $"Health: {enemy_list[3].GetHealth()};");

            Console.WriteLine($"{enemy_list[2].GetName()}. "
            + $"Shield: {enemy_list[2].GetShield()}; "
            + $"Health: {enemy_list[2].GetHealth()};");

        }
    }
}
