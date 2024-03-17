using PatternsLab_2.BaseClass.Classes;
using PatternsLab_2.Impl.Builders;
using PatternsLab_2.Impl.Man;
using PatternsLab_2.Impl.Vehicle;

namespace PatternsLab_2.Impl.Director;

public class TaxiDirector : BaseDirector<TaxiDriver, Passanger, Taxi>
{
    public TaxiDirector(TaxiBuilder builder) : base(builder) { }
}