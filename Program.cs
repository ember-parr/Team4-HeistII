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

            Bank newBank = new Bank();
            int rand1 = new Random().Next(101);
            int rand2 = new Random().Next(101);
            int rand3 = new Random().Next(101);
            int rand4 = new Random().Next(50000, 1000000);
            newBank.AlarmScore = rand1;
            newBank.VaultScore = rand2;
            newBank.SecurityGuardScore = rand3;
            newBank.CashOnHand = rand4;
            string mostSecure;






            if (newBank.AlarmScore == newBank.VaultScore)
            {
                mostSecure = "Alarm & Vault equally secure!";
            }
            else if (newBank.AlarmScore == newBank.SecurityGuardScore)
            {
                mostSecure = "Alarm & Security Guard equally secure!";
            }
            else if (newBank.VaultScore == newBank.SecurityGuardScore)
            {
                mostSecure = "Vault & Security Guard equally secure!";
            }
            else if (newBank.AlarmScore > newBank.VaultScore && newBank.AlarmScore > newBank.SecurityGuardScore)
            {
                mostSecure = "Alarm";
            }
            else if (newBank.VaultScore > newBank.AlarmScore && newBank.VaultScore > newBank.SecurityGuardScore)
            {
                mostSecure = "Vault";
            }
            else
            {
                mostSecure = "Security Guard";
            }






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
|   |                                     |   |
| O |                                     |   |                
|   |                                     |   |
| O |                                     | O |
|   |                                     |   |
| O |                                     | O |
|   |                                     |   |
| O |- - - - - - - - - - - - - - - - - - -| O |
|   |                                     |   |
            ");



        }
    }
}