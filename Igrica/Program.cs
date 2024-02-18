using System;

namespace Igrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1000, "Player One");
            Player player2 = new Player(599, "Player Two");
            do
            {
                player1.Attack(player2);
                if(player2.CurrentHealth > 0)
                {
                    player2.Attack(player1);
                }
            } while (player1.CurrentHealth > 0 && player2.CurrentHealth > 0);
            Console.WriteLine(player1.Name + " " + player1.CurrentHealth + " vs " + player2.Name + " " + player2.CurrentHealth);
            Console.WriteLine(player1.CurrentHealth == 0 ? player1.Name : player2.Name + " you Lose! ");
            Console.ReadKey();
        }
        
    }
}
