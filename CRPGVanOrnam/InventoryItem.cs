using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGVanOrnam
{
    public class InventoryItem
    {
        public Item Details;
        public int Quantity;

        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
