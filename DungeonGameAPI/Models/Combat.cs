using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonGameAPI.Models
{
    public class Combat
    {

        public static void DoAttack(Character attacker, Character defender)
        {

            Random randomAttack = new Random();
            int diceRoll = randomAttack.Next(1, 101);
            System.Threading.Thread.Sleep(30);
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();

                defender.Life -= damageDealt;
            }
            else
            {
                defender.Life += 1;
            }
        }

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }

            
        }
    }
}
