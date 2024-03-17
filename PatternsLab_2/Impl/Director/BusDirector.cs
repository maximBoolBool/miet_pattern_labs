using PatternsLab_2.BaseClass.Classes;
using PatternsLab_2.Impl.Builders;
using PatternsLab_2.Impl.Man;
using PatternsLab_2.Impl.Vehicle;

namespace PatternsLab_2.Impl.Director;

public class BusDirector : BaseDirector<BusDriver, Passanger, Bus>
{
    public BusDirector(BusBuilder builder) : base(builder) { }
}