using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Lib.Weapons
{
    public class Axe : Weapon
    {
        private static int s_damage = 20;
        private static string s_name = "Axe";
        public Axe() : base(s_name, s_damage) { }
    }
}
