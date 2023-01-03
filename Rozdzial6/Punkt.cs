namespace Rozdzial6
{
	internal class Punkt
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Punkt(int x, int y)
		{
			X = x;
			Y = y;
		}

		public void Przesun(int addX, int addY)
		{
			X += addX;
			Y += addY;
		}

		public void Wyswietl()
		{
			Console.WriteLine($"Wsp punktu = ({X}, {Y})");
		}
	}
}
