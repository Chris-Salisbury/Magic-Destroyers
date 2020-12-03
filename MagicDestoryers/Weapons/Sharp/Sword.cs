
namespace MagicDestroyers.Weapons.Sharp
{
    public class Sword
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

        public Sword()
        {

        }

        public void Bloodthirst()
        {

        }
    }

}