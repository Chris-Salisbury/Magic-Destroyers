
namespace MagicDestroyers.Weapons.Blunt
{
    using System;

    public class Staff
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

        public Staff()
        {
            
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }

}