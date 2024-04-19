namespace Chapter6;

internal class Rectangle
{
	private static double _maxArea;

	private readonly double _length;
	private readonly double _width;

	public Rectangle(double length, double width)
	{
		_length = length;
		_width = width;

		if (Area() > _maxArea)
		{
			_maxArea = Area();
		}
	}

	private double Area()
		=> _length * _width;

	private double Perimeter()
		=> 2 * _length + 2 * _width;

	public void Display()
		=> Console.WriteLine($"Powierzchnia = {Area()}, obwód = {Perimeter()}");

	public static void BiggestRectangle()
		=> Console.WriteLine($"Najwiekszy utworzony prostokąt = {_maxArea}");
}