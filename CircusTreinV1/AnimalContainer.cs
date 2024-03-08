namespace CircusTrein;

public class AnimalContainer
{
    private readonly byte _capacity;
    public byte CurrentCapacity;
    public List<Animal> Animals = new();
    public byte CarnivoreSize;
    
    public AnimalContainer(Animal animal, byte capacity = 10)
    {
        _capacity = capacity;
        Add(animal, animal.IsCarnivore);
    }
    
    public bool Add(Animal animal, bool carnivore = false)
    {
        if (carnivore)
        {
            Animals.Add(animal);
            CurrentCapacity = animal.Size;
            CarnivoreSize = animal.Size;
            return true;//Animal added
        }
        if (CurrentCapacity + animal.Size > _capacity) return false; //Animal not added
        Animals.Add(animal);
        CurrentCapacity += animal.Size;
        return true;//Animal added
    }
}