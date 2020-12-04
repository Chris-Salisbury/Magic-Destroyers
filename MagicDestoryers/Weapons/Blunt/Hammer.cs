
namespace MagicDestroyers.Weapons.Blunt
{
    using System;

    public class Hammer
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

        public Hammer()
        {
            
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }

}