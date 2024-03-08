namespace CircusTreinV2
{
    public class Program
    {
        public static void Main()
        {
            var animals = Animal.GenerateAnimals(10000000);
            
            var train = new Train(animals);
            
            train.PrintStats();
        }
    }
}