using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Lib.Weapons
{
    public abstract class Weapon
    {
        public int Damage { get; }
        public string Name { get; }
        protected Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
