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
            Muscle muscelM1 = new Muscle();
            Muscle muscelM2 = new Muscle();
            LockSpecialist lockspecialist1 = new LockSpecialist();
            LockSpecialist lockspecialist2 = new LockSpecialist();

            hackerH1.Name = "Braxton";
            hackerH1.PercentageCut = 20;
            hackerH1.SkillLevel = 60;
            hackerH2.Name = "Lacey";
            hackerH2.PercentageCut = 21;
            hackerH2.SkillLevel = 61;
            muscelM1.Name = "Adam";
            muscelM1.PercentageCut = 2;
            muscelM1.SkillLevel = 1;
            muscelM2.Name = "Delta";
            muscelM2.PercentageCut = 90;
            muscelM2.SkillLevel = 90;
            lockspecialist1.Name = "Ember";
            lockspecialist1.PercentageCut = 11;
            lockspecialist1.SkillLevel = 42;
            lockspecialist2.Name = "Quitter Sage";
            lockspecialist2.PercentageCut = 1;
            lockspecialist2.SkillLevel = 1;



            List<IRobber> rolodex = new List<IRobber>()
            {
                hackerH1,
                hackerH2,
                muscelM1,
                muscelM2,
                lockspecialist1,
                lockspecialist2
            };

            List<IRobber> crew = new List<IRobber>()
            {

            };

                        while (true)
                        {
                            Console.WriteLine($"Rolodex count:  {rolodex.Count}");
                            Console.Write("Enter name of new member: ");
                            string newMemberName = Console.ReadLine();
                            if (newMemberName == "")
                            {
                                break;
                            }

                            Console.Write(@"Please select one of the following specialties for new member: 
                            1. Hacker (Disables alarms)
                            2. Muscle (Disarms guards)
                            3. Lock Specialist (cracks vault)
                            ");

                            int newMemberType = int.Parse(Console.ReadLine());

                            Console.Write("Enter new members skill level ( 1 - 100 ): ");
                            int newSkillLevel = int.Parse(Console.ReadLine());

                            Console.Write("What percentage of the cut does the new member demand? ( 1 - 100 ): ");
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

                        }
                        Console.WriteLine(rolodex.Count);

                        // creates new bank object with random values set as security scores [ep]
                        Bank newBank = new Bank();
                        int rand1 = new Random().Next(101);
                        int rand2 = new Random().Next(101);
                        int rand3 = new Random().Next(101);
                        int rand4 = new Random().Next(50000, 1000000);
                        newBank.AlarmScore = rand1;
                        newBank.VaultScore = rand2;
                        newBank.SecurityGuardScore = rand3;
                        newBank.CashOnHand = rand4;

                        // finds most & least secure values in newBank object for console printed report  [ep]
                        string mostSecure;
                        string leastSecure;

                        if (newBank.AlarmScore > newBank.VaultScore && newBank.AlarmScore > newBank.SecurityGuardScore && newBank.VaultScore > newBank.SecurityGuardScore)
                        {
                            mostSecure = "Alarm";
                            leastSecure = "Security Guard";
                        }
                        else if (newBank.AlarmScore > newBank.VaultScore && newBank.AlarmScore > newBank.SecurityGuardScore && newBank.SecurityGuardScore > newBank.VaultScore)
                        {
                            mostSecure = "Alarm";
                            leastSecure = "Vault";
                        }
                        else if (newBank.VaultScore > newBank.AlarmScore && newBank.VaultScore > newBank.SecurityGuardScore && newBank.AlarmScore > newBank.SecurityGuardScore)
                        {
                            mostSecure = "Vault";
                            leastSecure = "Security Guard";
                        }
                        else if (newBank.VaultScore > newBank.AlarmScore && newBank.VaultScore > newBank.SecurityGuardScore && newBank.SecurityGuardScore > newBank.AlarmScore)
                        {
                            mostSecure = "Vault";
                            leastSecure = "Alarm";
                        }
                        else if (newBank.SecurityGuardScore > newBank.AlarmScore && newBank.SecurityGuardScore > newBank.VaultScore && newBank.VaultScore > newBank.AlarmScore)
                        {
                            mostSecure = "Security Guard";
                            leastSecure = "Alarm";
                        }
                        else if (newBank.SecurityGuardScore > newBank.AlarmScore && newBank.SecurityGuardScore > newBank.VaultScore && newBank.AlarmScore > newBank.VaultScore)
                        {
                            mostSecure = "Security Guard";
                            leastSecure = "Vault";
                        }
                        else if (newBank.SecurityGuardScore > newBank.AlarmScore && newBank.AlarmScore == newBank.VaultScore)
                        {
                            mostSecure = "Security Guard";
                            leastSecure = "Alarm & Vault are equally secure";
                        }
                        else if (newBank.AlarmScore > newBank.VaultScore && newBank.VaultScore == newBank.SecurityGuardScore)
                        {
                            mostSecure = "Alarm";
                            leastSecure = "Vault & Security Guard are equally secure";
                        }
                        else if (newBank.SecurityGuardScore < newBank.AlarmScore && newBank.AlarmScore == newBank.VaultScore)
                        {
                            mostSecure = "Alarm & Vault are equally secure";
                            leastSecure = "Security Guard";
                        }
                        else if (newBank.AlarmScore < newBank.VaultScore && newBank.VaultScore == newBank.SecurityGuardScore)
                        {
                            mostSecure = "Vault & Security Guard are equally secure";
                            leastSecure = "Alarm";
                        }
                        else if (newBank.VaultScore < newBank.AlarmScore && newBank.AlarmScore == newBank.SecurityGuardScore)
                        {
                            mostSecure = "Alarm & Security Guard are equally secure";
                            leastSecure = "Vault";
                        }
                        else if (newBank.VaultScore > newBank.AlarmScore && newBank.AlarmScore == newBank.SecurityGuardScore)
                        {
                            mostSecure = "Vault";
                            leastSecure = "Alarm & Security Guard are equally secure";
                        }
                        else
                        {
                            mostSecure = "error";
                            leastSecure = "error";
                        }

                        // prints report to console [ep]
                        Console.Write($@"
            /   /                                     /   /
            | O |                                     | O |
            |   |- - - - - - - - - - - - - - - - - - -|   |
            | O |                                     | O |
            |   |         R E C O N                   |   |
            | O |              R E P O R T            | O |
            |   |                                       
            | O |                                     | O |
            |   |  Most Secure: {mostSecure}    
            | O |                                     | O |
            |   |  Least Secure: {leastSecure}   
            | O |                                     |   |                
            |   |                                     |   |
            | O |                                     | O |
            |   |                                     |   |
            | O |                                     | O |
            |   |                                     |   |
            | O |- - - - - - - - - - - - - - - - - - -| O |
            |   |                                     |   |
                        ");

            string newCrew = "a";
            while (newCrew != "")
            {
                int percentageCutClaimed = 0;
                
                foreach (IRobber crewMember in crew)
                {
                    int crewMembersCut = crewMember.PercentageCut;
                    percentageCutClaimed += crewMembersCut;
                }
                Console.WriteLine($"Cut Claimed: {percentageCutClaimed}%");

                foreach (IRobber robber in rolodex)
                {
                    if (!crew.Contains(robber) && percentageCutClaimed + robber.PercentageCut < 100)
                    {
                        int index = rolodex.IndexOf(robber);
                        Console.WriteLine($"Index: {index + 1}");
                        Console.WriteLine(robber.Name);
                        robber.Specialty();
                        Console.WriteLine($"{robber.Name}'s Skill Level is {robber.SkillLevel}");
                        Console.WriteLine($"{robber.Name} demands {robber.PercentageCut}% cut of the take.\n");
                    }
                }

                while (true)
                {
                    Console.Write(@"Please enter index number ");
                    newCrew = Console.ReadLine();
                    int newCrewInt = -1;
                    if(newCrew == "")
                    {
                        break;
                    }
                    try
                    {
                        newCrewInt = int.Parse(newCrew) - 1;
                        crew.Add(rolodex[newCrewInt]);
                        foreach (IRobber crewMember in crew)
                        {
                            crewMember.Specialty();
                        }
                    }
                    catch
                    {
                    }

                    if (newCrewInt != -1)
                    {
                        break;
                    }
                }
            }

            foreach(IRobber crewMember in crew)
            {
                crewMember.PerformSkill(newBank);
            }

            int totalBankScore = newBank.AlarmScore + newBank.VaultScore + newBank.SecurityGuardScore;

            Console.WriteLine($"Total bank score after attack:  {totalBankScore}");

            if(totalBankScore <= 0)
            {
                Console.WriteLine("Heist Successful. You're rich, bitch!");
            }
            else{
                Console.WriteLine("Heist Failed. Enjoy federal prison!");
            }
        }
    }
}