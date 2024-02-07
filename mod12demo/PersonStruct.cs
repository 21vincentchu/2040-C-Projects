namespace mod12demo;

public struct PersonStruct
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
    public int Age
    {
        get { return age; }
        set { age = value;}
    }

    public string Name
    {
        get { return theName; }
        set { theName = value;}
    }

     public PersonStruct(string theName, int age)
    {
        this.theName = theName;
        this.age = age;
    }

     public void hasBirthday()
    {
        age++;
    }

    public void tostring()
    {
        Console.WriteLine($"{theName} is {age} years old and has {points} points");
    }

    //both are objects, person class, person structure. 
    //structs are value types, not reference types
    //structs do not have a default constructor
    //Why use structs vs class
    //Struct: Reading in student data, store the student data in a type of object. Didn't need inheritence. 
    //class: Developing an application with students / professors / cars / and implement a COMMON class for them. They will have inheritence
}