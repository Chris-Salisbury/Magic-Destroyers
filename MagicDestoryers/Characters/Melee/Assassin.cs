

namespace MagicDestroyers.Characters.Melee
{

    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    public class Assassin
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Leathervest bodyArmor;
        private Sword weapon;

        public string Faction
        {
            get
            {
                return faction;
            }

            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    faction = value;
                }
                else
                {
                    Console.WriteLine("inappropriate faction! Should be \"Melee\" or \"Spellcaster\"");
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("The name is too short or too long. Must be between 2 and 10 characters!");
                }
            }
        }

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    abilityPoints = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value! Ability points should be between 0 and 10!");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }

            set
            {
                if (value >= 1 || value <= 100)
                {
                    HealthPoints = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value! Health points should be between 1 and 100!");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public Leathervest BodyArmor
        {
            get
            {
                return bodyArmor;
            }

            set
            {
                bodyArmor = value;
            }
        }
        public Sword Weapon
        {
            get
            {
                return weapon;
            }

            set
            {
                weapon = value;
            }
        }

        public Assassin()
        {

        }

        public void Raze()
        {

        }

        public void Bleed()
        {

        }

        public void Survival()
        {

        }
    }
}