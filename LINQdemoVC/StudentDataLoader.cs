namespace LinqDemo;

//create a class to read data fron a file and return a list of objects
public class StudentDataLoader
{

    //create a method to read data fron a file and return a list of Pets
    public static List<Student> LoadStudent(string filePath)
    {

        //create a pet list to return
        List<Student> studentList = new List<Student>();

        //open the csv file
        using(StreamReader fileReader = new StreamReader(filePath))
        {
            int lineNumber = 0;
            int peicesOfData = 5;

             string lineOfData = fileReader.ReadLine()!;

            //parse the data using the split method
            //read file line by line

            while(!fileReader.EndOfStream)
            {

                //read the next line in the file
                lineOfData = fileReader.ReadLine()!;
                lineNumber++;

                //string array <- split data at the comma
                string[] studentData = lineOfData.Split(",");

                //check if data is in the right format
                if(studentData.Length != peicesOfData)
                {
                    string errorMessage = $"Row {lineNumber} contains {studentData.Length} pieces of data. It should contain {peicesOfData} pieces of data ";
                    LogError(errorMessage);
                    continue;
                    //throw new Exception($"Row {lineNumber} contains {petData.Length} pieces of data. It should contain {peicesOfData} pieces of data ");
                }

                //get the pieces of data from the string array
                //convert data types where necessary

                try
                {
                    string firstName = studentData[0];
                    string lastName = studentData[1];
                    string major = studentData[2];
                    float gpa = float.Parse(studentData[3]);
                    int gradYear = int.Parse(studentData[4]);

                    studentList.Add(new Student(firstName, lastName, major, gpa, gradYear));
                }
                catch(Exception err)
                {
                    string message = $"There was an error reading the file on line {lineNumber}: {err.Message}";
                    LogError(message);
                    continue;
                }

            }
        }

        //return pet list
        return studentList;
    }

    public static void LogError(string errorMessage)
    {
        //Log error message into a while called log.txt
        //append means keep the old content, and keep adding 
        using(StreamWriter logger = File.AppendText("log.txt"))
        {
            logger.WriteLine(errorMessage);
        }
        return;
    }

}