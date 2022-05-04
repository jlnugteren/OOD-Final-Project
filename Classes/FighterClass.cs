using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Final_Project
{
    public class FighterClass : Player
    {
        public FighterClass()
        {
            this.Health = 25;
            this.Attack = 5;
        }
        //overriding heal function because fighter's may not be as good at it
        public override string PlayerHeal()
        {
            Random random = new Random();
            int heal = random.Next(1, 3);
            this.Health += heal;
            return " - Fighter healed for " + heal.ToString() + "\r\n";
        }
    }
}
