namespace Rozdzial6
{
	internal class Odcinek
	{
		private readonly Punkt p1;
		private readonly Punkt p2;

		public Odcinek(Punkt p1, Punkt p2)
		{
			this.p1 = p1;
			this.p2 = p2;
		}

		public double DlugoscOdcinka()
		{
			return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
		}
	}
}
