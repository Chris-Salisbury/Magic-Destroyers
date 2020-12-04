
namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    public class Warrior
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Chainlink bodyArmor;
        private Axe weapon;

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
                    faction = "Melee";
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
                    name = "George";
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
                    abilityPoints = 0;
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
                if (value >= 1 && value <= 100)
                {
                    healthPoints = value;
                }
                else
                {
                    healthPoints = 0;
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
                if (value >= 1 && value <= 10)
                {
                    level = value;
                }
                else
                {
                    level = 1;
                    Console.WriteLine("Inappropriate value! Level points should be between 1 and 10!");
                }
            }
        }

        public Chainlink BodyArmor
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
        public Axe Weapon
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

        public Warrior()
        {
            
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}