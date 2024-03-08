namespace CircusTrein;

public class Vehicle
{
    private List<AnimalContainer> Carts { get; } = new();

    private readonly byte _containerCapacity;
    
    public Vehicle(List<Animal> animals, byte containerCapacity = 10)
    {
        _containerCapacity = containerCapacity;
        
        animals = Animal.SortDescCarnivoresFirst(animals);

        foreach (var animal in animals) AddAnimal(animal);
    }

    private void AddAnimal(Animal animal)
    {
        if (animal.IsCarnivore) Carts.Add(new AnimalContainer(animal, _containerCapacity));
        

        else if (Carts.Where(cart => cart.CarnivoreSize < animal.Size).Any(cart => cart.Add(animal))){}

        else Carts.Add(new AnimalContainer(animal, _containerCapacity));
    }


    public void Print()
    {
        foreach (var cart in Carts)
        {
            Console.WriteLine($"AnimalContainer: {cart.Animals.Count} animals");
            foreach (var animal in cart.Animals)
            {
                Console.WriteLine($"Animal: {animal.Size} - " + (animal.IsCarnivore ? "IsCarnivore" : "Herbivore"));
            }
        }
    }
    
    public void PrintStats()
    {
        Console.WriteLine($"Total carts: {Carts.Count}");
        Console.WriteLine($"Total animals: {Carts.Sum(c => c.Animals.Count)}");
        Console.WriteLine($"Total carnivores: {Carts.Sum(c => c.Animals.Count(a => a.IsCarnivore))}");
        Console.WriteLine($"Total herbivores: {Carts.Sum(c => c.Animals.Count(a => !a.IsCarnivore))}");
    }
}