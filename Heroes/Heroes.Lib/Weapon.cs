using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Lib
{
    public abstract class Weapon
    {
        public int Damage { get; }
        protected Weapon(int damage)
        {
            Damage = damage;
        }
    }
}
