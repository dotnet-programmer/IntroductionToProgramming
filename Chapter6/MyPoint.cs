namespace Chapter6;

internal class MyPoint(int x, int y)
{
	public int X { get; set; } = x;
	public int Y { get; set; } = y;

	public void Move(int addX, int addY)
	{
		X += addX;
		Y += addY;
	}

	public void Display()
		=> Console.WriteLine($"({X}, {Y})");
}