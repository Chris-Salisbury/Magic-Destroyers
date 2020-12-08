
namespace MagicDestroyers.Weapons.Sharp
{
    using System;

    public class Axe
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

        public Axe()
        {
            
        }

        public void HackNSlash()
        {
            this.Damage = 10;
        }
    }

}