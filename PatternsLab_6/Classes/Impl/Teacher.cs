namespace PatternsLab6.Classes.Impl;

public class Teacher
{
    private Subject _currentProgress;

    public Teacher(Subject currentProgress)
    {
        _currentProgress = currentProgress;
    }

    public void CreateOrUpdateProgress()
    {
        _currentProgress.State = "Updated on time";
    }
}
