

namespace MagicDestroyers.Characters.SpellCasters
{
    using MagicDestroyers.Armor.Leather;
    using MagicDestroyers.Weapons.Blunt;

    public class Druid
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Leathervest bodyArmor;
        private Staff weapon;

        public string Faction
        {
            get
            {
                return faction;
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
                return name;
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
                return abilityPoints;
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
                return healthPoints;
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
        public Staff Weapon
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

        public Druid()
        {

        }

        public void Moonfire()
        {

        }

        public void Starburst()
        {

        }

        public void OneWithNature()
        {

        }
    }
}