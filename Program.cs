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
           
            
        }
    }
}
