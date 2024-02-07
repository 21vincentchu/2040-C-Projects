namespace inheritenceDemo;

class Program
{
    static void Main(string[] args)
    {
        Pet myDog = new Pet("dog", "Fido", "tim", 5, 7.5);
        myDog.printPetInfo();
        myDog.setAge(9);
        myDog.printPetInfo();

        Dog winston = new Dog("Winston", "Jae", 7, 11.2);
        winston.printPetInfo();
        winston.setWeight(12.5);
        winston.printPetInfo();
    }
}
