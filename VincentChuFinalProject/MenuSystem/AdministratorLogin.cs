namespace VincentChuFinalProject;
public class AdministratorLogin
{
    public static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Administrator Login Menu:");
            Console.WriteLine("a. Show average savings account balance");
            Console.WriteLine("b. Show total savings account balance");
            Console.WriteLine("c. Show average checking account balance");
            Console.WriteLine("d. Show total checking account balance");
            Console.WriteLine("e. Show the number of accounts for each account type");
            Console.WriteLine("f. Show the 10 accounts with the most deposits");
            Console.WriteLine("g. Show the 10 accounts with the most withdrawals");
            Console.WriteLine("h. Back to main menu");

            Console.Write("Enter the option letter: ");
            string userInput = Console.ReadLine()!;

            switch (userInput)
            {
                case "a":
                    ShowAverageSavingsBalance();
                    break;
                case "b":
                    ShowTotalSavingsBalance();
                    break;
                case "c":
                    ShowAverageCheckingBalance();
                    break;
                case "d":
                    ShowTotalCheckingBalance();
                    break;
                case "e":
                    ShowAccountTypeCounts();
                    break;
                case "f":
                    ShowTopDepositAccounts();
                    break;
                case "g":
                    ShowTopWithdrawalAccounts();
                    break;
                case "h":
                    return; // Back to main menu
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option letter.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void ShowAverageSavingsBalance()
    {
      
    }

    static void ShowTotalSavingsBalance()
    {

    }

    static void ShowAverageCheckingBalance()
    {

    }

    static void ShowTotalCheckingBalance()
    {

    }

    static void ShowAccountTypeCounts()
    {

    }

    static void ShowTopDepositAccounts()
    {

    }

    static void ShowTopWithdrawalAccounts()
    {

    }

}