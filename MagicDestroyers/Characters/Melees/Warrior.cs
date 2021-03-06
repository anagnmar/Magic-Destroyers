﻿using System;
using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Weapons.Sharp;
using MagicDestroyers.Enumerations;

namespace MagicDestroyers.Characters.Melees
{
    public class Warrior
    {
     #region fields

        //  fields: private modifier, internal logic of a class
        private int damage;
        private string name;
        private int healthPoints;

        private int abilityPoints;
        private Faction faction;
        private int level;

        private Chainlink bodyArmor;
        private Axe weapon;

     #endregion

     #region properties
        //  Properties
        public int Damage 
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }

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

        public Faction Faction 
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

     #region  Constructors

        public Warrior()
            : this("Warrior", 1)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, 10)
        {
            //this.Damage = damage;
        }

        public Warrior(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.AbilityPoints = abilityPoints;
            this.HealthPoints = 100;

            //this.Faction = "Melee";

            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();

            //this.Damage = damage;
        }

        #endregion

        #region methods

        //  Methods: Offensive

        public void Strike()
        {
            throw new NotImplementedException("Not implemented method.");
        }
        public void Execute()
        {
            throw new NotImplementedException("Not implemented method.");
        }

        //  Methods: Defensive

        public void SkinHarden()
        {
            throw new NotImplementedException("Not implemented method.");
        }

        //
        public void Attack(Warrior enemy)
        {
            enemy.HealthPoints -= Damage;
            Console.WriteLine($"{Name} is attacking {enemy.Name}.\n" +
                $"So {enemy.Name} now has {enemy.HealthPoints} remaining");
        }

     #endregion

    }
}


//public void Greetings(string name)
//{
//    Console.WriteLine($"{Name} greets {name}");
//}
