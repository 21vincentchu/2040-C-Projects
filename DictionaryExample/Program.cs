using System.Dynamic;
using System.Formats.Tar;

namespace DictionaryExample;

class Program
{
    static void Main(string[] args)
    {
        //Declare a dictionary of student nams and scores. NAme is a string ans score is a float
        Dictionary<string,float> studentScores = new Dictionary<string, float>(){
            {"brian", 94},
            {"cydni", 97.1f},
            {"Truman", 87.8f}
        };

        //add an entry to the dictionary
        studentScores.Add("jamie", 69.8f);

        //print values from the dictionary
        Console.WriteLine(studentScores["brian"]);
        Console.WriteLine(studentScores["cydni"]);

        Console.WriteLine("\n\n");
        //Loop through the dictionary
        foreach(KeyValuePair<string,float> student in studentScores)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }

        Console.WriteLine("\n\n");
        foreach(string key in studentScores.Keys)
        {
            Console.WriteLine($"{key}: {studentScores[key]}");
        }

        Console.WriteLine("\n\n");
        foreach(var student in studentScores)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }
        
        //Check if key exists
        Console.WriteLine("\n\n");
        String searchKey = "GGGGG";

        if(studentScores.ContainsKey(searchKey))
        {
            Console.WriteLine($"{searchKey}; {studentScores[searchKey]}");
        }else{
            Console.WriteLine($"{searchKey} does not exist in the dictionary");
        }


    }
}
