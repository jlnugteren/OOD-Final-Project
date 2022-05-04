using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Final_Project
{
    public class Player
    {
        #region Player values
        //Default Health Values
        private int _defaulthealth = 20;
        private int _defaultattack = 4;
        private int _health;
        private int _attack;
        private string _name;
#endregion
        #region Player Properties
        //Encapsulation by Properties
        public int Health
        {
            get { return this._health; }
            set { this._health = value; }
        }
        public int Attack
        {
            get { return this._attack; }
            set { this._attack = value; }
        }
        public string Username
        {
            get { return this._name; }
            set { this._name = value; }
        }
        #endregion
        #region Player Constructor
        //Player Constructor
        public Player()
        {
            this.Username = "";
            this.Health = _defaulthealth;
            this.Attack = _defaultattack;
        }
        #endregion
        #region Player Methods
        //Player Methods
        public int PlayerAttack()
        {
            Random random = new Random();
            int pow = random.Next() % this.Attack;
            return pow;
        }
        public virtual string PlayerHeal()
        {
            Random random = new Random();
            int heal = random.Next(1, 5);
            this.Health += heal;
            return " - Player healed for " + heal.ToString() + " Health!";
        }
        public string UpdateStats()
        {
            return "Health: " + this.Health + "\r\n" + "Attack: " + this.Attack + "\r\n";
        }
        #endregion
    }
}
