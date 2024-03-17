using PatternsLab_3.Impl.Enums;

namespace PatternsLab_3.Impl;

public class Group : IElement
{
    private readonly List<IElement> _elements;
    private readonly PlaceLandType _groupType;
    private readonly int _groupConstraint;
    
    public Group(List<IElement> elements, PlaceLandType groupType, int groupConstraint)
    {
        _elements = elements;
        _groupType = groupType;
        _groupConstraint = groupConstraint;
    }

    public void AddElement(IElement element)
    {
        if (!(_groupConstraint < _elements.Count))
        {
            _elements.Add(element);
            return;
        }
        Console.WriteLine("To many Elements");
    }
    
    public void Display()
    {
        Console.WriteLine(_groupType + ":\n");
        foreach (var element in _elements)
        {
            element.Display();
        }
    }
}