namespace PatternsLab_1.AbstractFabric.BaseClasses;

public abstract class BaseFabric<T> : IFabric<T>  where T : IMan, new()
{
    public T Create() => new T();
}