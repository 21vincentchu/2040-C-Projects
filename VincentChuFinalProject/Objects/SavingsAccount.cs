namespace VincentChuFinalProject
{
    public class SavingsAccount : AccountObject
    {
        public SavingsAccount(string accountNumber, int pin, string firstName, string lastName, decimal balance, int numDeposits, int numWithdrawals) : base(accountNumber, pin, firstName, lastName, balance, numDeposits, numWithdrawals, accountType.Savings)
        {

        }
    }
}