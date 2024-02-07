namespace Project1;
class Program
{
    static void Main(string[] args)
    {
        StreamWriter fileWriter = new StreamWriter("expense_report.txt");
        try
        {
            //read in the data
            Dictionary<string, List<float>> pricesByCategory = ReadFileContents("credit_card.csv");
            fileWriter.WriteLine("*****************\nExpense Report\n*****************\n");

            //Calls method to get total cost of purchases and print to file
            float totalOfEverything = TotalCost(pricesByCategory);
            fileWriter.WriteLine($"Total Cost of Purchases: {totalOfEverything:C}");

            //Calls method to get total number of purchases and print to file
            float totalNumberOfPurchases = TotalAmountOfPurchases(pricesByCategory);
            fileWriter.WriteLine($"Number of Purchases: {totalNumberOfPurchases}");

            //divide total amount / amount of purchases. prints average to file
            float averagePurchaseCost = totalOfEverything / totalNumberOfPurchases;
            fileWriter.WriteLine($"Purchase Average: {averagePurchaseCost:C}");

            //find the category total costs, and returns string to write to file
            fileWriter.WriteLine(FindCategoryCostTotals(pricesByCategory));

            //finds the amount of purchases in each category, returns a string to write to file
            fileWriter.WriteLine(FindCategoryNumberOfPurchases(pricesByCategory));

            //finds the most expensive purchases. returns string that has category and price
            fileWriter.WriteLine(Maxprice(pricesByCategory));

            //finds the least expensive purchase, returns string that has category and
            fileWriter.WriteLine(LowestPrice(pricesByCategory));
            fileWriter.Close();
        }
        catch (Exception err)
        {
            Console.WriteLine($"exception: {err.Message}");
        }
        finally
        {
            fileWriter?.Close();
        }
    }

    //returns a dictionary, with categories, and a list. Gets this information by getting a file, in which is provided
    static Dictionary<string, List<float>> ReadFileContents(string filePath)
    {
        Dictionary<string, List<float>> fileData = new Dictionary<string, List<float>>();

        using (StreamReader sr = new StreamReader(filePath))
        {
            while (!sr.EndOfStream) //keeps importing until the file is down to the last line.
            {
                string lineOfData = sr.ReadLine()!;
                
                //split the data at the comma
                string[] dataFromLine = lineOfData.Split(",");

                string category = dataFromLine[0];
                float cost = float.Parse(dataFromLine[1]);

                if (!fileData.ContainsKey(category)) //makes a new category with a new list if it detects if a category is not the same as the others
                {
                    fileData[category] = new List<float>();
                }
                fileData[category].Add(cost);
            }
        }
        return fileData;
    }
    static float TotalCost(Dictionary<string, List<float>> pricesByCategory)
    {

        float totalOfCategory = 0;
        float totalOfEverything = 0;

        foreach (var dictionaryPair in pricesByCategory) //traverse through dictionary category
        {
            foreach (var cost in dictionaryPair.Value) //traverse through dictionary's list
            {
                totalOfCategory += cost;
            }
            totalOfEverything += totalOfCategory;
            totalOfCategory = 0; //this is necessary b/c or else the totalOfCategory will not reset, and will keep adding on to the last category.
        }
        return totalOfEverything;
    }
    static int TotalAmountOfPurchases(Dictionary<string, List<float>> pricesByCategory)
    {
        int totalLength = 0;

        foreach (var dictionaryPair in pricesByCategory) //traverse through categories, getting the length of the list, which is the .value. 
        {
            totalLength += dictionaryPair.Value.Count;
        }
        return totalLength;
    }
    static string FindCategoryCostTotals(Dictionary<string, List<float>> pricesByCategory)
    {
        string returnOutput = "";

        returnOutput += "\nCost of Purchases by Category\n-------------------------";

        float total = 0.0f;

        foreach (var dictionaryPair in pricesByCategory) //traverse through category
        {
            string category = dictionaryPair.Key;
            foreach (var cost in dictionaryPair.Value) //traver through list
            {
                total += cost;
            }
            returnOutput += $"\n{category}: {total:C}";
            total = 0; //resets the total, for the next category after going through one entire list
        }
        return returnOutput;
    }
    static string FindCategoryNumberOfPurchases(Dictionary<string, List<float>> pricesByCategory)
    {
        string returnOutput = "";
        returnOutput += "\nNumber of Purchases by Category\n-------------------------";

        foreach (var dictionaryPair in pricesByCategory)
        {
            string category = dictionaryPair.Key;
            int length = dictionaryPair.Value.Count;
            returnOutput += $"\n{category} purchases: {length}";
        }
        return returnOutput;
    }
    static string Maxprice(Dictionary<string, List<float>> pricesByCategory)
    {
        List<string> maxPriceCategory = new List<string>();
        float maxPrice = 0.0f;

        foreach (var dictionaryPair in pricesByCategory)
        {
            string category = dictionaryPair.Key;
            List<float> priceList = dictionaryPair.Value;

            foreach (float price in priceList)
            {
                if (price > maxPrice)
                {
                    maxPrice = price;
                    maxPriceCategory.Clear();
                    maxPriceCategory.Add(category);
                }
                else if (price == maxPrice)
                {
                    maxPriceCategory.Add(category);
                }
            }
        }
        string result = "\nMost Expensive purchase\n-------------------------";
        foreach (string category in maxPriceCategory)
        {
            result += $"\n{category}: {maxPrice:C}";
        }
        return result;
    }
    static string LowestPrice(Dictionary<string, List<float>> pricesByCategory)
    {
        List<string> leastPriceCategorys = new List<string>();
        float leastPrice = float.MaxValue;

        foreach (var dictionaryPair in pricesByCategory)
        {
            string category = dictionaryPair.Key;
            List<float> priceList = dictionaryPair.Value;

            foreach (float price in priceList)
            {
                if (price < leastPrice)
                {
                    leastPrice = price;
                    leastPriceCategorys.Clear();
                    leastPriceCategorys.Add(category);
                }
                else if (price == leastPrice)
                {
                    leastPriceCategorys.Add(category);
                }
            }
        }

        string result = "\nLeast expensive purchase\n-------------------------";
        foreach (string category in leastPriceCategorys)
        {
            result += $"\n{category}: {leastPrice:c}";
        }
        return result;
    }
}