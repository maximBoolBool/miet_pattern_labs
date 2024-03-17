namespace PatternsLab6.Classes.Impl;

public class Subject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _state;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public string State
    {
        get { return _state; }
        set
        {
            _state = value;
            Notify();
        }
    }
}