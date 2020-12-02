namespace Heist_II
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        double PercentageCut { get; set; }

        public void Specialty()
        { }

        public void PerformSkill(Bank bank)
        {

        }

    }
}