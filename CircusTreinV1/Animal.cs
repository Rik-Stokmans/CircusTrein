namespace CircusTrein;

public class Animal
{
    public bool IsCarnivore { get; set; }
    
    public byte Size { get; set; }
    
    public static List<Animal> SortDescCarnivoresFirst(List<Animal> animals)
    {
        return animals.OrderByDescending(a => a.IsCarnivore).ThenByDescending(a => (int) a.Size).ToList();
    }
    
    public Animal(bool isCarnivore, byte size)
    {
        IsCarnivore = isCarnivore;
        Size = size;
    }
}