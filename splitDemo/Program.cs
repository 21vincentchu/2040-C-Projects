namespace splitDemo;
class Program
{
    static void Main(string[] args)
    {
        //create a stream reader object to open the file
        using (StreamReader sr = new StreamReader("data.txt"))
        {
            int lineNumber = 0;
            while(!sr.EndOfStream)
            {
                //read the file line by line
                string lineofData = sr.ReadLine()!;
                lineNumber +=1;

                //Skip the first line
                if(lineNumber == 1)
                {
                    continue;
                }

                //split the data at the comma and space ", "
                string [] dataFromLine = lineofData.Split(", ");

                //Get the data from string array
                string studentName = dataFromLine[0];
                int age = int.Parse(dataFromLine[1]);
                string major = dataFromLine[2];
                float gpa = float.Parse(dataFromLine[3]);

                //print the data in a readable format

                Console.WriteLine($"{studentName} is {age} years old. They are majoring in {major} and their gpa is {gpa} ");
            }
        }
    }
}