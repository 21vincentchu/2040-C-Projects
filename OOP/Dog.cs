class Dog
{
    //declare class properties
    //for encapulstion, we hide things using private.
    public string name;
    public string owner;
    public int age;

    //declare a class constructor

    public Dog(string name, string owner, int age)
    {
        this.name = name;
        this.owner = owner;
        this.age = age;
    }

    public void getTagInfo()
    {
        Console.WriteLine($"{this.name} is {this.age} years old, and {this.owner} is the owner");
    }

    public void bark(int numOfBarks)
    {
        string bark = "";

        for(int i = 0; i < numOfBarks; i++)
        {
            bark+= "bark! ";
        }
        Console.WriteLine(bark);
    }
}