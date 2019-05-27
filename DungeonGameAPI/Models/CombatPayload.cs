using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonGameAPI.Models
{
    public class CombatPayload
    {
        public Character Attacker { get; set; }
        public Character Defender { get; set; }
        public Weapon AttackerWeapon { get; set; }
        public Weapon DefenderWeapon { get; set; }
        public Int32 DamageDealt { get; set; }
    }


}
