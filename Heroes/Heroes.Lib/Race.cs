using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Lib
{
    public abstract class Race
    {
        #region NAME
        private readonly string _name;
        public string Name { get; }
        #endregion

        #region HEALTH & DAMAGE
        public int Damage { get; set; }

        private int _health;
        public int Health
        {
            get => _health;
            set => _health = value <= 0 ? 0 : value;
        }
        #endregion

        #region RATE
        public bool IsDeath { get => _health == 0; }
        public int RateDemage { get; set; }
        public int RateHealth { get; set; }
        #endregion

        #region WEAPON
        protected Weapon Weapon { get; set; }
        #endregion

        #region CONSTRUCTOR
        protected Race(string name, Weapon weapon)
        {
            this.Name = name;
            this.Weapon = weapon;
        }
        #endregion

        public void Attack(Race enemy)
        {
            var newHelth = enemy.Health - this.Damage;
        }

    }
}
