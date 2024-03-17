using PatternsLab_2.BaseClass.Classes;
using PatternsLab_2.Impl.Man;
using PatternsLab_2.Impl.Vehicle;

namespace PatternsLab_2.Impl.Builders;

public class TaxiBuilder : BaseBuilder<TaxiDriver, Passanger, Taxi>
{
    protected override int MaxPassangerCount { get; set; } = 4;
}