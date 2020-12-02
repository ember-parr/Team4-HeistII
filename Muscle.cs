using System;

namespace Heist_II
{
    public class Muscle : Bank, IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void Specialty () 
        {
            Console.WriteLine("Muscle");
        }

        public void PerformSkill(Bank bank)
        {
            int newScore = bank.SecurityGuardScore - this.SkillLevel;
            Console.WriteLine($"{Name} is boxing with the security guard. Decreased security by {SkillLevel} points.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the security guard!");
            }
        }
    }
}