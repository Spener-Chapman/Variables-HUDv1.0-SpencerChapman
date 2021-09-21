using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_HUDv1._0_SpencerChapman
{
    class Program
    {
        static void Main(string[] args)
        {
            float Score;
            int Health;
            int Lives;
            float ScoreMultiplier;
            int WeaponDurability;
            int ShieldDurability;
            float goblin;
            float goliath;
            float boar;
            int maxHealth;

            Score = 00000000.0f;
            Health = 100;
            Lives = 3;
            ScoreMultiplier = 1.0f;
            WeaponDurability = 100;
            ShieldDurability = 100;
            goblin = 50.0f;
            goliath = 100.0f;
            boar = 10.0f;
            maxHealth = 100;

            Console.WriteLine("A Last Ditch Efforts game");
            Console.WriteLine("");
            Console.WriteLine("////Deepest Depths////");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player enters the jungle");
            Console.WriteLine("Player encounters a goblin");
            Console.WriteLine("");
            Console.WriteLine("Goblin Strikes");
            Console.WriteLine("Player Strikes");
            Console.WriteLine("");
            Console.WriteLine("");
            Health = Health - 15;
            WeaponDurability = WeaponDurability - 3;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Goblin faints");
            Score = Score + goblin;
            Console.WriteLine("Player continues forward");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player encounters a chest");
            Console.WriteLine("There was a score totem inside");
            Console.WriteLine("Score gained is now upgraded");
            Console.WriteLine("");

            ScoreMultiplier = 1.2f;
            Console.WriteLine("Player continues forward");
            Console.WriteLine("Player encounters a stone goliath");
            Console.WriteLine("");

            Console.WriteLine("Goliath strikes");
            Console.WriteLine("Player blocks the attack");
            Console.WriteLine("");
            Console.WriteLine("Player attacks");
            Console.WriteLine("It misses");
            Console.WriteLine("");
            Console.WriteLine("");
            ShieldDurability = ShieldDurability - 24;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Goliath attacks");
            Console.WriteLine("Critical hit!");
            Console.WriteLine("");
            Console.WriteLine("");
            Health = Health - 75;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player Stikes");
            Console.WriteLine("It Lands!");
            Console.WriteLine("");
            Console.WriteLine("");
            WeaponDurability = WeaponDurability - 12;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Goliath stomps");
            Console.WriteLine("The player is stunned and cant move!");
            Console.WriteLine("");

            Console.WriteLine("Goliath strikes");
            Console.WriteLine("It lands! The player faints");
            Console.WriteLine("");
            Console.WriteLine("");

            Health = Health - 10;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");

            Health = 100;
            Lives = Lives - 1;
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.WriteLine("The player wakes up somewhere in the jungle");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Player encounters a Boar");
            Console.WriteLine("");
            Console.WriteLine("Boar charges!");
            Console.WriteLine("Boar connects their charge");
            Health = Health - 10;
            Console.WriteLine("Player attacks");
            Console.WriteLine("It connects!");
            Console.WriteLine("");
            Console.WriteLine("Boar is defeated");
            Console.WriteLine("");
            Console.WriteLine("");
            WeaponDurability = WeaponDurability - 4;
            Score = Score + boar * ScoreMultiplier;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player encounters a nymph");
            Console.WriteLine("Nymph heals the player");
            Console.WriteLine("");
            Console.WriteLine("player at max health");
            Console.WriteLine("");
            Console.WriteLine("");
            Health = maxHealth;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player re-encounters the Stone Goliath");
            Console.WriteLine("");
            Console.WriteLine("Goliath stomps");
            Console.WriteLine("Player dodges");
            Console.WriteLine("");
            Console.WriteLine("Player Strikes");
            Console.WriteLine("It lands!");
            WeaponDurability = WeaponDurability - 12;
            Console.WriteLine("");
            Console.WriteLine("Goliath swipes");
            Console.WriteLine("It connects!");
            Console.WriteLine("");
            Console.WriteLine("");
            Health = Health - 25;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player attacks");
            Console.WriteLine("Critical hit!");
            Console.WriteLine("");
            Console.WriteLine("Goliath crumbles to the ground");
            Console.WriteLine("");
            Console.WriteLine("");
            Score = Score + goliath * ScoreMultiplier;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player finds the treasure!");

            Console.ReadKey(true);


        }
    }
}
