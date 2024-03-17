namespace PatternsLab_2.BaseClass.Classes;

public class BaseBuilder<TDriver, TPassanger, TVehicle> : IBuilder<TDriver, TPassanger, TVehicle>
    where TDriver : BaseMan, new()
    where TPassanger : BaseMan, new()
    where TVehicle : BaseVehicle<TDriver, TPassanger>, new()
{
    private TDriver _driver;

    private List<TPassanger> _passangers;

    private TVehicle _vehicle;

    protected virtual int MaxPassangerCount { get; set; }

    protected void BuildPassangers()
    {
        _passangers = new();
        
        for (int i = 0; i < MaxPassangerCount; i++)
        {
            _passangers.Add(new TPassanger());
        }
    }

    protected void BuildDrivers()
    {
        _driver = new TDriver();
    }

    public void Create()
    {
        BuildDrivers();
        BuildPassangers();

        var _vehicle = new TVehicle();

        _vehicle.Driver = _driver;
        _vehicle.Passangers = _passangers;
    }

    public TVehicle GetResult()
    {
        return _vehicle;
    }
}