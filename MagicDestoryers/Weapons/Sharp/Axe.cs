
namespace MagicDestroyers.Weapons.Sharp
{
    public class Axe
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value <= 0 && value >= 100)
                {
                    damage = value;
                }
            }
        }

        public Axe()
        {

        }

        public void HackNSlash()
        {

        }
    }

}