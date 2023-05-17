namespace Rozdzial6;

internal class Prostokat
{
	private readonly double dlugosc;
	private readonly double szerokosc;
	private static double maxPole;

	public Prostokat(double dlugosc, double szerokosc)
	{
		this.dlugosc = dlugosc;
		this.szerokosc = szerokosc;
		if (Powierzchnia() > maxPole)
		{
			maxPole = Powierzchnia();
		}
	}

	private double Powierzchnia() => this.dlugosc * this.szerokosc;

	private double Obwod() => 2 * this.dlugosc + 2 * this.szerokosc;

	public void Prezentuj() => Console.WriteLine($"Powierzchnia = {Powierzchnia()}, obwód = {Obwod()}");

	public static void Najwiekszy() => Console.WriteLine($"Najwiekszy utworzony prostokąt = {maxPole}");
}