using System;

namespace Heist_II
{
    public class Bank
    {

        public int CashOnHand { get; set; } = 0;
        public int AlarmScore { get; set; } = 0;
        public int VaultScore { get; set; } = 0;
        public int SecurityGuardScore { get; set; } = 0;
        public bool IsSecure()
        {
            if (CashOnHand + AlarmScore + VaultScore + SecurityGuardScore <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}