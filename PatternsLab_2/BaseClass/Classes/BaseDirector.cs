namespace PatternsLab_2.BaseClass.Classes;

public abstract class BaseDirector<TDriver, TPassanger, TVehicle> : IDirector<TDriver, TPassanger, TVehicle>
    where TDriver : BaseMan, new()
    where TPassanger : BaseMan, new()
    where TVehicle : BaseVehicle<TDriver, TPassanger>, new()
{
    private BaseBuilder<TDriver, TPassanger, TVehicle> _builder;

    public BaseDirector(BaseBuilder<TDriver, TPassanger, TVehicle> builder)
    {
        _builder = builder;
    }
    
    public TVehicle Build()
    {
        _builder.Create();
        return _builder.GetResult();
    }
}