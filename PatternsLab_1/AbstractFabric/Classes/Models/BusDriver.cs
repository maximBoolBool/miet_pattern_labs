using PatternsLab_1.AbstractFabric.BaseClasses;
using PatternsLab_1.AbstractFabric.Enum;

namespace PatternsLab_1.AbstractFabric.Classes.Models;

public class BusDriver : BaseDriver
{
    public BusDriver()
    {
        Type = TypeDrive.Bus;
    }
}