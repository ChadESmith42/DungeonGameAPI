using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonGameAPI.Models
{
    public abstract class Character
    {
        private int _life;

        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set { _life = value <= MaxLife ? value : MaxLife; }
        }

        public virtual int CalcBlock() { return Block; }
        public virtual int CalcHitChance() { return HitChance; }
        public virtual int CalcDamage() { return 0; }
    }
}
