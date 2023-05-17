// Rozdział 3

using Rozdzial3;

try
{
	Console.Write("Podaj numer zadania 1 - 15: ");
	if (!int.TryParse(Console.ReadLine(), out int numer))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	switch (numer)
	{
		case 1:
			/*
			Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100 (za wyjątkiem lat podzielnych przez 400).
			*/
			Zadanie_3_1();
			break;
		case 2:
			/*
			Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej.
			*/
			Zadanie_3_2();
			break;
		case 3:
			/*
			Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość największej z nich.
			*/
			Zadanie_3_3();
			break;
		case 4:
			/*
			Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch zmiennych typu double oraz znak operacji (+ lub – lub * lub /), a następnie wyświetla wynik operacji dla podanych wartości.
			Przykładowo użytkownik wprowadził znak „+” i liczby 1,5 oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0.
			*/
			Zadanie_3_4();
			break;
		case 5:
			/*
			Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma prosić użytkownika o podanie współczynników równania, a następnie ma wyświetlić stosowny komunikat.
			*/
			Zadanie_3_5();
			break;
		case 6:
			/*
			Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić użytkownika o podanie wagi w kg oraz wzrostu w metrach. Wzór: BMI = masa / (wzrost * wzrost) (treść zadania 2.3).
			a) Po obliczeniu wskaźnika BMI program powinien wyświetlać stosowną informację w zależności od wartości wskaźnika:
			- < 18,5 – niedowaga,
			- 18,5–24,99 – wartość prawidłowa,
			- ≥ 25,0 – nadwaga.
			b) Korzystając z Wikipedii rozszerz program, tak aby wyświetlał komentarz według poszerzonej klasyfikacji zakresów wskaźnika BMI.
			*/
			Zadanie_3_6();
			break;
		case 7:
			/*
			Wykonaj program z przykładu 3.8 (str. 63) z użyciem instrukcji switch..case (zamiast if..else).
			*/
			Zadanie_3_7();
			break;
		case 8:
			/*
			Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o wysokości przysługującego stypendium zgodnie z poniższą tabelą:
			Średnia ocen	Kwota stypendium
			Od		Do
			2,00	3,99	0,00 zł
			4,00	4,79	350,00 zł
			4,80	5,00	550,00 zł
			*/
			Zadanie_3_8();
			break;
		case 9:
			/*
			Napisz program w czterech wariantach (a, b, c i d), którego efektem działania będzie „figura” utworzona ze znaku gwiazdki (*) przedstawiona na danym rysunku.
			(Liczbę wyświetlanych wierszy podaje użytkownik).
			*/
			Zadanie_3_9();
			break;
		case 10:
			/*
			Napisz program obliczający n! (n silnia), gdzie n jest podane przez użytkownika.
			*/
			Zadanie_3_10();
			break;
		case 11:
			/*
			Napisz program obliczający ile kolejnych liczb całkowitych (rozpoczynając od wartości 1) należy dodać do siebie, aby suma przekroczyła wartość 100.
			*/
			Zadanie_3_11();
			break;
		case 12:
			/*
			Napisz program pobierający od użytkownika liczby całkowite. Program ma pobierać te liczby do czasu, gdy użytkownik wprowadzi wartość 0 (zero).
			Wynikiem działania programu ma być informacja o sumie wprowadzonych przez użytkownika liczb.
			*/
			Zadanie_3_12();
			break;
		case 13:
			/*
			Napisz program obliczający sumę szeregu W(n)=1 – 2 + 3 – 4 + ...± n, gdzie n jest dowolną liczbą naturalną, którą program ma wczytać.
			*/
			Zadanie_3_13();
			break;
		case 14:
			/*
			Liczba N jest doskonała, gdy jest równa sumie swych podzielników mniejszych od niej samej np. 6=1+2+3=6 – jest liczbą doskonałą.
			Napisz program znajdujący liczby doskonałe w przedziale <1,n>, gdzie n podaje użytkownik.
			*/
			Zadanie_3_14();
			break;
		case 15:
			/*
			Dysponując monetami 1 zł, 2 zł, 5 zł sprawdź, na ile różnych sposobów można wypłacić 10 zł. Napisz program, który wyświetli w oknie konsoli wszystkie możliwe kombinacje.
			*/
			Zadanie_3_15();
			break;
		default:
			throw new ArgumentException("Liczba musi być z przedziału 1 - 15 !");
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
Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100 (za wyjątkiem lat podzielnych przez 400).
*/
static void Zadanie_3_1()
{
	Console.WriteLine("Zadanie 3.1");
	Console.Write("Podaj rok: ");
	if (!int.TryParse(Console.ReadLine(), out int rok))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	string odpowiedz = (rok % 4 == 0) && ((rok % 400 == 0) || (rok % 100 != 0)) ? "Rok przestępny" : "Rok nieprzestępny";
	Console.WriteLine(odpowiedz);
}

/*
Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej.
*/
static void Zadanie_3_2()
{
	Console.WriteLine("Zadanie 3.2");
	Console.Write("Podaj 2 liczby całkowite: ");
	string[] wspolczynniki = Console.ReadLine().Split(' ', ',');
	bool isA = (int.TryParse(wspolczynniki[0], out int a));
	bool isB = (int.TryParse(wspolczynniki[1], out int b));
	if (!(isA && isB))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	string odpowiedz = (a % b == 0) ? $"Liczba {b} jest dzielnikiem liczby {a}" : $"Liczba {b} jest nie dzielnikiem liczby {a}";
	Console.WriteLine(odpowiedz);
}

/*
Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość największej z nich.
*/
static void Zadanie_3_3()
{
	Console.WriteLine("Zadanie 3.3");
	Console.Write("Podaj 3 liczby: ");
	string[] wspolczynniki = Console.ReadLine().Split(' ');
	bool isA = (double.TryParse(wspolczynniki[0], out double a));
	bool isB = (double.TryParse(wspolczynniki[1], out double b));
	bool isC = (double.TryParse(wspolczynniki[2], out double c));
	if (!(isA && isB && isC))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	double max = a;
	for (int i = 1; i < 3; i++)
	{
		max = double.Parse(wspolczynniki[i]) > max ? double.Parse(wspolczynniki[i]) : max;
	}

	Console.WriteLine($"Max liczba = {max}");

	//Console.WriteLine("Zadanie 3.3");
	//Console.Write("Podaj 3 liczby: ");
	//int[] wspolczynniki = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
	//Console.WriteLine($"Max liczba = {wspolczynniki.Max()}");
}

/*
Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch zmiennych typu double oraz znak operacji (+ lub – lub * lub /), a następnie wyświetla wynik operacji dla podanych wartości.
Przykładowo użytkownik wprowadził znak „+” i liczby 1,5 oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0.
*/
static void Zadanie_3_4()
{
	Console.WriteLine("Zadanie 3.4");
	Console.Write("Podaj 2 liczby oraz znak operacji: ");
	string[] wspolczynniki = Console.ReadLine().Split(' ');
	bool isA = (double.TryParse(wspolczynniki[0], out double a));
	bool isB = (double.TryParse(wspolczynniki[1], out double b));
	if (!(isA && isB))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	double wynik = 0;
	if (wspolczynniki[2] == "+")
	{
		wynik = a + b;
	}
	else if (wspolczynniki[2] == "-")
	{
		wynik = a - b;
	}
	else if (wspolczynniki[2] == "*")
	{
		wynik = a * b;
	}
	else if (wspolczynniki[2] == "/")
	{
		wynik = a / b;
	}

	Console.WriteLine($"{a} {wspolczynniki[2]} {b} = {wynik}");
}

/*
Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma prosić użytkownika o podanie współczynników równania, a następnie ma wyświetlić stosowny komunikat.
*/
static void Zadanie_3_5()
{
	Console.WriteLine("Zadanie 3.5");
	Console.Write("Podaj 3 liczby - współczynniki równania kwadratowego: ");
	string[] wspolczynniki = Console.ReadLine().Split(' ');
	bool isA = (double.TryParse(wspolczynniki[0], out double a));
	bool isB = (double.TryParse(wspolczynniki[1], out double b));
	bool isC = (double.TryParse(wspolczynniki[2], out double c));
	if (!(isA && isB && isC))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	if (a == 0)
	{
		throw new ArgumentException("Parametr a nie może być zerem!");
	}

	double delta = b * b - 4 * a * c;
	string odpowiedz;
	if (delta > 0)
	{
		double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
		double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
		odpowiedz = $"Równanie ma 2 pierwiastki: x1 = {x1} , x2 = {x2}";
	}
	else if (delta == 0)
	{
		double x0 = (-b) / (2 * a);
		odpowiedz = $"Równanie ma 1 pierwiastek: x0 = {x0}";
	}
	else
	{
		odpowiedz = $"Równanie nie ma pierwiastków";
	}

	Console.WriteLine(odpowiedz);
}

/*
Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić użytkownika o podanie wagi w kg oraz wzrostu w metrach. Wzór: BMI = masa / (wzrost * wzrost) (treść zadania 2.3).
a) Po obliczeniu wskaźnika BMI program powinien wyświetlać stosowną informację w zależności od wartości wskaźnika:
- < 18,5 – niedowaga,
- 18,5–24,99 – wartość prawidłowa,
- ≥ 25,0 – nadwaga.
b) Korzystając z Wikipedii rozszerz program, tak aby wyświetlał komentarz według poszerzonej klasyfikacji zakresów wskaźnika BMI.
*/
static void Zadanie_3_6()
{
	Console.WriteLine("Zadanie 3.6");
	Console.Write("Podaj wage w kilogramach i wzrost w metrach: ");
	string[] wspolczynniki = Console.ReadLine().Split(' ');
	bool isA = (double.TryParse(wspolczynniki[0], out double a));
	bool isB = (double.TryParse(wspolczynniki[1], out double b));
	if (!(isA && isB))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	double BMI = a / (b * b);
	string wskaznik = BMI < 18.5 ? "niedowaga" : BMI < 25 ? "wartość prawidłowa" : "nadwaga";
	Console.WriteLine($"BMI = {BMI} - {wskaznik}");
}

/*
Wykonaj program z przykładu 3.8 (str. 63) z użyciem instrukcji switch..case (zamiast if..else).
*/
static void Zadanie_3_7()
{
	Console.WriteLine("Zadanie 3.7");
	Console.WriteLine("Wpisz nr dnia tygodnia");
	DniTygodnia numer = (DniTygodnia)int.Parse(Console.ReadLine());

	switch (numer)
	{
		case DniTygodnia.poniedzialek:
			Console.WriteLine("Poniedziałek");
			break;
		case DniTygodnia.wtorek:
			Console.WriteLine("Wtorek");
			break;
		case DniTygodnia.sroda:
			Console.WriteLine("Środa");
			break;
		case DniTygodnia.czwartek:
			Console.WriteLine("Czwartek");
			break;
		case DniTygodnia.piatek:
			Console.WriteLine("Piątek");
			break;
		case DniTygodnia.sobota:
			Console.WriteLine("Sobota");
			break;
		case DniTygodnia.niedziela:
			Console.WriteLine("Niedziela");
			break;
		default:
			Console.WriteLine("Nie ma takiego dnia tygodnia");
			break;
	}
	Console.ReadKey();
}

/*
Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o wysokości przysługującego stypendium zgodnie z poniższą tabelą:
Średnia ocen	Kwota stypendium
Od		Do
2,00	3,99	0,00 zł
4,00	4,79	350,00 zł
4,80	5,00	550,00 zł
*/
static void Zadanie_3_8()
{
	Console.WriteLine("Zadanie 3.8");
	Console.Write("Podaj swoją średnią ocen: ");
	if (!double.TryParse(Console.ReadLine(), out double srednia))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	int stypendium = srednia is >= 2 and < 4 ? 0 : srednia < 4.8 ? 350 : 550;
	Console.WriteLine($"Dla średniej {srednia} przysługuje stypendium w wysokości: {stypendium} zł");
}

/*
Napisz program w czterech wariantach (a, b, c i d), którego efektem działania będzie „figura” utworzona ze znaku gwiazdki (*) przedstawiona na danym rysunku.
(Liczbę wyświetlanych wierszy podaje użytkownik).
*/
static void Zadanie_3_9()
{
	Console.WriteLine("Zadanie 3.9");
	Console.Write("Podaj liczbę wierszy dla wyświetlanego kwadratu: ");
	if (!int.TryParse(Console.ReadLine(), out int N))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	Console.WriteLine("\na)");
	for (int i = 1; i <= N; i++)
	{
		for (int j = 1; j <= i; j++)
		{
			Console.Write("*");
		}

		Console.WriteLine();
	}

	Console.WriteLine("\nb)");
	for (int i = 1; i <= N; i++)
	{
		for (int j = N; j >= i; j--)
		{
			Console.Write("*");
		}

		Console.WriteLine();
	}

	Console.WriteLine("\nc)");
	for (int i = 1; i <= N; i++)
	{
		for (int k = N - i; k > 0; k--)
		{
			Console.Write(" ");
		}
		for (int j = 1; j <= i; j++)
		{
			Console.Write("*");
		}

		Console.WriteLine();
	}

	Console.WriteLine("\nd)");
	for (int i = 1; i <= N; i++)
	{
		for (int j = 1; j <= N; j++)
		{
			if (i != 1 && i != N)
			{
				if (j == 1 || j == N)
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(" ");
				}
			}
			else
			{
				Console.Write("*");
			}
		}

		Console.WriteLine();
	}
}

/*
Napisz program obliczający n! (n silnia), gdzie n jest podane przez użytkownika.
*/
static void Zadanie_3_10()
{
	Console.WriteLine("Zadanie 3.10");
	Console.Write("Podaj silnie którą chcesz obliczyć: ");
	if (!int.TryParse(Console.ReadLine(), out int N))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	Console.WriteLine(silnia(N));

	int silnia(int liczba) => liczba == 1 ? 1 : liczba * silnia(liczba - 1);
}

/*
Napisz program obliczający ile kolejnych liczb całkowitych (rozpoczynając od wartości 1) należy dodać do siebie, aby suma przekroczyła wartość 100.
*/
static void Zadanie_3_11()
{
	Console.WriteLine("Zadanie 3.11");
	int suma = 0;
	int ileKolejnych = 0;
	int nastepna = 1;
	while (suma < 100)
	{
		suma += nastepna;
		nastepna++;
		ileKolejnych++;
	}
	Console.WriteLine($"Suma przekracza wartość 100 po {ileKolejnych} kolejno dodanych liczbach");
}

/*
Napisz program pobierający od użytkownika liczby całkowite. Program ma pobierać te liczby do czasu, gdy użytkownik wprowadzi wartość 0 (zero).
Wynikiem działania programu ma być informacja o sumie wprowadzonych przez użytkownika liczb.
*/
static void Zadanie_3_12()
{
	Console.WriteLine("Zadanie 3.12");
	int suma = 0;
	int liczba;
	do
	{
		Console.Write("Podaj liczbę: ");
		if (!int.TryParse(Console.ReadLine(), out liczba))
		{
			throw new ArgumentException("Nie wpisałeś liczby!");
		}

		suma += liczba;
	} while (liczba != 0);
	Console.WriteLine($"Suma podanych liczb: {suma}");
}

/*
Napisz program obliczający sumę szeregu W(n)=1 – 2 + 3 – 4 + ...± n, gdzie n jest dowolną liczbą naturalną, którą program ma wczytać.
*/
static void Zadanie_3_13()
{
	Console.WriteLine("Zadanie 3.13");
	Console.Write("Podaj liczbę kończącą szereg: ");
	if (!int.TryParse(Console.ReadLine(), out int liczba))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	int wynik = 0;
	for (int i = 1; i <= liczba; i++)
	{
		if (i % 2 != 0)
		{
			wynik += i;
		}
		else
		{
			wynik -= i;
		}
	}
	Console.WriteLine($"Wynik = {wynik}");
}

/*
Liczba N jest doskonała, gdy jest równa sumie swych podzielników mniejszych od niej samej np. 6=1+2+3=6 – jest liczbą doskonałą.
Napisz program znajdujący liczby doskonałe w przedziale <1,n>, gdzie n podaje użytkownik.
*/
static void Zadanie_3_14()
{
	Console.WriteLine("Zadanie 3.14");
	Console.Write("Podaj liczbę kończącą przedział: ");
	if (!int.TryParse(Console.ReadLine(), out int N))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	string odpowiedz = "";
	for (int i = 1; i <= N; i++)
	{
		if (CzyDoskonala(i))
		{
			odpowiedz += $"{i} ";
		}
	}
	Console.WriteLine($"Liczby doskonałe w przedziale <1,{N}> : {odpowiedz}");

	bool CzyDoskonala(int liczba)
	{
		int suma = 0;
		for (int i = 1; i < liczba; i++)
		{
			if (liczba % i == 0)
			{
				suma += i;
			}
		}

		return (suma == liczba);
	}
}

/*
Dysponując monetami 1 zł, 2 zł, 5 zł sprawdź, na ile różnych sposobów można wypłacić 10 zł. Napisz program, który wyświetli w oknie konsoli wszystkie możliwe kombinacje.
*/
static void Zadanie_3_15()
{
	Console.WriteLine("Zadanie 3.15");
	int ilosc = 0;
	for (int z1 = 0; z1 <= 10; z1++)
	{
		for (int z2 = 0; z2 <= 5; z2++)
		{
			for (int z5 = 0; z5 <= 2; z5++)
			{
				if (z1 * 1 + z2 * 2 + z5 * 5 == 10)
				{
					Console.WriteLine("1zł = {0}   2zł = {1}   5zł = {2}", z1, z2, z5);
					ilosc++;
				}
			}
		}
	}

	Console.WriteLine($"Jest {ilosc} sposobów na wypłacenie 10 zł");
}