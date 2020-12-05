
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
                return this.damage;
            }
            set
            {
                if (value <= 0 && value >= 100)
                {
                    this.damage = value;
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