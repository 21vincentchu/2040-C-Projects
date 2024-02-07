namespace ObjectPositionVC;

class Program
{
    static void Main(string[] args)
    {
         //Declare variables
        string welcomeMessage = "This program calculates an object's final position.\n";
        float initalPosition, initalVelocity, acceleration, elapsedTime;
        double finalPosition = 0;
        bool doCalculation = true;
        
        //Print the welcome message
        Console.WriteLine(welcomeMessage);

        //place the prompts and output in a loop
        while(doCalculation){
            
            //Ask the user for initial posotion. reprompt if input is bad
            while(true){
                //ask user for initial position
                try{
                    Console.WriteLine("Enter the initial position: ");
                    initalPosition = float.Parse(Console.ReadLine()!);
                    break;
                }catch(Exception error){
                    Console.WriteLine("Invalid Input: Enter a number!");
                    Console.WriteLine($"Error: {error.GetType().Name}");
                }
            }

            //Ask the user for inital velocity. reprompt if input is bad
            //ask the sure for acceleration. reprompt if input is bad
            //Ask the user for elased time. reprompt if input is bad

            //calculate the answer

            //Ask user if they want to run the program again
            //if yes, run program again. if no, exit program
            Console.WriteLine("Do you want to run the program again? (y/n)");

            //get the user response
            string anotherCalculation = Console.ReadLine()!;
            //decide if we want to run the program again
            if(anotherCalculation != "y" && anotherCalculation != "Y"){
                doCalculation = false;
            }
        }
    }
}
