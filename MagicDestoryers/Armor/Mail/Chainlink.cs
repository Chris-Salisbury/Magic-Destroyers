
namespace MagicDestroyers.Armor.Mail
{
    using System;

    public class Chainlink
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

        public Chainlink()
        {
            throw new NotImplementedException();
        }
    }

}