namespace PatternsLab_4;

public class BoxProxy
{
    private readonly Box _box;

    public BoxProxy(Box box)
    {
        _box = box;
    }

    public void Move(int newX, int newY)
    {
        _box.Move(newX, newY);
    }

    public void LoadImage(string imageName)
    {
        _box.LoadImage(imageName);
    }
}