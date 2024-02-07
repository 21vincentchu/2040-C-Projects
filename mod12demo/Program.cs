namespace mod12demo;

class Program
{
    static void Main(string[] args)
    {
        //create two person objects

        Person person1 = new Person();
        Person person2 = new Person();

        person1.Name = "bob";
        person1.Age = 20;

        Person person3 = new Person("Alice", 18);
        Person person4 = new Person("claire", 21);

        //create a list of persons
        List<Person> personList = new List<Person>();
        personList.Add(person1);
        personList.Add(person2);
        personList.Add(person3);
        personList.Add(person4);

        foreach(Person person in personList)
        {
            person.tostring();
        }


        //Search the list for alice and add 1 to her age
        Console.WriteLine("Seraching list\n________________________________");
        foreach(Person person in personList)
        {
            if(person.Name == "alice")
            {
                person.hasBirthday();
                person.tostring();
            }
        }

        Console.WriteLine("Seraching list\n________________________________");
        Person foundPerson = new Person();

        foreach(Person person in personList)
        {
            if(person.Name == "alice")
            {
                foundPerson = person;
            }
        }

        foundPerson.tostring();
        foundPerson.hasBirthday();
        foundPerson.tostring();

        foreach(var person in personList)
        {
            person.tostring();
        }

        Console.WriteLine("Seraching list using linq\n________________________________");

        var searchPerson = from person in personList
                           where person.Name == "alice"
                           select person;
        foreach(var person in searchPerson)
        {
            person.tostring();
            person.hasBirthday();
            person.tostring();
        }

        Console.WriteLine("reference types vs value types\n__________________________");
        int a = 5;
        int b = a;
        a = 10;

        Console.WriteLine($"a = {a}"); //a is 10
        Console.WriteLine($"b = {b}"); //b is 5

        Console.WriteLine();
        Person person5 = new Person("jery", 22);
        Person person6 = person5;
        person5.Name = "syd";
        person5.Age = 30;

        person5.tostring();
        person6.tostring();

        Console.WriteLine($"\nStructure demo\n____________________________");
        //create two instances of the person structure

        PersonStruct struct1 = new PersonStruct("keisha", 27);
        PersonStruct struct2 = new PersonStruct("Frank", 29);

        PersonStruct struct3 = struct1;
        
        //change struct1 name and age

        struct1.Name = "ronnie";
        struct1.Age = 35;

        struct1.tostring();
        struct2.tostring();

        //create a list of person structures
        List<PersonStruct> structList = new List<PersonStruct>();
        structList.Add(struct1);
        structList.Add(struct2);
        structList.Add(struct3);

        //simulate sending a person player to play the game
        playGame(person1);
        playGame(person1);
        playGame(person3);
        playGame(person4);

        //write a report for all person players
        Console.WriteLine("Person player report\n_________________________");
        foreach(var person in personList)
        {
            person.tostring();
        }

        playstructGame(struct1);
        playstructGame(struct1);
        playstructGame(struct3);

         Console.WriteLine("Person player report\n_________________________");
        foreach(var person in structList)
        {
            person.tostring();
        }

        Console.WriteLine("-----Anonymous Type Demonstration------\n");
        //create a list of anonymous types
        var anonymousTypeList = new List<object>(){
            new{name = "John", age = 25, points = 10},
            new{name = "jane", age = 30, points = 15},
            new{name = "jance", age = 24, points = 20}
        };

        foreach(var person in anonymousTypeList.GetType().GetProperties())
        {
            Console.WriteLine($"{person.Name}");
        }





    }

    //create a function to add points liek we are playing a game
    public static void playGame(Person player)
    {
        //assign player some points
        player.Points += 10;
    }

     public static PersonStruct playstructGame(PersonStruct player)
    {
        //assign player some points
        player.Points += 10;

        return player;
    }
}
