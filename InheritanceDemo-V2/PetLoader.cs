namespace InheritanceDemo;

//create a class to read data fron a file and return a list of objects
public class PetDataLoader{

    //create a method to read data fron a file and return a list of Pets
    public static List<Pet> loadPets(string filePath){

        //create a pet list to return
        List<Pet> petList = new List<Pet>();

        //open the csv file
        using(StreamReader fileReader = new StreamReader(filePath)){

            //parse the data using the split method
            //read file line by line
            while(!fileReader.EndOfStream){
                //read the next line in the file
                string lineOfData = fileReader.ReadLine()!;

                //string array <- split data at the comma
                string[] petData = lineOfData.Split(",");

                //get the pieces of data from the string array
                //convert data types where necessary
                string petName = petData[0];
                string owner = petData[1];
                int petAge = int.Parse(petData[2]);
                double petWeight = double.Parse(petData[3]);
                string petType = petData[4];

                //create instances of pet (dogs and cats)
                //place dogs and cats in a list
                if(petType == "dog"){
                    petList.Add(new Dog(petName, owner, petAge, petWeight));
                }else{
                    petList.Add(new Cat(petName, owner, petAge, petWeight));
                }
                
            }
            
        }
        //return pet list
        return petList;
    }

}