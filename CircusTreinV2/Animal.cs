namespace CircusTreinV2;

public class Animal
{
    public bool IsCarnivore { get; set; }

    public byte Size { get; set; }
    
    public Animal(bool isCarnivore, byte size)
    {
        IsCarnivore = isCarnivore;
        Size = size;
    }

    public static List<Animal> GenerateAnimals(int count)
    {
        var animals = new List<Animal>();
        
        var rng = new Random(1);
        for (var i = 0; i < count; i++)
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
        
        return animals;
    }
}