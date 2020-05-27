using System;

namespace MagicDestroyers.Armors.Cloth
{
    public class ClothRobe
    {

        private int armorPoints;

        public int ArmorPoints 
        { 
            get
            {
                return armorPoints;
            }
            set 
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
            }
        }


        public ClothRobe()
        {

        }

    }

}
