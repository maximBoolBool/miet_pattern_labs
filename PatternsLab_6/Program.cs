using PatternsLab6.Classes.Impl;

namespace PatternsLab6;

class Program
{
    static void Main(string[] args)
    {
        var currentProgress = new Subject();
        var deanOffice = new DeanObserver("Dean's office", currentProgress);

        var teacher = new Teacher(currentProgress);

        teacher.CreateOrUpdateProgress();
    }
}