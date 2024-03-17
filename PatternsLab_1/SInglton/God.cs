namespace PatternsLab_1.SInglton;

public class God
{
    private static bool _isCreated;
    
    public string? Name { get; set; }
    
    public int? Age { get; set; }

    private God() { }

    private static God instanse;
    
    public static God Create()
    {
        if (!_isCreated)
        {
             _isCreated = true;
             instanse = new God();
             return instanse;
        }

        return instanse;
    }
}