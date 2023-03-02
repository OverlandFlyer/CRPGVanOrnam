using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGVanOrnam
{
    public class PlayerQuest
    {
        public Quest Details;
        public bool IsCompleted;

        public PlayerQuest(Quest details, bool isCompleted)
        {
            Details = details;
            IsCompleted = isCompleted;
        }
    }
}
