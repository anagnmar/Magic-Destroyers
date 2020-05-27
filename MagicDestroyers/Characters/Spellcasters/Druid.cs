using System;
using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid
    {
     #region fields
        //  fields
        private int faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private LeatherVest bodyArmor;
        private Staff weapon;
        #endregion

     #region properties
        //  properties
        public int Faction { get; set; }
        public string Name { get; set; }

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public LeatherVest BodyArmor { get; set; }
        public Staff Weapon { get; set; }
        #endregion

        #region  Constructors

        public Druid()
            : this("Druid", 1)
        {
        }

        public Druid(string name, int level)
            : this(name, level, 10)
        {
            //this.Damage = damage;
        }

        public Druid(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.AbilityPoints = abilityPoints;
            this.HealthPoints = 100;

            //this.Faction = "Spellcasters";

            this.BodyArmor = new LeatherVest();
            this.Weapon = new Staff();

            //this.Damage = damage;
        }

        #endregion

        #region methods

        //  Methods: Offensive

        public void Moonfire()
        {
            throw new NotImplementedException("Not implemented method.");
        }
        public void Starburst()
        {
            throw new NotImplementedException("Not implemented method.");
        }

        //  Methods: Defensive
        public void OneWithTheNature()
        {
            throw new NotImplementedException("Not implemented method.");
        }

        #endregion

    }

}
