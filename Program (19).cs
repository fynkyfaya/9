Rectangle rectangle = new Rectangle(
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine())
);

Console.WriteLine(rectangle.isSquare());


class Rectangle
{
    public int x1;
    public int x2;
    public int y1;
    public int y2;

    public Rectangle(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;
    }

    public bool isSquare()
    {
        return x2 - x1 == y2 - y1;
    }
}