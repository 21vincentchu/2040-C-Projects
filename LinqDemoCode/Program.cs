using Microsoft.VisualBasic;

namespace LinqDemoCode;
class Program
{
    static void Main(string[] args)
    {
        if(args.Length != 2)
        {
            Console.WriteLine("PLease enter the following command line args: <student_file_path> <report_file_path>");
            Environment.Exit(0);
        }

        string fileName = args[0];
        string theReport = args[1];
        string reportDocument = "";

        //get a list of students
        List<Student> studentList = StudentDataLoader.loadStudents("students.csv");

        foreach (Student student in studentList)
        {
            student.getStudentInfo();
        }

        var deansListStudents = from student in studentList
                                where student.getGPA() >= 3.5
                                select student;

        reportDocument +="Deans List student\n__________________";

        foreach(var student in deansListStudents)
        {
            reportDocument += $"Name: {student.getFirstName()} {student.getLastName()} {student.getGPA()}\n";
        }

        var studentsWithMNames = from student in studentList
                                 where student.getFirstName().StartsWith("M")
                                 select student;
        foreach(var student in studentsWithMNames)
        {
            reportDocument += $"Name: {student.getFirstName()} {student.getLastName()}\n";
        }

        //find the lowest gpa between 2016 - 2020
        var minGPA2016_2020 = (from student in studentList
                              where student.getGradYear() >= 2016 && student.getGradYear() <= 2020
                              select student.getGPA())
                              .Min();

        reportDocument += $"min GPA 2016-2020: {minGPA2016_2020:n2}";

        //get students names and graduation year with the lowest gpa in the data set

        var lowestGPA = from student in studentList
                        where student.getGPA() == (from otherStudent in studentList select otherStudent.getGPA()).Min()
                        select student;

        foreach(var student in studentList)
        {
            
        }

        //write the report document
        using(StreamWriter reportWriter = new StreamWriter(theReport))
        {
            reportWriter.Write(reportDocument);
        }
    }
}
