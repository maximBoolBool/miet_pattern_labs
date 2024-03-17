using PatternsLab_4;

Box box = new Box { Width = 100, Height = 50, X = 50, Y = 50 };
BoxProxy boxProxy = new BoxProxy(box);

boxProxy.Move(100, 100);

Console.WriteLine("Double click right mouse button to load real image into box.");

bool rightMouseClicked = false;
while (!rightMouseClicked)
{
    if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
    {
        rightMouseClicked = true;
        Console.WriteLine("Loading real image into box...");
        boxProxy.LoadImage("TestImage");
    }
}