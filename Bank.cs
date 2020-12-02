using System;

namespace Heist_II
{
    public class Bank {
   
    int CashOnHand = 0;
    int AlarmScore = 0;
    int VaultScore = 0;
    int SecurityGuardScore = 0;
    bool IsSecure()
        {
            if(CashOnHand + AlarmScore + VaultScore + SecurityGuardScore <= 0)
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