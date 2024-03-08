namespace CircusTrein
{
    public class Program
    {
        public static void Main()
        {
            var animalCount = 10000;
            
            var animals = new List<Animal>();
            
            var rng = new Random(1);
            for (var i = 0; i < animalCount; i++)
            {

                var size = rng.Next(1, 4) switch
                {
                    2 => (byte)3,
                    3 => (byte)5,
                    _ => (byte)1
                };
                
                var carnivore = rng.Next(0, 4) == 0;
                animals.Add(new Animal(carnivore, size));
            }
            
            var train = new Train(animals);
            
            train.PrintStats();

            var plane = new Plane(animals, 20);
            
            plane.PrintStats();
        }
    }
}