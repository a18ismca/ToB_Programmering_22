using System;
using System.Collections.Generic;
using System.Text;

namespace ToB2
{
    public class Battle
    {
        public Character player, opponent;
        public void CreatePlayer()
        {
            Random rnd = new Random();
            Console.Write("Enter player name: ");
            string characterName = Console.ReadLine();
            player = new Character() { Name = characterName, Strength = rnd.Next(20,40), Health = 100};
            Console.WriteLine("Player " + player.Name + " created. Health: " + player.Health + ". Strength: " + player.Strength);
            CreateOpponents();
        }

        public void CreateOpponents()
        {
            Console.WriteLine("Your opponent: ");
            Random rnd = new Random();
            
               opponent = new Character() { Name = "Opponent", Strength = rnd.Next(20,40), Health = 100 };
                Console.WriteLine("New opponent created. \n Strength: " + opponent.Strength + "\n Health: " + opponent.Health);
            

        }

        public bool IsAlive()
        {
            return player.Health > 0 || opponent.Health > 0;
        }

        public void RollDice(int dots)
        {

        }
        public void Result()
        {
            if (!IsAlive())
            {
                if(opponent.Health < 0)
                {
                    Console.WriteLine("You have won this battle");
                }
                else if (player.Health < 0)
                {
                    Console.WriteLine("You have lost this battle");

                }
            }
        }

        public void PlayingGame()
        {

        }

        /*public void PlayingBattle()
        {
           while(IsAlive(player) && IsAlive(opponent))
            {
                
            }
        }

        public bool IsAlive(Character character)
        {
            return character.Health > 0;
        }

        public void DepleteHealth()
        {

        }

        public void Result(Character player, Character opponent)
        {
            if(opponent.Health < 0)
            {
                Console.WriteLine("You have won this round!");
                opponent.Health = 0;
            }
            else if(player.Health < 0)
            {
                Console.WriteLine("You have lost this round!");
                opponent.Health = 0;
            }
        }*/

       

       
    }
}

