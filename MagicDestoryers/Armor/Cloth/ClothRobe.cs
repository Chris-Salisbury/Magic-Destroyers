
namespace MagicDestroyers.Armor.Cloth
{
    public class ClothRobe
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

        public ClothRobe()
        {

        }
    }

}