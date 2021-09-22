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
            int death;
            float ScoreMultiplier;
            int WeaponDurability;
            int ShieldDurability;
            float nymphheal;
            float goblin;
            int goblinweapon;
            int goblindamage;
            float goliath;
            int goliathweapon;
            int goliathdamage;
            int goliathshield;
            int goliathcritical;
            int goliathstomp;
            float boar;
            int boardamage;
            int boarweapon;
            int maxHealth;
            float totem;

            Score = 0.0f;
            Health = 100;
            Lives = 3;
            ScoreMultiplier = 1.0f;
            WeaponDurability = 100;
            ShieldDurability = 100;
            goblin = 50.0f;
            goliath = 100.0f;
            boar = 10.0f;
            maxHealth = 100;
            goblindamage = 15;
            goblinweapon = 3;
            totem = 0.2f;
            goliathshield = 25;
            goliathcritical = 75;
            goliathweapon = 12;
            goliathstomp = 10;
            goliathdamage = 25;
            boardamage = 10;
            boarweapon = 3;
            death = 1;
            nymphheal = 10;

            Console.WriteLine("");
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
            Console.WriteLine("Goblin Strikes!");
            Console.WriteLine("Goblin deals " + goblindamage + " damage!");
            Console.WriteLine("");
            Console.WriteLine("Player Strikes");
            Console.WriteLine("Weapon loses " + goblinweapon + " durability");
            Console.WriteLine("");
            Health = Health - goblindamage;
            WeaponDurability = WeaponDurability - goblinweapon;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Goblin faints");
            Console.WriteLine("Player gains " +  goblin + " points");
            Console.WriteLine("");
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
            ScoreMultiplier = ScoreMultiplier + totem;
            Console.WriteLine("");
            Console.WriteLine("Score now has a " + ScoreMultiplier + " multiplier!");
            Console.WriteLine("");

            Console.WriteLine("Player continues forward");
            Console.WriteLine("");
            Console.WriteLine("Player encounters a stone goliath");
            Console.WriteLine("");

            Console.WriteLine("Goliath strikes");
            Console.WriteLine("Player blocks the attack");
            Console.WriteLine("");
            Console.WriteLine("Shield takes " + goliathshield + " points of damage!");
            Console.WriteLine("");
            Console.WriteLine("Player attacks");
            Console.WriteLine("It misses");
            Console.WriteLine("");
            Console.WriteLine("");
            ShieldDurability = ShieldDurability - goliathshield;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Goliath attacks");
            Console.WriteLine("Critical hit!");
            Console.WriteLine("");
            Console.WriteLine("Player takes " + goliathcritical + " points of damage!");
            Console.WriteLine("");
            Console.WriteLine("");
            Health = Health - goliathcritical;

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
            Console.WriteLine("Weapon loses " + goliathweapon + " durability");
            Console.WriteLine("");
            WeaponDurability = WeaponDurability - goliathweapon;

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

            Health = Health - goliathstomp;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");

            Health = maxHealth;
            Lives = Lives - death;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(Lives + " lives remaining");
            Console.WriteLine("");
            Console.WriteLine("The player wakes up somewhere in the jungle");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player encounters a Boar");
            Console.WriteLine("");
            Console.WriteLine("Boar charges!");
            Console.WriteLine("Boar connects their charge");
            Console.WriteLine("");
            Console.WriteLine("Player loses " + " points of health");
            Health = Health - boardamage;
            Console.WriteLine("Player attacks");
            Console.WriteLine("It connects!");
            Console.WriteLine("");
            Console.WriteLine("Weapon loses " + boarweapon + " points of durability");
            Console.WriteLine("");
            Console.WriteLine("Boar is defeated");
            Console.WriteLine("");
            Console.WriteLine("Player gains " + boar + " points");
            Console.WriteLine("");
            Console.WriteLine("");
            WeaponDurability = WeaponDurability - boarweapon;
            Score = Score + boar * ScoreMultiplier;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player encounters a nymph");
            Console.WriteLine("Nymph heals the player for " + nymphheal + " health points!");
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
            Console.WriteLine("");
            Console.WriteLine("Weapon loses " + goliathweapon + " durability");
            Console.WriteLine("");
            WeaponDurability = WeaponDurability - goliathweapon;
            Console.WriteLine("");
            Console.WriteLine("Goliath swipes");
            Console.WriteLine("It connects!");
            Console.WriteLine("");
            Console.WriteLine("Player loses " + goliathdamage + " points of health");
            Console.WriteLine("");
            Console.WriteLine("");
            Health = Health - goliathdamage;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player attacks");
            Console.WriteLine("Critical hit!");
            Console.WriteLine("");
            Console.WriteLine("Weapon loses " + goliathweapon + " points of durability");
            Console.WriteLine("");
            Console.WriteLine("Goliath crumbles to the ground");
            Console.WriteLine("");
            Console.WriteLine("Player gains " + goliath + " points!");
            Console.WriteLine("");
            Console.WriteLine("");

            Score = Score + goliath * ScoreMultiplier;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lives: " + Lives + "    " + "Score: " + Score);
            Console.WriteLine("Health: " + Health + " Weapon: " + WeaponDurability + " Shield: " + ShieldDurability);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player finds the lost treasure!");

            Console.ReadKey(true);


        }
    }
}
