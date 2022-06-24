using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Lib.Weapons
{
    internal class Staff:Weapon
    {
        private static int s_damage = 15;
        private static string s_name = "Staff";
        public Staff() : base(s_name, s_damage) { }
    }
}
