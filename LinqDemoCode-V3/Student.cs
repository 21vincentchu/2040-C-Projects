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

    public void getStudentInfo(){
        Console.WriteLine($"{this.firstName} {this.lastName} - Major: {this.major}");
        Console.WriteLine($"GPA: {this.gpa} - Graduation Year: {this.gradYear}\n");
    }


}