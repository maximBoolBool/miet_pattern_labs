using PatternsLab_1.AbstractFabric.Enum;

namespace PatternsLab_1.AbstractFabric.BaseClasses;

public abstract class BaseDriver : IMan
{
    public TypeDrive Type { get; init; }
    
    public string Name { get; set; }
    
    public string Age { get; set; }
}