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

        public Druid()
        {

        }

     #region methods
        //  Methods  

        //  Offensive
        public void Moonfire()
        {

        }
        public void Starburst()
        {

        }
        //  Defensive
        public void OneWithTheNature()
        {

        }


     #endregion

    }

}
