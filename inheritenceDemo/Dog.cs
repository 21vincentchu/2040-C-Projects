namespace inheritenceDemo
{
    public class Dog : Pet
    {
        //create a constructor
        public Dog(string name, string owner, int age, double weight) : base("dog", name, owner, age, weight)
        {
            
        }
        
        
    }
}