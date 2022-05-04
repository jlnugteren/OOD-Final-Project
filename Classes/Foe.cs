using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Final_Project
{
    public class Foe
    {
        #region Foe values
        //Default Health Values
        private int _defaulthealth = 50;
        private int _defaultattack = 3;
        private int _defaultdefense = 5;
        #endregion
        #region Foe Properties
        //Encapsulation by Properties
        public int Health
        {
            get { return this._defaulthealth; }
            set { this._defaulthealth = value; }
        }
        public int Attack
        {
            get { return this._defaultattack; }
            set { this._defaultattack = value; }
        }
        public int Defense
        {
            get { return this._defaultdefense; }
            set { this._defaultdefense = value; }
        }
        #endregion
        #region Foe Constructor
        //Foe Constructor
        public Foe()
        {
            this.Health = _defaulthealth;
            this.Attack = _defaultattack;
            this.Defense = _defaultdefense;
        }
        #endregion
        #region Foe Methods
        //Foe Methods
        public int FoeAttack()
        {
            Random random = new Random();
            int attack = random.Next() % this.Attack;
            if (attack == 0)
            {
                attack++;
            }
            return attack;
        }
        public string UpdateStats()
        {
            return "Health: " + this.Health + "\r\n" + "Attack: " + this.Attack + "\r\n";
        }
        #endregion
    }
}
