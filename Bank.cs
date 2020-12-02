using System;

namespace Heist_II
{
    public class Bank
    {

        int CashOnHand { get; set; } = 0;
        int AlarmScore { get; set; } = 0;
        int VaultScore { get; set; } = 0;
        int SecurityGuardScore { get; set; } = 0;
        bool IsSecure()
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