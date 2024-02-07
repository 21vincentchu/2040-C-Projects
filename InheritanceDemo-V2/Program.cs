namespace InheritanceDemo;
class Program
{
    static void Main(string[] args)
    {
       
        //create a list of dogs
        List<Pet> petList = PetDataLoader.loadPets("data.csv");
        
        //print all of the pet info
        foreach(Pet pet in petList){
            pet.printPetInfo();
        }
        
    }
}
