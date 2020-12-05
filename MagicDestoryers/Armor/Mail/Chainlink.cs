
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

        public Chainlink()
        {
            throw new NotImplementedException();
        }
    }

}