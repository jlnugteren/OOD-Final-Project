using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Final_Project
{
    public class SorcererClass : Player
    {
        public SorcererClass()
        {
            this.Health = 15;
            this.Attack = 8;
        }
        //overriding Healing function because sorcerer's may be better at healing
        public override string PlayerHeal()
        {
            Random random = new Random();
            int heal = random.Next(1, 5);
            this.Health += heal;
            return " - Sorcerer healed for " + heal.ToString() + "\r\n";
        }
    }
}
