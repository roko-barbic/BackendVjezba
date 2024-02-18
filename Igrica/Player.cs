using System;
using System.Collections.Generic;
using System.Text;

namespace Igrica
{
    class Player
    {
        public int HealthPercentage { get; set; }
        public int Health { get; set; }
        public int CurrentHealth { get; set; }
        public String Name { get; set; }
        public Player()
        {
            Name = "noob";
            Health = 1;
            CurrentHealth = Health;
        }

        public Player(int health, string name)
        {
            Health = health;
            Name = name;
            CurrentHealth = health;
        }
        public void Attack(Player enemyPlayer)
        {
            Random random = new Random();
            int attackDmg = random.Next() % 100;
            enemyPlayer.CurrentHealth -= attackDmg;
            enemyPlayer.CalculatePerc();
            if (enemyPlayer.CurrentHealth <= 0)
                enemyPlayer.CurrentHealth = 0;
            Console.WriteLine(Name + " attacks " + enemyPlayer.Name + " => " + attackDmg + " damage");
        }
        public void CalculatePerc()
        {
            HealthPercentage = (int)(CurrentHealth / Health) * 100;
        }

    }
}
