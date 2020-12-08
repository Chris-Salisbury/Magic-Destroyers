namespace MagicDestroyers.Characters.SpellCasters
{

    using MagicDestroyers.Weapons.Sharp;
    using MagicDestroyers.Armor.Leather;
    using System;

    public class Necromancer
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
                return this.faction;
            }

            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    this.faction = value;
                }
                else
                {
                    this.faction = "Spellcaster";
                    Console.WriteLine("inappropriate faction! Should be \"Melee\" or \"Spellcaster\"");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    this.name = "Necky";
                    Console.WriteLine("The name is too short or too long. Must be between 2 and 10 characters!");
                }
            }
        }

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    this.abilityPoints = 0;
                    Console.WriteLine("Inappropriate value! Ability points should be between 0 and 10!");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    this.healthPoints = 0;
                    Console.WriteLine("Inappropriate value! Health points should be between 1 and 100!");
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }

            set
            {
                if (value >= 1 && value <= 10)
                {
                    this.level = value;
                }
                else
                {
                    this.level = 1;
                    Console.WriteLine("Inappropriate value! Level points should be between 1 and 10!");
                }
            }
        }

        public Leathervest BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Sword Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Necromancer()
        {
            this.Name = "barry";
            this.Level = 1;
            this.HealthPoints = 100;
            this.Faction = "Spellcasters";
            this.AbilityPoints = 10;
            this.BodyArmor = new Leathervest();
            this.weapon = new Sword();
        }

        public Necromancer(string name, int level)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = 100;
            this.Faction = "Spellcasters";
            this.AbilityPoints = abilityPoints;
            this.BodyArmor = new Leathervest();
            this.weapon = new Sword();
        }

        public Necromancer(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = 100;
            this.Faction = "Spellcasters";
            this.AbilityPoints = abilityPoints;
            this.BodyArmor = new Leathervest();
            this.weapon = new Sword();
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampiricTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}