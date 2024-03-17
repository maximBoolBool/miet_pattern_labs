using PatternsLab_1.AbstractFabric.BaseClasses;
using PatternsLab_1.AbstractFabric.Enum;

namespace PatternsLab_1.AbstractFabric.Classes.Models;

public class TaxiDriver : BaseDriver
{
    public TaxiDriver()
    {
        Type = TypeDrive.Taxi;
    }
}