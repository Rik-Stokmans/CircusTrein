namespace CircusTrein;

public class Plane : Vehicle
{
    public Plane(List<Animal> animals, byte containerCapacity) : base(animals, containerCapacity)
    {
    }
    
    public Plane(List<Animal> animals) : base(animals)
    {
    }
}