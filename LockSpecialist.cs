using System;

namespace Heist_II
{
    public class LockSpecialist : Bank, IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int newScore = bank.VaultScore - this.SkillLevel;
            Console.WriteLine($"{Name} is breaking the vault down. Decreased security by {SkillLevel} points.");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has gained access to the vault!");
            }
        }
    }
}