using System;

namespace Heist_II
{
    public class LockSpecialist : Bank, IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double PercentageCut { get; set; }

        public void Specialty()
        {
            Console.WriteLine("LockSpecialist");
        }

        public void PerformSkill(Bank bank)
        {
            int newScore = bank.VaultScore - this.SkillLevel;
            Console.WriteLine($"{Name} is breaking the vault down. Decreased security by {SkillLevel} points.");
            if (newScore <= 0)
            {
                Console.WriteLine($"{Name} has gained access to the vault!");
            }

            bank.AlarmScore = newScore;
        }
    }
}