namespace PatternsLab6.Classes.Impl;

public class DeanObserver : IObserver
{
    private string _name;
    private ISubject _subject;

    public DeanObserver(string name, ISubject subject)
    {
        _name = name;
        _subject = subject;
        _subject.Attach(this);
    }

    public void Update(ISubject subject)
    {
        if (subject is Subject concreteSubject)
        {
            Console.WriteLine($"{_name} received new data: {concreteSubject.State}");
            CheckDeadline(concreteSubject.State);
        }
    }

    private void CheckDeadline(string state)
    {
        if (!IsUpdatedOnTime(state))
        {
            Console.WriteLine($"{_name} notifies the department about the delay");
        }
    }

    private bool IsUpdatedOnTime(string state)
    {
        return state.ToLower().Contains("updated");
    }
}
