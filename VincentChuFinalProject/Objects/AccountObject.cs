namespace VincentChuFinalProject;

public class AccountObject
{
    private string accountNumber;
    private int pin;
    private string firstName;
    private string lastName;
    private decimal balance;
    private int numDeposits;
    private int numWithdrawals;
    private accountType accountType;

    public AccountObject(string AccountNumber, int Pin, string FirstName, string LastName, decimal Balance, int NumDeposits, int NumWithdrawals, accountType AccountType)
    {
        accountNumber = AccountNumber;
        pin = Pin;
        firstName = FirstName;
        lastName = LastName;
        balance = Balance;
        numDeposits = NumDeposits;
        numWithdrawals = NumWithdrawals;
        accountType = AccountType;
    }

    public string getAccountNumber()
    {
        return accountNumber;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public decimal getBalance()
    {
        return balance;
    }

    public int getNumDeposits()
    {
        return numDeposits;
    }

    public int getNumWithDrawals()
    {
        return numWithdrawals;
    }

    public accountType GetAccountType()
    {
        return accountType;
    }

    public void printInfo()
    {
        Console.WriteLine($"Account Number: {accountNumber}, Pin: {pin}, Name: {firstName} {lastName}, Balance: {balance}, Deposits: {numDeposits}, WithDrawals: {numWithdrawals} Account type: {accountType}");
    }
}