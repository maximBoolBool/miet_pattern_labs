namespace PatternsLab_1.AbstractFabric.BaseClasses;

public abstract class BaseTransportInspector<TDriver, TPassnger> 
    where TDriver : BaseDriver, IMan 
    where TPassnger : IMan
{
    private List<TPassnger> _passngers;
    private TDriver? _driver;
    private IFabric<TDriver> _driverFabric;
    private IFabric<TPassnger> _passangerFabric;

    protected virtual int PassangersMaxCount { get; set; }

    public BaseTransportInspector(IFabric<TDriver> driverFabric, IFabric<TPassnger> passangerFabric)
    {
        _driverFabric = driverFabric;
        _passangerFabric = passangerFabric;
        _passngers = new List<TPassnger>();
    }

    public void AddPassanger()
    {
        if (_passngers.Count < PassangersMaxCount)
        {
            var passanger = _passangerFabric.Create();
            _passngers.Add(passanger);
            Console.WriteLine("New Passanger has appeared");
        }
        else
        {
            Console.WriteLine("Cannot add new passanger");
        }
    }

    public void AddDriver()
    {
        if (_driver == null)
        {
            _driver = _driverFabric.Create();
            Console.WriteLine("Add new driver");
        }
        else
        {
            Console.WriteLine("Cannot add new driver");
        }
    }

    public bool IsReady()
    {
        return _driver != null && _passngers.Any();
    }
}