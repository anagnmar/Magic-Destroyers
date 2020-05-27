using System;
using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Weapons.Sharp;


namespace MagicDestroyers.Characters.Melees
{
    public class Assassin
    {

     #region fields
        //  fields
        private int faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private LeatherVest bodyArmor;
        private Sword weapon;
     #endregion

     #region properties

        //  properties
        public int Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
            }
        }

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
        public LeatherVest BodyArmor
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
        public Sword Weapon
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

     #region  Constructors

        public Assassin()
            : this("Assassin", 1)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, 10)
        {
        }

        public Assassin(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.AbilityPoints = abilityPoints;
            this.HealthPoints = 100;

            //this.Faction = "Melee";

            this.BodyArmor = new LeatherVest();
            this.Weapon = new Sword();

            //this.Damage = damage;
        }
        #endregion

        #region methods

        //  Methods: Offensive

        public void Raze()
        {
            throw new NotImplementedException("Not implemented method.");
        }
        public void Bleed()
        {
            throw new NotImplementedException("Not implemented method.");
        }

        //  Methods: Defensive

        public void Survival()
        {
            throw new NotImplementedException("Not implemented method.");
        }

     #endregion

    }

}
