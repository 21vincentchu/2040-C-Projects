namespace LinqDemoCode;
class Program
{
    static void Main(string[] args)
    {
        //get command line arguments provided by the user
        //check that the user has passed 2 command line arguments
        if(args.Length != 2){
            //display Error message and end the program
            Console.WriteLine("Please enter the following command line args: <student_file_path> <report_file_path>");
            Environment.Exit(0);
        }

        string fileName = args[0];
        string theReport = args[1];
        string reportDocument = "";
       
        //get a list of students
        List<Student> studentList = StudentDataLoader.loadStudents(fileName);

        foreach(Student student in studentList){
                student.getStudentInfo(); 
        }

        //Process stuednt data using LINQ
        //Get Dean's list students: gpa >=3.5
        var deansListStudents = from student in studentList
                                where student.getGPA() >= 3.5
                                select student;

        reportDocument += "Deans List Students\n------------------------\n";

        foreach(var student in deansListStudents){
            reportDocument += $"Name: {student.getFirstName()} {student.getLastName()} {student.getGPA()}\n";
        }

        //Get students whose names begin with the letter M
        var studentsWithMNames = from student in studentList
                                where student.getFirstName().StartsWith("M")
                                select student;

        reportDocument += "\nStudents Names that Begin with M\n---------------------------\n";

        //loop through the results
        foreach(var student in studentsWithMNames){
            reportDocument += $"Name: {student.getFirstName()} {student.getLastName()}\n";
        }

        //find the lowest gpa between 2016 and 2020
        var minGPA2016_2020 = (from student in studentList
                                where student.getGradYear() >= 2016 && student.getGradYear() <= 2020
                                select student.getGPA()).Min();

        reportDocument += $"\nMin GPA 2016 - 2020: {minGPA2016_2020:N2}";

        //find the highest GPA between 2016 and 2020
        var maxGPA2016_2020 = (from student in studentList
                                where student.getGradYear() >= 2016 && student.getGradYear() <= 2020
                                select student.getGPA()).Max();

        reportDocument += $"\nMax GPA 2016 - 2020: {maxGPA2016_2020:N2}";

        //find the average GPA between 2016 and 2020
        var avgGPA2016_2020 = (from student in studentList
                                where student.getGradYear() >= 2016 && student.getGradYear() <= 2020
                                select student.getGPA()).Average();

        reportDocument += $"\nAverage GPA 2016 - 2020: {avgGPA2016_2020:N2}";

        //get students names and graduation year with the lowest gpa in the data set
        var lowestGPA = from student in studentList
                        where student.getGPA() == (from otherStudent in studentList select otherStudent.getGPA()).Min()
                        select student;

        reportDocument += "\n\nStudent with Lowest GPA\n-----------------------\n";

        foreach(var student in lowestGPA){
            reportDocument += $"Name: {student.getFirstName()} {student.getLastName()}\nGPA: {student.getGPA():N2} -- Grad Year: {student.getGradYear()}\n\n";
        }


        //List students by graduation year
        var studentByGradYear = 
                            from student in studentList 
                            group student by student.getGradYear() into gradYearGroup
                            orderby gradYearGroup.Key 
                            select gradYearGroup;
        
        //loop through the results
        reportDocument += "\nStudents by Graduation Year\n----------------------------\n";
        //loop through grad year groups
        foreach(var yearGroup in studentByGradYear){
            reportDocument += $"\nGraduation Year: {yearGroup.Key}\n-----------------------\n";
            //loop through students in the grad year group
            foreach(var student in yearGroup){
                reportDocument += $"Name: {student.getFirstName()} {student.getLastName()}\n";
            }

        }

        //How many students graduated each year
        reportDocument += "\nNumber of Graduates By Year\n--------------------------------\n";
        foreach(var yearGroup in studentByGradYear){
            reportDocument += $"Graduation Year: {yearGroup.Key} - {yearGroup.Count()}\n";
        }


        //Get a list of distinct majors
        var studentByMajor = 
                            from student in studentList
                            group student by student.getMajor() into majorGroup
                            orderby majorGroup.Key
                            select majorGroup;

        reportDocument += "\nDistinct Majors\n--------------------\n";
        foreach(var majorGroup in studentByMajor){
            reportDocument += $"{majorGroup.Key}\n";
        }


        var distinctMajors = 
                            (from student in studentList
                            select student.getMajor()).Distinct();
                            distinctMajors.Order();
        
        reportDocument += "\nDistinct Majors #2\n--------------------\n";
        foreach(var major in distinctMajors){
            reportDocument += $"{major}\n";
        }


        //List students by Major
        reportDocument += "\nStudents By Major\n--------------------------\n";
        
        //loop through each major group
        foreach(var majorGroup in studentByMajor){
            reportDocument += $"\n{majorGroup.Key}\n-------------------\n";
            foreach(var student in majorGroup){
                reportDocument += $"{student.getFirstName()} {student.getLastName()}\n";
            }
        }


        //calculate the averge gpa for each year
        var avgGPAbyYear = from student in studentList
                           group student by student.getGradYear() into yearGroup 
                           orderby yearGroup.Key
                           select new {year = yearGroup.Key, avgGPA = yearGroup.Average(student => student.getGPA())};

        foreach(var result in avgGPAbyYear)
        {
            Console.WriteLine($"{result.year}: {result.avgGPA:N2}");
        }

        //get the number of gradtes for each year
        var numGradsByYear = from student in studentList
                           group student by student.getGradYear() into yearGroup //place students into groups based on grad year. 
                           orderby yearGroup.Key
                           select new {year = yearGroup.Key, numStudents = yearGroup.Count()};
        Console.WriteLine("\n");
        foreach(var result in numGradsByYear)
        {
            Console.WriteLine($"{result.year}: {result.numStudents}");
        }


        //write the report document
        using(StreamWriter reportWriter = new StreamWriter(theReport)){
            reportWriter.Write(reportDocument);
        }

    }
}
