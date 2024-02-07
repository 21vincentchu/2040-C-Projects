namespace InheritanceDemo;

public class Cat : Pet{

    //create the constructor
    public Cat(string name, string owner, int age, double weight) : base(PetType.Cat, name, owner, age, weight){

    }

    //overrride the make sound methos to have the cat meow
    public override void MakeSound(int numSounds)
    {
        string meowString = "";

        for(int i = 0; i < numSounds; i++){
            meowString += "Meow! ";
        }

        Console.WriteLine(meowString);
    }
}