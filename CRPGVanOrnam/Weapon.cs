using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGVanOrnam
{
    public class Weapon : Item
    {
        public int MaximumDamage;
        public int MinimumDamage;

        public Weapon(int id, string name, string namePlural, int maximumDamage, int minimumDamage):base(id, name, namePlural)
        {
            MaximumDamage = maximumDamage;
            MinimumDamage = minimumDamage;
        }
    }
}
