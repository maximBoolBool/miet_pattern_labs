namespace PatternsLab_4;

public class Box : IBox
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public void Move(int newX, int newY)
    {
        X = newX;
        Y = newY;
        Console.WriteLine($"Box moved to ({newX}, {newY})");
    }

    public void LoadImage(string imageName)
    {
        Console.WriteLine($"Real image '{imageName}' loaded into box");
    }
}