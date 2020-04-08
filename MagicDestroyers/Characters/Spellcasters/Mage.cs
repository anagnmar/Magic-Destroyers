using System;
using MagicDestroyers.Armors.Cloth;
using MagicDestroyers.Weapons.Blunt;


namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage
    {
     #region fields
        //  fields
        private int faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private ClothRobe bodyArmor;
        private Staff weapon;
        #endregion

     #region properties
        //  properties
        public int Faction { get; set; }
        public string Name { get; set; }

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public ClothRobe BodyArmor { get; set; }
        public Staff Weapon { get; set; }
        #endregion

        public Mage()
        {

        }

     #region methods
        //  Methods  

        //  Offensive
        public void ArcaneWrath()
        {

        }
        public void Firewall()
        {

        }
        //  Defensive
        public void Meditation()
        {

        }


     #endregion

    }

}
