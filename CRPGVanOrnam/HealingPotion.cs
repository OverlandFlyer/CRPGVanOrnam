using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGVanOrnam
{
    public class HealingPotion:Item
    {
        public int AmountToHeal;

        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
