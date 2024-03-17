namespace PatternsLab_3.Impl;

public abstract class Man : IElement
{
    public string? Name { get; set; }
    
    public string? Female { get; set; }
    
    public int? Age { get; set; }
    

    public virtual void Display()
    {
        Console.WriteLine($"{Name}--{Female}--{Age}");
    }
}