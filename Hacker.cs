using System;

namespace Heist_II
{
    public class Hacker : Bank, IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void Specialty () 
        {
            Console.WriteLine("Hacker");
        }

        public void PerformSkill(Bank bank)
        {
            int newScore = bank.AlarmScore - this.SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel} points.");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}