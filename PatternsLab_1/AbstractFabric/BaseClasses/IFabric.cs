namespace PatternsLab_1.AbstractFabric.BaseClasses;

public interface IFabric<T> where T : IMan
{
    T Create();
}