

namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armor.Mail;
    using MagicDestroyers.Weapons.Blunt;

    public class Knight
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Chainlink bodyArmor;
        private Hammer weapon;

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
        public Hammer Weapon
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

        public Knight()
        {

        }

        public void HolyBlow()
        {

        }

        public void PurifySoul()
        {

        }

        public void RighteousWings()
        {

        }
    }
}