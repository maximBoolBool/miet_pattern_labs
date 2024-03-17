namespace PatternsLab_2.BaseClass;

public interface IDirector<TDriver, TPassanger, TVehicle>
{
    TVehicle Build();
}