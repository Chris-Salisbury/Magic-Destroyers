

namespace MagicDestroyers.Characters.Melee
{

    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Weapons.Sharp;

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
                return Faction;
            }

            set
            {
                faction = value;
            }
        }
        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                name = value;
            }
        }

        public int AbilityPoints
        {
            get
            {
                return AbilityPoints;
            }

            set
            {
                abilityPoints = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return HealthPoints;
            }

            set
            {
                healthPoints = value;
            }
        }
        public int Level
        {
            get
            {
                return Level;
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
                return BodyArmor;
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
                return Weapon;
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