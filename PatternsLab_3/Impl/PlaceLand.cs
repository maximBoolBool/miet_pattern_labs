using PatternsLab_3.Impl.Enums;

namespace PatternsLab_3.Impl;

public class PlaceLand : IElement
{
    public Passanger? Passanger { get; set; }
    
    public int? CargoWeight { get; set; }
    
    public PlaceLandType? Type { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Type}---{CargoWeight}");
    }
}