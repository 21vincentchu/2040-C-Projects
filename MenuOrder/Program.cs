namespace MenuOrder;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> order = new Dictionary<string, double>()
        {
            { "Baja Taco", 4.00 },
            { "Burrito", 7.50 },
            { "Bowl", 8.50 },
            { "Nachos", 11.00 },
            { "Quesadilla", 8.50 },
            { "Super Burrito", 8.50 },
            { "Super Quesadilla", 9.50 },
            { "Taco", 3.00 },
            { "Tortilla Salad", 8.00 }
        };

        double orderTotal = 0;

        Boolean keepGoing = true;
        while(keepGoing)
        {
            String end = "end";
            Console.WriteLine("Item");
            String input = Console.ReadLine()!;

            foreach(string dictionaryKey in order.Keys)
            {  
                if(input.ToLower() == dictionaryKey.ToLower())
                {
                    orderTotal += order[dictionaryKey];
                    Console.WriteLine($"Total: ${orderTotal:F2}" );
                }
            }
            
            if(String.Equals(end, input, StringComparison.OrdinalIgnoreCase) == true)
            {
                Environment.Exit(1);
            }   
        }
    }
}