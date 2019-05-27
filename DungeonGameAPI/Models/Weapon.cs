using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonGameAPI.Models
{
    public class Weapon
    {   //Fields
        private int _minDamage;

        //Properties
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public bool IsTwoHanded { get; set; }
        public int BonusHitChance { get; set; }
        public int MinDamage
        {
            get
            {
                return _minDamage;
            }//end get

            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }//end set
        }//end minDamage

        //Constructors
        public Weapon(string name, int maxDamage, bool isTwoHanded, int bonusHitChance, int minDamage)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            IsTwoHanded = isTwoHanded;
            BonusHitChance = bonusHitChance;
        }
        //Methods
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} damage\nBonus Hit: {3}%\n{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                (IsTwoHanded ? "Two" : "Single") + "-handed");
        }

    }//end class
}
