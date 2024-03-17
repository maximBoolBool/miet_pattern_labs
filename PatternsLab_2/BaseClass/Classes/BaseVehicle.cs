namespace PatternsLab_2.BaseClass.Classes;

public abstract class BaseVehicle<TDriver, TPassanger>
{
    public TDriver Driver;

    public List<TPassanger> Passangers;
}