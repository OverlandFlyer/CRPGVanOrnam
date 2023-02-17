using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGVanOrnam
{
    class Item
    {
        public int ID;
        public string Name;
        public string NamePlural;

        public Item(int iD, string name, string namePlural)
        {
            ID = iD;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
