using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonGameAPI.Models
{
    public class Player : Character
    {
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            switch (CharacterRace)
            {
                case Race.Pirate:
                    Block += 25;
                    MaxLife -= 10;
                    break;
                case Race.SwordMaster:
                    Block += 40;
                    HitChance += 10;
                    break;
                case Race.Giant:
                    MaxLife += 50;
                    EquippedWeapon.MaxDamage += 40;
                    break;
                case Race.Brainiac:
                    Block += 25;
                    break;
                case Race.Soldier:
                    MaxLife += 25;
                    EquippedWeapon.BonusHitChance += 25;
                    break;
                case Race.Thief:
                    Block += 30;
                    break;
                case Race.Huntsman:
                    HitChance += 30;
                    break;
                case Race.Farmboy:
                    MaxLife += 25;
                    EquippedWeapon.MaxDamage += 5;
                    HitChance += 20;
                    Block += 5;
                    break;
                default:
                    break;
            }//end Bonus Switch;B

        }//end fqctor
        //Methods
        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.Pirate:
                    description = "Dressed in black, you will rob, steal and murder your way to success.";
                    break;
                case Race.SwordMaster:
                    description = "You live, eat, and breath the sword. Because of your studies you're not likely to die by the sword, but it's still possible.";
                    break;
                case Race.Giant:
                    description = "You're big. Really big. And strong. You can be gentle when you're not smashing people with rocks or choking them with your fingers.";
                    break;
                case Race.Brainiac:
                    description = "You can think your way out of anything. You're always the smartest person in the room. Except when you're not, which isn't often.";
                    break;
                case Race.Soldier:
                    description = "You have discipline and will. Your average intelligence and strength are magnified by your determination and grit. You'll go far, if you can be recognized for your valor by others.";
                    break;
                case Race.Thief:
                    description = "You are silent and clever. You can take anything you want, but may have trouble selling your spoils. You are not to be trusted.";
                    break;
                case Race.Huntsman:
                    description = "You're strong, smart, and self-sufficient. You don't work well in teams, but you don't need one as you can finish the mission yourself.";
                    break;
                case Race.Farmboy:
                    description = "Humble and hardworking, you are strong and capable. You may have to work harder, but you will.";
                    break;
                default:
                    break;
            }//end switch
            return string.Format("-=-= {0} =-=-\nLife = {1} of {2}\n" +
                "Hit Chance {3}%\nWeapon:\n{4}\tBlock: {5}\n" +
                "Description: {6}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                EquippedWeapon,
                Block,
                description
                );
        }//end ToString()

        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //return base.CalcDamage();
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }



    }
}

