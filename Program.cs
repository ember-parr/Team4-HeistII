using System;
using System.Collections.Generic;

namespace Heist_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker hackerH1 = new Hacker();
            Hacker hackerH2 = new Hacker();
            Hacker hackerH3 = new Hacker();
            Muscle muscelM1 = new Muscle();
            Muscle muscelM2 = new Muscle();
            Muscle muscelM3 = new Muscle();
            LockSpecialist lockspecialist1 = new LockSpecialist();
            LockSpecialist lockspecialist2 = new LockSpecialist();
            LockSpecialist lockspecialist3 = new LockSpecialist();

            List<IRobber> rolodex = new List<IRobber>()
            {
                hackerH1,
                hackerH2,
                hackerH3,
                muscelM1,
                muscelM2,
                muscelM3,
                lockspecialist1,
                lockspecialist2,
                lockspecialist3
            };

            while (true)
            {
                Console.WriteLine(rolodex.Count);
                Console.Write("Enter name of new member: ");
                string newMemberName = Console.ReadLine();
                if (newMemberName == "")
                {
                    break;
                }

                Console.WriteLine(@"Please select one of the following specialties for new member: 
                1. Hacker (Disables alarms)
                2. Muscle (Disarms guards)
                3. Lock Specialist (cracks vault)
                ");

                int newMemberType = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new members skill level ( 1 - 100 )");
                int newSkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("What percentage of the cut does the new member demand?");
                int newPercentageCut = int.Parse(Console.ReadLine());

                if (newMemberType == 1)
                {
                    rolodex.Add(
                        new Hacker()
                        {
                            Name = newMemberName,
                                SkillLevel = newSkillLevel,
                                PercentageCut = newPercentageCut

                        }
                    );
                }

                if (newMemberType == 2)
                {
                    rolodex.Add(
                        new Muscle()
                        {
                            Name = newMemberName,
                                SkillLevel = newSkillLevel,
                                PercentageCut = newPercentageCut

                        }
                    );
                }

                if (newMemberType == 3)
                {
                    rolodex.Add(
                        new LockSpecialist()
                        {
                            Name = newMemberName,
                                SkillLevel = newSkillLevel,
                                PercentageCut = newPercentageCut

                        }

                    );
                }

                Console.WriteLine(rolodex.Count);
            }

        }
    }
}