namespace inheritenceDemo
{
    public class Pet
    {
        //properties of our pet
        private string name, owner;
        private int age;
        private double weight;
        private string petType;

        //declare constructor
        public Pet(string type, string name, string owner, int age, double weight)
        {
            this.petType = type;
            this.age = age;
            this.name = name;
            this.weight = weight;
            this.owner = owner;
        }

        //create get and set methods for class properties. Get lets you see a value. Set will update the value

        public string getType()
        {
            return this.petType;
        }

        public string getOwner()
        {
            return owner;
        }

        public void setOwner(string newOwner)
        { 
            this.owner = newOwner;
        }

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int newAge)
        {
            this.age = newAge;
        }

        public double getWeight()
        {
            return this.weight;
        }

        public void setWeight(double newWeight)
        {
            this.weight = newWeight;
        }

        public void printPetInfo()
        {
            Console.WriteLine($"{this.name} is a {this.petType}, is {this.age} years old and {this.owner} is the owner");
        }
    }
}