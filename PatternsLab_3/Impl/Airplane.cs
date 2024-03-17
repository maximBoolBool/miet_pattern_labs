using System.ComponentModel;

namespace PatternsLab_3.Impl;

public class Airplane : IElement
{
    #region consts

    private const int MaxCargoWeight = 10000;

    private readonly List<IElement> _elements;

    #endregion

    #region .ctor

    public Airplane()
    {
        _elements = new();
    }
    
    #endregion

    #region Methods
    
    public void AddElement(IElement element)
    {
        _elements.Add(element);
    }
    
    public void Display()
    {
        foreach (var component in _elements)
        {
            component.Display();
        }
    }

    #endregion
}