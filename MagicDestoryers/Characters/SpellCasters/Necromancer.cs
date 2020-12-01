namespace MagicDestroyers.Characters.SpellCasters
{

    using MagicDestroyers.Weapons.Sharp;
    using MagicDestroyers.Armor.Leather;

    public class Necromancer
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Leathervest bodyArmor;
        private Sword weapon;

        public string Faction { get; set; }
        public string Name { get; set; }

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public Leathervest BodyArmor { get; set; }
        public Sword Weapon { get; set; }

        public Necromancer()
        {

        }

        public void ShadowRage()
        {

        }

        public void VampiricTouch()
        {

        }

        public void BoneShield()
        {

        }
    }
}