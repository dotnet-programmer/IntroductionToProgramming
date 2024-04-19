// Chapter 5

using System.Diagnostics;

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
			Napisz program zawierający metodę statyczną obliczającą temperaturę w stopniach Fahrenheita na temperaturę w stopniach Celsjusza.
			Metoda ma przyjmować jeden argument (temperaturę w stopniach Fahrenheita) i zwracać temperaturę w stopniach Celsjusza.
			*/
			Exercise_5_1();
			break;
		case 2:
			/*
			Napisz program wczytujący 3 liczby rzeczywiste a, b, x, a następnie wywołujący metodę, która sprawdza, czy liczba x należy do przedziału obustronnie otwartego (a, b).
			Metoda sprawdzająca ma zwrócić wartość logiczną, którą należy zinterpretować w metodzie Main() z podaniem stosownego komunikatu.
			*/
			Exercise_5_2();
			break;
		case 3:
			/*
			Napisz program, który ma znaleźć współrzędne punktu po przesunięciu o dany wektor. W metodzie Main() wczytaj od użytkownika współrzędne punktu A oraz zadeklaruj współrzędne wektora wek [3, 2],
			a następnie wywołaj metodę o nazwie Przesun(), która ma przesunąć punkt A o wektor wek (dodać odpowiednie współrzędne). Współrzędne punktu (jako dwie zmienne typu double)
			mają zostać przesłane do tej metody przez referencję, a współrzędne wektora (także jako dwie zmienne typu double) przez wartość. Metoda Przesun() ma nic nie zwracać (void),
			aktualne współrzędne punktu mają być pamiętane dzięki użyciu argumentów przesyłanych przez referencje. Program ma wyświetlić współrzędne punktu po przesunięciu o wektor wek.
			Przykładowo, gdyby użytkownik podał początkowe współrzędne punktu A (2, 1), to wówczas program znajdzie położenie punktu A po przesunięciu w miejscu o współrzędnych (5, 3) (czyli 2+3, 1+2).
			*/
			Exercise_5_3();
			break;
		case 4:
			/*
			Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę. Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu int oraz liczbę całkowitą (mnożnik).
			Wykonaj Exercise w dwóch wariantach:
			a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona przez metodę.
			b) Wyniki mnożenia elementów tablicy mają zostać umieszczone w tablicy będącej argumentem metody (w tym wariancie metoda ma niczego nie zwracać).
			Przykładowo dla tablicy o elementach {1,4,6,8,2} oraz mnożniku 2 program powinien wyświetlić tablicę {2,8,12,16,4}.
			*/
			Exercise_5_4();
			break;
		case 5:
			/*
			Napisz program, który wypisze na ekranie znaki w kształcie prostokąta. Program ma prosić użytkownika o podanie rozmiaru prostokąta: długość i szerokość, a następnie znak, którym ma być zapełniony prostokąt.
			Napisz metodę Rysuj(), która wypisze na konsoli prostokąt, przesyłając jako argument długość, szerokość oraz znak wypełnienia.
			Wywołaj metodę dwa razy, za drugim razem podaj na odwrót argumenty dla długości i szerokości. W wyniku działania programu powinny zostać wyświetlone dwa prostokąty, jeden „leżący” oraz drugi „stojący”.
			Przykładowy przebieg działania programu na rysunku:
			Podaj dlugość: 6
			Podaj szerokość: 3
			Podaj znak: *

			******
			******
			******

			***
			***
			***
			***
			***
			***
			*/
			Exercise_5_5();
			break;
		case 6:
			/*
			Uzupełnij program z zadania 5.4 (dowolny wariant) o metodę przeładowaną przyjmującą tablicę typu string oraz mnożnik typu int.
			W tym przypadku metoda ma powielać łańcuch znaków (konkatenować tyle razy, ile wynika z mnożnika). Przykładowo dla tablicy o elementach {"ala", "kot", "dom"}
			oraz mnożniku 2 program powinien wyświetlić tablicę {"alaala", "kotkot", "domdom"}.
			*/
			Exercise_5_6();
			break;
		case 7:
			/*
			Napisz statyczną metodę, która oblicza wyrażenie: W = (x+1) + (x+2) + (x+3) +.......+ (x+n). W metodzie Main() wywołaj funkcję dla x i n (liczb naturalnych) wczytanych z klawiatury.
			*/
			Exercise_5_7();
			break;
		case 8:
			/*
			Napisz metodę, która oblicza sumę cyfr liczby naturalnej x. W programie głównym wywołaj funkcję dla x wczytanego z klawiatury.
			Przykładowo jeśli użytkownik wpisze 125, to metoda powinna zwrócić wartość 8 (1+2+5=8).
			*/
			Exercise_5_8();
			break;
		case 9:
			/*
			Wykonaj program znajdujący n-ty wyraz ciągu Fibonacciego według wzoru Wykonaj program w dwóch wariantach:
			w jednym metoda znajdująca wyraz ciągu ma być rekurencyjna,
			a w drugim ma wykorzystać iteracyjne podejście (z użyciem pętli).
			*/
			Exercise_5_9();
			break;
		case 10:
			/*
			Jaki będzie rezultat metody Oblicz() wywołanej z parametrem n = 5? Zadanie wykonaj najpierw bez udziału kompilatora, a dopiero później uruchom program i sprawdź otrzymany wynik.
			static int Oblicz(int n)
			{
				if (n <= 1) return (1);
				else return (n + Oblicz(n - 1));
			}
			*/
			Exercise_5_10();
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
Napisz program zawierający metodę statyczną obliczającą temperaturę w stopniach Fahrenheita na temperaturę w stopniach Celsjusza.
Metoda ma przyjmować jeden argument (temperaturę w stopniach Fahrenheita) i zwracać temperaturę w stopniach Celsjusza.
*/
static void Exercise_5_1()
{
	Console.WriteLine("Zadanie 5.1");
	Console.Write("Podaj temp w *F: ");
	if (double.TryParse(Console.ReadLine(), out double temp))
	{
		Console.WriteLine(ConvertFahrenheitToCelsius(temp));
	}
	else
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}
}

static double ConvertFahrenheitToCelsius(double temp)
	=> 5.0 / 9.0 * (temp - 32);

/*
Napisz program wczytujący 3 liczby rzeczywiste a, b, x, a następnie wywołujący metodę, która sprawdza, czy liczba x należy do przedziału obustronnie otwartego (a, b).
Metoda sprawdzająca ma zwrócić wartość logiczną, którą należy zinterpretować w metodzie Main() z podaniem stosownego komunikatu.
*/
static void Exercise_5_2()
{
	Console.WriteLine("Zadanie 5.2");
	Console.Write("Podaj 3 liczby rzeczywiste a, b oraz c: ");
	string[] coefficients = Console.ReadLine().Split(' ');
	bool isA = (double.TryParse(coefficients[0], out double a));
	bool isB = (double.TryParse(coefficients[1], out double b));
	bool isC = (double.TryParse(coefficients[2], out double c));
	if (!(isA && isB && isC))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	string result = IsItBelongs(a, b, c) ? "należy" : "nie należy";
	Console.WriteLine($"Liczba {c} {result} do przedziału ({a},{b})");
}
static bool IsItBelongs(double a, double b, double x)
	=> x > a && x < b;

/*
Napisz program, który ma znaleźć współrzędne punktu po przesunięciu o dany wektor. W metodzie Main() wczytaj od użytkownika współrzędne punktu A oraz zadeklaruj współrzędne wektora wek [3, 2],
a następnie wywołaj metodę o nazwie Przesun(), która ma przesunąć punkt A o wektor wek (dodać odpowiednie współrzędne). Współrzędne punktu (jako dwie zmienne typu double)
mają zostać przesłane do tej metody przez referencję, a współrzędne wektora (także jako dwie zmienne typu double) przez wartość. Metoda Przesun() ma nic nie zwracać (void),
aktualne współrzędne punktu mają być pamiętane dzięki użyciu argumentów przesyłanych przez referencje. Program ma wyświetlić współrzędne punktu po przesunięciu o wektor wek.
Przykładowo, gdyby użytkownik podał początkowe współrzędne punktu A (2, 1), to wówczas program znajdzie położenie punktu A po przesunięciu w miejscu o współrzędnych (5, 3) (czyli 2+3, 1+2).
*/
static void Exercise_5_3()
{
	Console.WriteLine("Zadanie 5.3");
	Console.Write("Podaj współrzędne punktu A: ");
	string[] coefficients = Console.ReadLine().Split(' ');
	bool isAx = (double.TryParse(coefficients[0], out double Ax));
	bool isAy = (double.TryParse(coefficients[1], out double Ay));
	if (!(isAx && isAy))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	int Wx = 3, Wy = 2;
	Move(ref Ax, ref Ay, Wx, Wy);
	Console.WriteLine($"Nowe położenie punktu: ({Ax},{Ay})");
}
static void Move(ref double ax, ref double ay, int wx, int wy)
{
	ax += wx;
	ay += wy;
}

/*
Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę. Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu int oraz liczbę całkowitą (mnożnik).
Wykonaj Exercise w dwóch wariantach:
a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona przez metodę.
b) Wyniki mnożenia elementów tablicy mają zostać umieszczone w tablicy będącej argumentem metody (w tym wariancie metoda ma niczego nie zwracać).
Przykładowo dla tablicy o elementach {1,4,6,8,2} oraz mnożniku 2 program powinien wyświetlić tablicę {2,8,12,16,4}.
*/
static void Exercise_5_4()
{
	Console.WriteLine("Zadanie 5.4");
	int[] numbers = [1, 4, 6, 8, 2];
	int multiplier = 2;
	foreach (var item in numbers)
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine();
	foreach (var item in MultiplyElements1(numbers, multiplier))
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine();
	MultiplyElements2(numbers, multiplier);
	foreach (var item in numbers)
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine();
}
static int[] MultiplyElements1(int[] tab, int x)
	=> tab.Select(t => t * x).ToArray();

static void MultiplyElements2(int[] tab, int x)
{
	for (int i = 0; i < tab.Length; i++)
	{
		tab[i] *= x;
	}
}

/*
Napisz program, który wypisze na ekranie znaki w kształcie prostokąta. Program ma prosić użytkownika o podanie rozmiaru prostokąta: długość i szerokość, a następnie znak, którym ma być zapełniony prostokąt.
Napisz metodę Rysuj(), która wypisze na konsoli prostokąt, przesyłając jako argument długość, szerokość oraz znak wypełnienia.
Wywołaj metodę dwa razy, za drugim razem podaj na odwrót argumenty dla długości i szerokości. W wyniku działania programu powinny zostać wyświetlone dwa prostokąty, jeden „leżący” oraz drugi „stojący”.
Przykładowy przebieg działania programu na rysunku:
Podaj dlugość: 6
Podaj szerokość: 3
Podaj znak: *

******
******
******

***
***
***
***
***
***
*/
static void Exercise_5_5()
{
	Console.WriteLine("Zadanie 5.5");
	Console.Write("Podaj długość, szerokość i znak do rysowania: ");
	string[] coefficients = Console.ReadLine().Split(' ');
	bool isX = (int.TryParse(coefficients[0], out int x));
	bool isY = (int.TryParse(coefficients[1], out int y));
	if (!(isX && isY))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	string sign = coefficients[2];
	Draw(x, y, sign);
	Console.WriteLine();
	Draw(y, x, sign);
	Console.WriteLine();
}
static void Draw(int x, int y, string sign)
{
	for (int i = 0; i < y; i++)
	{
		for (int j = 0; j < x; j++)
		{
			Console.Write(sign);
		}
		Console.WriteLine();
	}
}

/*
Uzupełnij program z zadania 5.4 (dowolny wariant) o metodę przeładowaną przyjmującą tablicę typu string oraz mnożnik typu int.
W tym przypadku metoda ma powielać łańcuch znaków (konkatenować tyle razy, ile wynika z mnożnika). Przykładowo dla tablicy o elementach {"ala", "kot", "dom"}
oraz mnożniku 2 program powinien wyświetlić tablicę {"alaala", "kotkot", "domdom"}.
*/
static void Exercise_5_6()
{
	Console.WriteLine("Zadanie 5.6");
	int[] numbers = [1, 4, 6, 8, 2];
	string[] words = ["ala", "kot", "dom"];
	int multiplier = 2;
	foreach (var item in numbers)
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine();
	foreach (var item in MultiplyElements1(numbers, multiplier))
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine();
	MultiplyElements2(numbers, multiplier);
	foreach (var item in numbers)
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine();

	foreach (var item in words)
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine();
	foreach (var item in MultiplyElements3(words, multiplier))
	{
		Console.Write(item + " ");
	}

	Console.WriteLine();
	MultiplyElements4(words, multiplier);
	foreach (var item in words)
	{
		Console.Write($"{item} ");
	}

	Console.WriteLine();
}
static string[] MultiplyElements3(string[] tab, int x)
	=> tab.Select(t =>
		{
			for (int i = 1; i < x; i++)
			{
				t += t;
			}

			return t;
		}).ToArray();
static void MultiplyElements4(string[] tab, int x)
{
	for (int i = 0; i < tab.Length; i++)
	{
		for (int j = 1; j < x; j++)
		{
			tab[i] += tab[i];
		}
	}
}

/*
Napisz statyczną metodę, która oblicza wyrażenie: W = (x+1) + (x+2) + (x+3) +.......+ (x+n). W metodzie Main() wywołaj funkcję dla x i n (liczb naturalnych) wczytanych z klawiatury.
*/
static void Exercise_5_7()
{
	Console.WriteLine("Zadanie 5.7");
	Console.Write("Podaj 2 liczby calkowite: ");
	string[] coefficients = Console.ReadLine().Split(' ');
	bool isX = (int.TryParse(coefficients[0], out int x));
	bool isY = (int.TryParse(coefficients[1], out int y));
	if (!(isX && isY))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	Console.WriteLine($"Wyrażenie = {Expression(x, y)}"); // rekurencja
	Console.WriteLine($"Wyrażenie 2 = {Expression2(x, y)}"); // iteracja
}
static int Expression(int x, int n)
	=> n == 1 ? x + n : (x + n) + Expression(x, --n);

static int Expression2(int x, int n)
{
	int sum = 0;
	for (int i = 1; i <= n; i++)
	{
		sum += (x + i);
	}
	return sum;
}

/*
Napisz metodę, która oblicza sumę cyfr liczby naturalnej x. W programie głównym wywołaj funkcję dla x wczytanego z klawiatury.
Przykładowo jeśli użytkownik wpisze 125, to metoda powinna zwrócić wartość 8 (1+2+5=8).
*/
static void Exercise_5_8()
{
	Console.WriteLine("Zadanie 5.8");
	Console.Write("Podaj liczbę całkowitą: ");
	bool isX = (int.TryParse(Console.ReadLine(), out int x));
	if (!(isX))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	Console.WriteLine($"Suma cyfr liczy naturalnej = {SumOfNumbers(x)}");
}
static int SumOfNumbers(int x)
{
	int sum = 0;
	do
	{
		sum += x % 10;
		x /= 10;
	} while (x > 0);
	return sum;
}

/*
Wykonaj program znajdujący n-ty wyraz ciągu Fibonacciego według wzoru Wykonaj program w dwóch wariantach:
w jednym metoda znajdująca wyraz ciągu ma być rekurencyjna,
a w drugim ma wykorzystać iteracyjne podejście (z użyciem pętli).
*/
static void Exercise_5_9()
{
	Console.WriteLine("Zadanie 5.9");
	Console.Write("Podaj liczbę całkowitą: ");
	bool isX = (int.TryParse(Console.ReadLine(), out int x));
	if (!(isX))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	long item = 0;
	Console.WriteLine($"{x}-ty wyraz ciągu Fibonacciego:");

	int steps = 0;
	var sw = Stopwatch.StartNew();
	item = FibonacciRecursion(x, ref steps);
	sw.Stop();
	Console.WriteLine($"Rekurencja: {item}, wykonano {steps} czynności w czasie {sw.Elapsed}");

	steps = 0;
	sw.Reset();
	sw.Start();
	item = FibonacciIteration(x, ref steps);
	sw.Stop();
	Console.WriteLine($"Iteracja: {item}, wykonano {steps} czynności w czasie {sw.Elapsed}");

	steps = 0;
	sw.Reset();
	sw.Start();
	item = FibonacciIterationList(x, ref steps);
	sw.Stop();
	Console.WriteLine($"It Lista: {item}, wykonano {steps} czynności w czasie {sw.Elapsed}");

	steps = 0;
	sw.Reset();
	sw.Start();
	item = FibonacciIterationArray(x, ref steps);
	sw.Stop();
	Console.WriteLine($"It Tablica: {item}, wykonano {steps} czynności w czasie {sw.Elapsed}");
}
static long FibonacciRecursion(int n, ref int counter)
{
	counter++;
	return n <= 1
		? n
		: FibonacciRecursion(n - 2, ref counter) + FibonacciRecursion(n - 1, ref counter);
}
static long FibonacciIteration(int n, ref int counter)
{
	long n2 = 0;
	long n1 = 1;
	long result = 0;
	for (int i = 0; i < n; i++)
	{
		n2 = n1;
		n1 = result;
		result = n1 + n2;
		counter++;
	}
	return result;
}
static long FibonacciIterationList(int n, ref int counter)
{
	List<long> numbers = [0, 1];
	for (int i = 2; i <= n; i++)
	{
		numbers.Add(numbers[i - 2] + numbers[i - 1]);
		counter++;
	}
	return numbers[n];
}
static long FibonacciIterationArray(int n, ref int counter)
{
	long[] numbers = new long[n + 1];
	numbers[0] = 0;
	numbers[1] = 1;
	for (int i = 2; i <= n; i++)
	{
		numbers[i] = (numbers[i - 2] + numbers[i - 1]);
		counter++;
	}
	return numbers[n];
}

/*
Jaki będzie rezultat metody Oblicz() wywołanej z parametrem n = 5? Zadanie wykonaj najpierw bez udziału kompilatora, a dopiero później uruchom program i sprawdź otrzymany wynik.
static int Oblicz(int n)
{
	if (n <= 1) return (1);
	else return (n + Oblicz(n - 1));
}
*/
static void Exercise_5_10()
{
	Console.WriteLine("Zadanie 5.10");
	Console.WriteLine(Calculate(5));
}
static int Calculate(int n)
	=> n <= 1
	? 1
	: n + Calculate(n - 1);