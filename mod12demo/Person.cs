using System.Text.Encodings.Web;

namespace mod12demo;

class Person
{
    //create class fields
    private string theName;
    private int age;

    private int points;

    //create properties to access fields

    public int Points
    {
        get { return points;}
        set { points = value;}
    }
    public int Age{
        get { return age; }
        set { age = value;}
    }

    public string Name{
        get { return theName; }
        set { theName = value;}
    }


    //create a class constructor
    //constructor, default constructor
    public Person()
    {
        theName = "please assign a name";
        age = -1;
    }
    
    //constructor 2, parameterized constructor
    public Person(string theName, int age)
    {
        this.theName = theName;
        this.age = age;
    }

    //method to add 1 to the person's age
    public void hasBirthday()
    {
        age++;
    }

    public void tostring()
    {
        Console.WriteLine($"{theName} is {age} years old and has {points} points");
    }
}