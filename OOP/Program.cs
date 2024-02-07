namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        //create an instance of Dog
        Dog klee = new Dog("klee","jason", 4);
        klee.getTagInfo();

        klee.age = 5;
        klee.getTagInfo();

        Dog lucky = new Dog("Lucky", "lauren", 14);
        lucky.getTagInfo();
        lucky.bark(4);
        klee.bark(5);
    }
}
