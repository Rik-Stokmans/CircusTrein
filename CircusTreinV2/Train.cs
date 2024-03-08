namespace CircusTreinV2;

public class Train
{
    public int CartCount;
    public int AnimalCount;
    public int AnimalCountCarnivore;
    public int AnimalCountHerbivore;
    
    public Train(List<Animal> animals)
    {
        int largeCarnivoreCount = 0;
        int mediumCarnivoreCount = 0;
        int smallCarnivoreCount = 0;
        int largeHerbivoreCount = 0;
        int mediumHerbivoreCount = 0;
        int smallHerbivoreCount = 0;

        foreach (var animal in animals)
        {
            if (animal.IsCarnivore)
            {
                switch (animal.Size)
                {
                    case 5:
                        largeCarnivoreCount++;
                        break;
                    case 3:
                        mediumCarnivoreCount++;
                        break;
                    case 1:
                        smallCarnivoreCount++;
                        break;
                }
            }
            else
            {
                switch (animal.Size)
                {
                    case 5:
                        largeHerbivoreCount++;
                        break;
                    case 3:
                        mediumHerbivoreCount++;
                        break;
                    case 1:
                        smallHerbivoreCount++;
                        break;
                }
            }
        }
        
        
        AnimalCount = animals.Count;
        AnimalCountCarnivore = largeCarnivoreCount + mediumCarnivoreCount + smallCarnivoreCount;
        AnimalCountHerbivore = AnimalCount - AnimalCountCarnivore;

        // Calculate CartCount based on the patterns

        // pattern: 5c
        CartCount = largeCarnivoreCount;

        // pattern: 3c 5h
        CartCount += mediumCarnivoreCount;
        largeHerbivoreCount = Math.Max(0, largeHerbivoreCount - mediumCarnivoreCount);

        // pattern: c1 3h 3h 3h || c1 5h 3h
        CartCount += smallCarnivoreCount;
        mediumHerbivoreCount -= smallCarnivoreCount * 3;
        largeHerbivoreCount -= smallCarnivoreCount;

        // pattern: h5 h5
        CartCount += largeHerbivoreCount / 2;
        largeHerbivoreCount %= 2;

        // pattern: h5 h3 h1 h1 || h5 h1 h1 h1 h1 h1
        CartCount += largeHerbivoreCount;
        smallHerbivoreCount -= largeHerbivoreCount * 5;

        CartCount += mediumHerbivoreCount / 3;
        mediumHerbivoreCount %= 3;

        CartCount += mediumHerbivoreCount / 2;
        smallHerbivoreCount -= mediumHerbivoreCount * 2;

        CartCount += mediumHerbivoreCount;
        smallHerbivoreCount -= mediumHerbivoreCount * 3;

        // pattern: h1 h1 h1 h1 h1 h1 h1 h1 h1 h1
        CartCount += (int)Math.Ceiling((double)smallHerbivoreCount / 10);
    }
    
    
    public void PrintStats()
    {
        Console.WriteLine($"Total carts: {CartCount}");
        Console.WriteLine($"Total animals: {AnimalCount}");
        Console.WriteLine($"Total carnivores: {AnimalCountCarnivore}");
        Console.WriteLine($"Total herbivores: {AnimalCountHerbivore}");
    }
}














