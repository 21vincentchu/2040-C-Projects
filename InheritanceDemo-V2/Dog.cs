namespace InheritanceDemo{
    public class Dog : Pet{

        //create a constructor
        
        public Dog(string name, string owner, int age, double weight) : base(PetType.Dog, name, owner, age, weight){
            
        }


        //override the make sound method so that dogs can bark
        public override void MakeSound(int numSounds){
            string barkString = "";

            for(int i = 0; i < numSounds; i++){
                barkString += "Bark! ";
            }

            Console.WriteLine(barkString);
        }

    }
}