using System;
using MagicDestroyers.Weapons.Sharp;
using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Armors.Leather;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer
    {
     #region fields
        //  fields
        private int faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Chainlink bodyArmor;
        private Axe weapon;
        #endregion

     #region properties
        //  properties
        public int Faction { get; set; }
        public string Name { get; set; }

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public LeatherVest BodyArmor { get; set; }
        public Sword Weapon { get; set; }
        #endregion

        #region  Constructors

        public Necromancer()
            : this("Necromancer", 1)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, 10)
        {
            //this.Damage = damage;
        }

        public Necromancer(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.AbilityPoints = abilityPoints;
            this.HealthPoints = 100;

            //this.Faction = "Spellcasters";

            this.BodyArmor = new LeatherVest();
            this.Weapon = new Sword();

            //this.Damage = damage;
        }

        #endregion

        #region methods

        //  Methods: Offensive

        public void ShadowRage()
        {
            throw new NotImplementedException("Not implemented method.");
        }
        public void VampireTouch()
        {
            throw new NotImplementedException("Not implemented method.");
        }

        //  Methods: Defensive
        public void BoneShield()
        {
            throw new NotImplementedException("Not implemented method.");
        }

        #endregion

    }

}
