using System;
using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Weapons.Blunt;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melees
{
    public class Knight
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
        //public int Faction
        //{
        //    get
        //    {
        //        return faction;
        //    }
        //    set
        //    {
        //        faction = value;
        //    }
        //}

     // OR  sorter way to  expand  properties ...
     // public int Faction { get => faction; set => faction = value; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                abilityPoints = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        public Chainlink BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Axe Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        #endregion

        public Knight()
        {

        }

     #region methods
        //  Methods  

        //  Offensive
        public void Holyblow()
        {

        }
        public void PurifySoul()
        {

        }
        //  Defensive
        public void RighteousWings()
        {

        }


     #endregion

    }

}
