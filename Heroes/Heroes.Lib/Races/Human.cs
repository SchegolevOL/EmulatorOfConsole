using Heroes.Lib.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Lib.Races
{

    public class Human : Race
    {
        private const int RATE_DANAGE = 10;
        private const int RATE_HEALTH = 0;

        public Human(string name, Weapon weapon) : base(name, weapon)
        {
            RateDemage = RATE_DANAGE;
            RateHealth = RATE_HEALTH;

            Damage = weapon.Damage + RateDemage;
        }
    }
}
