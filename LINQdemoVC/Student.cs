namespace LinqDemo;

public class Student
{
    //declare student properties
    private string firstName;
    private string lastName;
    private string major;
    private float gpa;
    private int gradYear;

    //create the constructor
    public Student(string firstName, string lastName, string major, float gpa, int gradYear)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.major = major;
        this.gpa = gpa;
        this.gradYear = gradYear;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public string getMajor()
    {
        return major;
    }

    public float getGPA()
    {
        return gpa;
    }

    public int getGradYear()
    {
        return gradYear;
    }
}