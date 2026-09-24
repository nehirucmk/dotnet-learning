using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_learning.Classes___Objects
{
    public class Player
    {
        public string username;
        public int health;
        public int level;

        public void TakeDamage(int damage)
        {
            health = health - damage;
            Console.WriteLine($"{username} took {damage} damage. remaining health point: {health}");

        }

        public void heal(int healing)
        {
            health = health + healing;
            Console.WriteLine($"{username} healed for {healing}. remaining health point: {health}");
        }
    }
}
