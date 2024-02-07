namespace FileWriteDemo;

class Program
{
    static void Main(string[] args)
    {
        //create a file handlder, creating a streamer writer, called fileWriter. that will write to a file called demofile.txt
        //CS is going to check in the directory if that file is in there. If it DOES exist, it will write to that file. if it DOESN"T exist
        //it'll MAKE that file, and write to that file.
        using(StreamWriter fileWriter = new StreamWriter("demofile.txt"))
        {
            fileWriter.WriteLine("This is my first line");
        }
        //using block, it'll close FOR me.

        //create a streamwriter object
        StreamWriter fileWriter2 = new StreamWriter("demofile2.txt");
        try
        {
            fileWriter2.WriteLine("This is some text for my file");
            fileWriter2.Close();

        }
        catch(Exception err)
        {
            //if an exception occurs, print the error message
            Console.WriteLine($"exception: {err.Message}");
        }
        finally
        {
            if(fileWriter2 !=null)
            {
                fileWriter2.Close();
            }
        }

        //String methods
        //a string is a list of characters
        string demoString = "truman";

        //loop through a string
        foreach(char letter in demoString)
        {
            Console.WriteLine(letter);
        }

        //endswith method
        string searchString = "Tiger";

        //if demostring ends with truman
        if(demoString.EndsWith(searchString))
        {
            Console.WriteLine($"String ends with {searchString}");
        }else {
            demoString = demoString + " " + searchString;
        }
    }
}