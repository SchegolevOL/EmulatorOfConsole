using Heroes.Lib.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Lib.Races
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
        private Weapon _weapon;

        public Weapon Weapon
        {
            get => _weapon;
            set
            {
                _weapon = value;
                Damage = _weapon.Damage + RateDemage;
            }
        }
        #endregion

        #region CONSTRUCTOR
        protected Race(string name, Weapon weapon)
        {
            Name = name;
            Weapon = weapon;

            Health = 100;
        }
        #endregion

        public void Attack(Race enemy)
        {
            enemy.Health = enemy.Health - Damage;
        }

    }
}
