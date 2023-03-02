using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGVanOrnam
{
    public class LootItem
    {
        public Item Details;
        public int DropPercentage;
        public bool IsDefaultItem;

        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}
