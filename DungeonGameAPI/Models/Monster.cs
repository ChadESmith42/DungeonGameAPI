using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonGameAPI.Models
{
    public class Monster : Character
    {
        private int _minDamage;


        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }//end get
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }//end set
        }//end MinDamage property

        //Ctor
        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            HitChance = hitChance;
            Block = block;
            Description = description;
        }//end ctor;

        //Methods()
        public override string ToString()
        {
            return string.Format("~-~-~ {0} ~-~-~\nLife: {1} of {2}\nDamage: {3} to {4}\nBlock: {5}%\tHit Chance: {6}%\n{7}\n",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                Block,
                HitChance,
                Description
                );
        }//end ToString();

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }


    }//end Monster
}
