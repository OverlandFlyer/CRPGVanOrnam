using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGVanOrnam
{
    public class Monster:LivingCreature
    {
        public int ID;
        public string Name;
        public int MaximumDamage;
        public int RewardExperiencePoints;
        public int RewardGold;
        public List<LootItem> LootTable;

        public Monster(int iD, string name, int maximumDamage,
            int rewardExperiencePoints, int rewardsGold,
            int currentHitPoint, int maximumHitPoints):base
                (currentHitPoint, maximumDamage)
        {
            ID = iD;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardsGold;
            LootTable = new List<LootItem>();
        }


    }
}
