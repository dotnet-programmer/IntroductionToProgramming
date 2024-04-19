// Chapter 6

using Chapter6;

try
{
	Console.Write("Podaj numer zadania 1 - 10: ");
	int number;
	while ((!int.TryParse(Console.ReadLine(), out number)) || (number < 1 || number > 10))
	{
		Console.WriteLine("Nie wpisałeś liczby lub liczba jest poza zakresem!");
		Console.Write("Podaj numer zadania 1 - 10: ");
	}

	switch (number)
	{
		case 1:
			/*
			Napisz program, który tworzy klasę Prostokat, zawierającą dwie prywatne dane składowe: dlugosc, szerokosc, dwie prywatne metody: powierzchnia(), obwod() oraz metodę publiczną – Prezentuj()
			(która wyświetla powierzchnię i obwód prostokąta) i konstruktor inicjalizujący. W metodzie Main() zdefiniuj obiekt i uruchom dla niego metodę Prezentuj().
			*/
			Exercise_6_1();
			break;
		case 2:
			/*
			Uzupełnij program z poprzedniego zadania o definicje tablicy obiektów dla prostokątów. W metodzie Main() wyświetl powierzchnie
			oraz obwód wszystkich prostokątów w tablicy używając (wewnątrz pętli foreach) metody publicznej Prezentuj().
			*/
			Exercise_6_2();
			break;
		case 3:
			/*
			Uzupełnij program z poprzedniego zadania o definicję metody statycznej, która podaje powierzchnię największego prostokąta.
			*/
			Exercise_6_3();
			break;
		case 4:
			/*
			Zdefiniuj klasę, która pozwoli na rejestrację zużycia energii elektrycznej. Klasa powinna pozwalać na:
			- rejestrację początkowego i bieżącego stanu licznika energii,
			- uzyskanie danych o początkowym oraz bieżącym stanie licznika,
			- obliczanie zużytej energii.
			*/
			Exercise_6_4();
			break;
		case 5:
			/*
			Napisz program tworzący klasę Punkt do obsługi punktów na płaszczyźnie. Klasa ta ma zawierać: konstruktor, którego argumentami będą współrzędne punktu, metodę składową Przesun(),
			realizującą przesunięcie o zadane wielkości oraz metodę składową Wyswietl() wypisującą aktualne współrzędne punktu. Współrzędne punktu mają być zdefiniowane poprzez właściwości.
			*/
			Exercise_6_5();
			break;
		case 6:
			/*
			Napisz program (używając klasy Punkt zdefiniowanej w poprzednim zadaniu), który przechowuje dane o trzech punktach w tablicy obiektów i sprawdza przy pomocy statycznej metody, czy leżą one na jednej prostej.
			*/
			Exercise_6_6();
			break;
		case 7:
			/*
			Zdefiniuj klasę Odcinek składającą się z dwóch punktów klasy Punkt. W klasie Odcinek zdefiniuj metodę, która obliczy długość odcinka.
			*/
			Exercise_6_7();
			break;
		case 8:
			/*
			Zdefiniuj klasę Prostopadloscian, która pozwoli na reprezentację danych opisujących długość, szerokość i wysokość prostopadłościanu.
			W klasie zaimplementuj metody pozwalające na obliczenie objętości prostopadłościanu, oraz porównanie objętości dwóch prostopadłościanów.
			*/
			Exercise_6_8();
			break;
		case 9:
			/*
			Wykonaj zadania 6.1 oraz 6.2 z użyciem struktury (zamiast klasy).
			*/
			Exercise_6_9();
			break;
		case 10:
			/*
			Napisz program z użyciem struktury KandydatNaStudia, która ma posiadać następujące pola: nazwisko, punktyMatematyka, punktyInformatyka, punktyJezykObcy.
			W trzech ostatnich polach mają być zapisane punkty za przedmioty zdawane na maturze (dla uproszczenia uwzględniamy tylko jeden poziom zdawanej matury, np. podstawowy).
			Jeden punkt to jeden procent (tj. student, który ma 55% z matematyki ma mieć 55 punktów z tego przedmiotu).
			Struktura ma posiadać metodę obliczającą łączną liczbę punktów kandydata według przelicznika: 0,6 punktów z matematyki + 0,5 punktów z informatyki + 0,2 punktów z języka obcego.
			W metodzie Main() utwórz obiekty dla struktury (jako elementy tablicy) dla kilku kandydatów i pokaż listę kandydatów, zawierającą nazwisko i obok, w tej samej linii, obliczoną łączną liczbę punktów.
			*/
			Exercise_6_10();
			break;
		default:
			throw new ArgumentException("Liczba musi być z przedziału 1 - 10 !");
	}
}
catch (ArgumentException ex)
{
	Console.WriteLine(ex.Message);
}
finally
{
	Console.WriteLine("Koniec programu");
	Console.ReadLine();
}

/*
Napisz program, który tworzy klasę Prostokat, zawierającą dwie prywatne dane składowe: dlugosc, szerokosc, dwie prywatne metody: powierzchnia(), obwod() oraz metodę publiczną – Prezentuj()
(która wyświetla powierzchnię i obwód prostokąta) i konstruktor inicjalizujący. W metodzie Main() zdefiniuj obiekt i uruchom dla niego metodę Prezentuj().
*/
static void Exercise_6_1()
{
	Console.WriteLine("Zadanie 6.1");
	var rectangle = new Rectangle(5, 10);
	rectangle.Display();
}

/*
Uzupełnij program z poprzedniego zadania o definicje tablicy obiektów dla prostokątów. W metodzie Main() wyświetl powierzchnie
oraz obwód wszystkich prostokątów w tablicy używając (wewnątrz pętli foreach) metody publicznej Prezentuj().
*/
static void Exercise_6_2()
{
	Console.WriteLine("Zadanie 6.2");
	Rectangle[] rectangles = [new(5, 10), new(3, 3), new(4, 8), new(1, 12), new(9, 6), new(1, 1)];
	foreach (var item in rectangles)
	{
		item.Display();
	}
}

/*
Uzupełnij program z poprzedniego zadania o definicję metody statycznej, która podaje powierzchnię największego prostokąta.
*/
static void Exercise_6_3()
{
	Console.WriteLine("Zadanie 6.3");
	Rectangle[] rectangles = [new(5, 10), new(3, 3), new(4, 8), new(1, 12), new(9, 6), new(1, 1)];
	foreach (var item in rectangles)
	{
		item.Display();
	}
	Rectangle.BiggestRectangle();
}

/*
Zdefiniuj klasę, która pozwoli na rejestrację zużycia energii elektrycznej. Klasa powinna pozwalać na:
- rejestrację początkowego i bieżącego stanu licznika energii,
- uzyskanie danych o początkowym oraz bieżącym stanie licznika,
- obliczanie zużytej energii.
*/
static void Exercise_6_4()
{
	Console.WriteLine("Zadanie 6.4");
	Electricity counter1 = new(100D);
	Electricity counter2 = new(200, 400);
	Console.WriteLine($"Stan poczatkowy licznika 1: {counter1.InitialState}");
	Console.WriteLine($"Stan poczatkowy licznika 2: {counter2.InitialState}");
	Console.WriteLine($"Stan bieżący licznika 1: {counter1.CurrentState}");
	Console.WriteLine($"Stan bieżący licznika 2: {counter2.CurrentState}");
	Console.WriteLine($"Zużycie licznika1 = {counter1.CalculateUsage()}");
	Console.WriteLine($"Zużycie licznika2 = {counter2.CalculateUsage()}");
}

/*
Napisz program tworzący klasę Punkt do obsługi punktów na płaszczyźnie. Klasa ta ma zawierać: konstruktor, którego argumentami będą współrzędne punktu, metodę składową Przesun(),
realizującą przesunięcie o zadane wielkości oraz metodę składową Wyswietl() wypisującą aktualne współrzędne punktu. Współrzędne punktu mają być zdefiniowane poprzez właściwości.
*/
static void Exercise_6_5()
{
	Console.WriteLine("Zadanie 6.5");
	MyPoint point1 = new(2, 2);
	MyPoint point2 = new(3, 3);
	point1.Display();
	point2.Display();
	point1.Move(5, 5);
	point2.Move(5, 5);
	point1.Display();
	point2.Display();
}

/*
Napisz program (używając klasy Punkt zdefiniowanej w poprzednim zadaniu), który przechowuje dane o trzech punktach w tablicy obiektów i sprawdza przy pomocy statycznej metody, czy leżą one na jednej prostej.
*/
static void Exercise_6_6()
{
	Console.WriteLine("Zadanie 6.6");
	MyPoint[] points1 = [new MyPoint(-5, -3), new MyPoint(0, -1), new MyPoint(10, 3)];
	string isCollinear = IsCollinear(points1[0], points1[1], points1[2]) ? "Współliniowe" : "Niewspółliniowe";
	Console.WriteLine(isCollinear);
	MyPoint[] points2 = [new MyPoint(-5, 2), new MyPoint(2, -1), new MyPoint(9, -5)];
	isCollinear = IsCollinear(points1[0], points1[1], points1[2]) ? "Współliniowe" : "Niewspółliniowe";
	Console.WriteLine(isCollinear);
}
static bool IsCollinear(MyPoint p1, MyPoint p2, MyPoint p3)
{
	double p1p2 = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
	double p1p3 = Math.Sqrt(Math.Pow(p3.X - p1.X, 2) + Math.Pow(p3.Y - p1.Y, 2));
	double p3p2 = Math.Sqrt(Math.Pow(p2.X - p3.X, 2) + Math.Pow(p2.Y - p3.Y, 2));
	Console.WriteLine(p1p2 + " " + Math.Abs(p1p3 - p3p2));
	return Math.Round(p1p2, 2) == Math.Round(Math.Abs(p1p3 - p3p2), 2);
}

/*
Zdefiniuj klasę Odcinek składającą się z dwóch punktów klasy Punkt. W klasie Odcinek zdefiniuj metodę, która obliczy długość odcinka.
*/
static void Exercise_6_7()
{
	Console.WriteLine("Zadanie 6.7");
	LineSegment lineSegment = new(new MyPoint(1, 1), new MyPoint(2, 2));
	Console.WriteLine(lineSegment.Length());
}

/*
Zdefiniuj klasę Prostopadloscian, która pozwoli na reprezentację danych opisujących długość, szerokość i wysokość prostopadłościanu.
W klasie zaimplementuj metody pozwalające na obliczenie objętości prostopadłościanu, oraz porównanie objętości dwóch prostopadłościanów.
*/
static void Exercise_6_8()
	=> Console.WriteLine("Zadanie 6.8");

/*
Wykonaj zadania 6.1 oraz 6.2 z użyciem struktury (zamiast klasy).
*/
static void Exercise_6_9()
	=> Console.WriteLine("Zadanie 6.9");

/*
Napisz program z użyciem struktury KandydatNaStudia, która ma posiadać następujące pola: nazwisko, punktyMatematyka, punktyInformatyka, punktyJezykObcy.
W trzech ostatnich polach mają być zapisane punkty za przedmioty zdawane na maturze (dla uproszczenia uwzględniamy tylko jeden poziom zdawanej matury, np. podstawowy).
Jeden punkt to jeden procent (tj. student, który ma 55% z matematyki ma mieć 55 punktów z tego przedmiotu).
Struktura ma posiadać metodę obliczającą łączną liczbę punktów kandydata według przelicznika: 0,6 punktów z matematyki + 0,5 punktów z informatyki + 0,2 punktów z języka obcego.
W metodzie Main() utwórz obiekty dla struktury (jako elementy tablicy) dla kilku kandydatów i pokaż listę kandydatów, zawierającą nazwisko i obok, w tej samej linii, obliczoną łączną liczbę punktów.
*/
static void Exercise_6_10()
{
	Console.WriteLine("Zadanie 6.10");
	StudyCandidate[] candidates = [new("Janek", 23, 25, 56), new("Franek", 63, 75, 86), new("Brajanek", 1, 2, 3)];
	foreach (var item in candidates)
	{
		Console.WriteLine($"{item.Name} - {item.TotalPoints()}");
	}
}