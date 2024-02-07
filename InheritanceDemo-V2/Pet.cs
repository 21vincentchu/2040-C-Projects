
namespace InheritanceDemo{
    public class Pet{
        //declare class properties
        private string name, owner;
        private int age;
        private double weight;

        private PetType petType;

        //declare a construtor
        public Pet(PetType type, string name, string owner, int age, double weight){
            this.petType = type;
            this.name = name;
            this.age = age;
            this.owner = owner;
            this.weight = weight;
        }

        //create get and set methods for class properties
        public PetType getType(){
            return this.petType;
        }

        public string getOwner(){
            return this.owner;
        }

        public void setOwner(string newOwner){
            this.owner = newOwner;
        }

        public string getName(){
            return this.name;
        }

        public int getAge(){
            return this.age;
        }

        public void setAge(int newAge){
            this.age = newAge;
        }
        public double getWeight(){
            return this.weight;
        }

        public void setWeight(double newWeight){
            this.weight = newWeight;
        }
        
        public void printPetInfo(){
            Console.WriteLine($"{this.name} is a {this.petType} and is {this.age} years old and {this.owner} is the owner");
        }

        //create a make sound method
        public virtual void MakeSound(int numSounds){
            Console.Write("This animal does not make a sound.");
        }



    }
}