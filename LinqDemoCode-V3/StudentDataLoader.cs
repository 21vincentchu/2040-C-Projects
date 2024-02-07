namespace LinqDemoCode;

//create a class to read data fron a file and return a list of objects
public class StudentDataLoader{

    //create a method to read data fron a file and return a list of Pets
    public static List<Student> loadStudents(string filePath){

        //create a pet list to return
        List<Student> studentList = new List<Student>();

        //open the csv file
        using(StreamReader fileReader = new StreamReader(filePath)){
            //creater counter to keep trach of where in the file we are reading from
            int lineNumber = 0;
            int piecesOfData = 5;

            //read and discard the first line in the file
            string lineOfData = fileReader.ReadLine()!;

            //parse the data using the split method
            //read file line by line
            while(!fileReader.EndOfStream){
                //read the next line in the file
                lineOfData = fileReader.ReadLine()!;

                //increment the counter
                lineNumber ++; //lineNumber +=1 or lineNumber = lineNumber + 1

                //string array <- split data at the comma
                string[] studentData = lineOfData.Split(",");

                //check if data is in the correct format
                if(studentData.Length != piecesOfData){
                    string errorMessage = $"Row {lineNumber} contains {studentData.Length} pieces of data. It should contain {piecesOfData} pieces of data";
                    LogError(errorMessage);
                    continue;
                    //throw new Exception($"Row {lineNumber} contains {studentData.Length} pieces of data. It should contain {piecesOfData} pieces of data");
                }

                //get the pieces of data from the string array
                //convert data types where necessary
                try{
                    string firstName = studentData[0];
                    string lastName = studentData[1];
                    string major = studentData[2];
                    float gpa = float.Parse(studentData[3]);
                    int gradYear = int.Parse(studentData[4]);

                    studentList.Add(new Student(firstName, lastName, major, gpa, gradYear)); 
                }catch(Exception err){
                    string message = $"There was an error reading the file on line {lineNumber}: {err.Message}";
                    LogError(message);
                    continue;
                }
       
            }
            
        }
        //return student list
        return studentList;
    }


    public static void LogError(string errorMessage){
        //log error message into a file called log.txt
        using (StreamWriter logger = File.AppendText("log.txt")){
            logger.WriteLine(errorMessage);
        }

        return;

    }



}