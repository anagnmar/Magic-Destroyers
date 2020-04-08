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

        public Necromancer()
        {

        }

     #region methods
        //  Methods  

        //  Offensive
        public void ShadowRage()
        {

        }
        public void VampireTouch()
        {

        }
        //  Defensive
        public void BoneShield()
        {

        }


     #endregion


    }

}
