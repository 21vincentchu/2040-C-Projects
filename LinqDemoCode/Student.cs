namespace LinqDemoCode;
public class Student{
    //declare student properties
    private string firstName, lastName, major;

    private float gpa;
    private int gradYear;

    //create the constructor
    public Student(string firstName, string lastName, string major, float gpa, int gradYear){
        this.firstName = firstName;
        this.lastName = lastName;
        this.major = major;
        this.gpa = gpa;
        this.gradYear = gradYear;
    }

    //create getters for class properties
    public string getFirstName(){
        return this.firstName;
    }

    public string getLastName(){
        return this.lastName;
    }

    public string getMajor(){
        return this.major;
    }

    public float getGPA(){
        return this.gpa;
    }

    public int getGradYear(){
        return this.gradYear;
    }

    public void getStudentInfo()
    {
        Console.WriteLine($"First name {firstName}, last name: {lastName}, Major: {major}, GPA: {gpa}, Grade year: {gradYear}");
    }


}