


namespace MagicDestroyers.Weapons.Sharp
{
    using System;

    public class Sword
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

        public Sword()
        {
            
        }

        public void Bloodthirst()
        {
            this.Damage = 10;
        }
    }

}