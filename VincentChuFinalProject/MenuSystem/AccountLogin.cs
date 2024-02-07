namespace VincentChuFinalProject;
public class AccountLogin
{
    public static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Account Login Menu:");
            Console.WriteLine("a. Make a withdrawal");
            Console.WriteLine("b. Make a deposit");
            Console.WriteLine("c. Transfer funds to another user account");
            Console.WriteLine("d. Balance inquiry");
            Console.WriteLine("e. Back to main menu");

            Console.Write("Enter the option letter: ");
            string userInput = Console.ReadLine()!;

            switch (userInput)
            {
                case "a":
                    MakeWithdrawal();
                    break;
                case "b":
                    MakeDeposit();
                    break;
                case "c":
                    TransferFunds();
                    break;
                case "d":
                    CheckBalance();
                    break;
                case "e":
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

    static void MakeWithdrawal()
    {
        Console.WriteLine("Performing withdrawal...");
        // Implement logic for withdrawal
    }

    static void MakeDeposit()
    {
        Console.WriteLine("Performing deposit...");
        // Implement logic for deposit
    }

    static void TransferFunds()
    {
        Console.WriteLine("Transferring funds...");
        // Implement logic for fund transfer
    }

    static void CheckBalance()
    {
        Console.WriteLine("Checking balance...");
        // Implement logic for balance inquiry
    }
}
