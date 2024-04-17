namespace Chapter6;

internal class Prostopadloscian
{
	public int Dlugosc { get; set; }
	public int Szerokosc { get; set; }
	public int Wysokosc { get; set; }

	public Prostopadloscian(int dlugosc, int szerokosc, int wysokosc)
	{
		Dlugosc = dlugosc;
		Szerokosc = szerokosc;
		Wysokosc = wysokosc;
	}

	public double Objetosc() => Dlugosc * Szerokosc * Wysokosc;

	public static int PorownajObjetosci(Prostopadloscian p1, Prostopadloscian p2) => p1.Objetosc() > p2.Objetosc() ? 1 : p1.Objetosc() < p2.Objetosc() ? -1 : 0;
}