
namespace MagicDestroyers.Armor.Cloth
{
    using System;

    public class ClothRobe
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }

            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.armorPoints = value;
                }
            }
        }

        public ClothRobe()
        {
            this.ArmorPoints = 10;
        }
    }

}