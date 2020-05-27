using System;
using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Weapons.Sharp;


namespace MagicDestroyers.Characters.Melees
{

    public class warriorPlay
    {

     #region fields

        //  fields: private modifier, internal logic of a class
        private int damage;
        private string name;
        private int healthPoints;

        private int abilityPoints;
        private int faction;
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
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Value must be set: 1 -100.");
                    //Console.WriteLine($"Value must be set: 1 -100. ");
                    level = 1;
                }
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

        public warriorPlay()
        {

        }

        public warriorPlay(int damage, int healthPoints, string name)
        {
            Damage = damage;
            HealthPoints = healthPoints;
            Name = name;
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
        public void Attack(warriorPlay enemy)
            {
                enemy.HealthPoints -= Damage;
                Console.WriteLine($"{Name} is attacking {enemy.Name}.\n" +
                    $"So {enemy.Name} now has {enemy.HealthPoints} remaining");
        }

     #endregion


        public void Greetings(string name)
        {
            Console.WriteLine($"{Name} greets {name}");
        }

    }

}
