using PatternsLab_2.BaseClass.Classes;

namespace PatternsLab_2.BaseClass;

public interface IBuilder<TDriver, TPassanger, TVehicle>
    where TDriver : BaseMan
    where TPassanger : BaseMan
    where TVehicle : BaseVehicle<TDriver, TPassanger>
{
    void Create();

    TVehicle GetResult();
}