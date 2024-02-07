namespace VincentChuFinalProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to bank");

        List<AccountObject> accountList = AccountDataLoader.loadFile("account_data.csv");

        foreach(var account in accountList)
        {
            account.printInfo();
        }

        //menu
    }
}
