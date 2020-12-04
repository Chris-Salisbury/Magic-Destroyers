
namespace MagicDestroyers.Armor.Leather
{
    using System;
    public class Leathervest
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return ArmorPoints;
            }

            set
            {
                if (value >= 1 && value <= 100)
                {
                    armorPoints = value;
                }
            }
        }

        public Leathervest()
        {
            throw new NotImplementedException();
        }
    }

}