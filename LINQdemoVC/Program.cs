namespace LinqDemo;

class Program
{
    static void Main(string[] args)
    {
        List<Student> studentList = StudentDataLoader.LoadStudent("students.csv");

        foreach(Student student in studentList)
        {
            Console.WriteLine($"{student.getFirstName()}, {student.getLastName()}");
        }
    }
}
