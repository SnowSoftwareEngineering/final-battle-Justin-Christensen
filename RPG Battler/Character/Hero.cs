using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Level = 0;
            Health = 1; 
            Power = 1;
            Luck = 1;
            Mana = 1;  
        }

        public void LevelUp()
        {
            if (CombatClass == CombatClass.Wizard)
            {
            Random random = new Random();
            Health += random.Next(1, 15);
            Power += random.Next(3, 5);
            Luck += random.Next(1, 3);
            }
            else if (CombatClass == CombatClass.Warrior)
            {
                Random random = new Random();
                Health += random.Next(10, 20);
                Power += random.Next(1, 3);
                Luck += random.Next(1, 3);
            }
            else if (CombatClass == CombatClass.Rogue)
            {
                Random random = new Random();
                Health += random.Next(1, 15);
                Power += random.Next(1, 3);
                Luck += random.Next(3, 5);
            }
        }

        public void CalculateTotals()
        {
        }

        public void DisplayStats(bool totVsNat = true) //true for total false for natural
        {
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Power: " + Power);
            Console.WriteLine("Luck: " + Luck);
        }
    }
}
