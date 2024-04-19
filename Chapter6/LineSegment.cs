namespace Chapter6;

internal class LineSegment(MyPoint p1, MyPoint p2)
{
	private readonly MyPoint _p1 = p1;
	private readonly MyPoint _p2 = p2;

	public double Length()
		=> Math.Sqrt(Math.Pow(_p2.X - _p1.X, 2) + Math.Pow(_p2.Y - _p1.Y, 2));
}