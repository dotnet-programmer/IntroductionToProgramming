namespace Chapter6;

internal class Cuboid(int length, int width, int height)
{
	public int Length { get; set; } = length;
	public int Width { get; set; } = width;
	public int Height { get; set; } = height;

	public double Volume()
		=> Length * Width * Height;

	public static int CompareVolumes(Cuboid p1, Cuboid p2)
		=> p1.Volume() > p2.Volume()
			? 1
			: p1.Volume() < p2.Volume()
				? -1
				: 0;
}