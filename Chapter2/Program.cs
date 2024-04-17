// Chapter 2

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
			// Napisz program przeliczający temperaturę w stopniach Celsjusza na temperaturę w stopniach Fahrenheita.
			// Program ma prosić użytkownika o podanie temperatury w stopniach Celsjusza.
			// Wzór: F = 32 + 9/5 * C
			Exercise_2_1();
			break;
		case 2:
			// Napisz program, który oblicza deltę dla równania kwadratowego ax2 + bx + c = 0.
			// Program ma prosić użytkownika o podanie współczynników równania a, b oraz c.
			// Wzór: delta = b * b - 4ac
			Exercise_2_2();
			break;
		case 3:
			// Napisz program, który oblicza wskaźnik masy ciała BMI.
			// Program ma prosić użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach.
			// Wzór: BMI = masa / (wzrost * wzrost)
			Exercise_2_3();
			break;
		case 4:
			// Po wykonaniu programu: int x = 100; Console.WriteLine(++x * 2);
			// a) wyświetli się liczba 202 b) wyświetli się liczba 200 c) będzie błąd d) wyświetli się liczba 201.
			// Najpierw oblicz wyświetlaną wartość i wybierz jedną z odpowiedzi (a, b, c, d), a dopiero później sprawdź wynik uruchamiając program.
			Exercise_2_4();
			break;
		case 5:
			// Po wykonaniu programu: int x = 2, y = 3; x *= y * 2;
			// a) zmienna x=6 b) zmienna x=18 c) zmienna x=24 d) zmienna x=12.
			// Najpierw oblicz wartość zmiennej i wybierz jedną z odpowiedzi (a, b, c, d), a dopiero później sprawdź wynik uruchamiając program.
			Exercise_2_5();
			break;
		case 6:
			// Jaką wartość będzie miała zmienna x po wykonaniu instrukcji?
			// int x, y = 4; x = (y -= 2); x = y++; x = y--;
			// Najpierw oblicz wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
			Exercise_2_6();
			break;
		case 7:
			// Co wyświetli się na ekranie po wykonaniu poniższych instrukcji?
			// int x, y = 5; x = ++y * 2; x = y++; x = y--; Console.WriteLine(++y);
			// Najpierw oblicz wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
			Exercise_2_7();
			break;
		case 8:
			// Po wykonaniu poniższych linii programu:
			// bool x; int y = 1, z = 1; x = (y == 1 && z++ == 1);
			// zmienne przyjmą wartości:
			// a) x=true, y=1, z=2 b) x=1, y=1, z=2 c) x=true, y=1, z=1 d) x=2, y=1, z=2.
			// Najpierw oblicz wartości zmiennych i wybierz jedną z odpowiedzi (a, b, c, d), a dopiero później sprawdź wynik uruchamiając program.
			Exercise_2_8();
			break;
		case 9:
			// Jaką wartość przyjmą zmienne użyte w programie po wykonaniu poniższych instrukcji?
			// Najpierw ustal wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
			Exercise_2_9();
			break;
		case 10:
			// Po wykonaniu przedstawionego niżej kodu programu zmienna populationDensity przyjmie wartość 0.
			// Odpowiedz dlaczego i zmień program (w linii, gdzie jest obliczana zmienna gestoscZaludnienia) tak, aby wartość tej zmiennej wynosiła 0,1 (czyli 10/100):
			// int area = 100, persons = 10; double populationDensity = persons/area; Console.WriteLine(populationDensity);
			Exercise_2_10();
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
	Console.WriteLine("\nKoniec programu");
	Console.ReadLine();
}

// Napisz program przeliczający temperaturę w stopniach Celsjusza na temperaturę w stopniach Fahrenheita.
// Program ma prosić użytkownika o podanie temperatury w stopniach Celsjusza.
// Wzór: F = 32 + 9/5 * C
static void Exercise_2_1()
{
	Console.WriteLine("Zadanie 2.1");
	Console.Write("Podaj temp w *C: ");
	double temp;
	while (!double.TryParse(Console.ReadLine(), out temp))
	{
		Console.Write("Nie podałeś poprawnej wartości! Wpisz temp w *C: ");
	}
	Console.WriteLine($"{temp}*C = {32 + 9.0 / 5d * temp}*F");
}

// Napisz program, który oblicza deltę dla równania kwadratowego ax2 + bx + c = 0.
// Program ma prosić użytkownika o podanie współczynników równania a, b oraz c.
// Wzór: delta = b * b - 4ac
static void Exercise_2_2()
{
	Console.WriteLine("Zadanie 2.2");
	double a, b, c;
	string[] coefficients;
	do
	{
		Console.Write("Podaj współczynniki równania a, b oraz c (oddzielone spacją): ");
		coefficients = Console.ReadLine().Split(' ');
	} while (!double.TryParse(coefficients[0], out a) || !double.TryParse(coefficients[1], out b) || !double.TryParse(coefficients[2], out c));
	Console.WriteLine($"delta = {b * b - 4 * a * c}");
}

// Napisz program, który oblicza wskaźnik masy ciała BMI.
// Program ma prosić użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach.
// Wzór: BMI = masa / (wzrost * wzrost)
static void Exercise_2_3()
{
	Console.WriteLine("Zadanie 2.3");
	double mass, height;
	string[] coefficients;
	do
	{
		Console.Write("Podaj wage w kilogramach i wzrost w metrach (oddzielone spacją): ");
		coefficients = Console.ReadLine().Split(' ');
	} while (!double.TryParse(coefficients[0], out mass) || !double.TryParse(coefficients[1], out height));
	Console.WriteLine($"BMI = {mass / (height * height)}");
}

// Po wykonaniu programu: int x = 100; Console.WriteLine(++x * 2);
// a) wyświetli się liczba 202 b) wyświetli się liczba 200 c) będzie błąd d) wyświetli się liczba 201.
// Najpierw oblicz wyświetlaną wartość i wybierz jedną z odpowiedzi (a, b, c, d), a dopiero później sprawdź wynik uruchamiając program.
static void Exercise_2_4()
{
	Console.WriteLine("Zadanie 2.4");
	int x = 100;
	Console.WriteLine(++x * 2);
}

// Po wykonaniu programu: int x = 2, y = 3; x *= y * 2;
// a) zmienna x=6 b) zmienna x=18 c) zmienna x=24 d) zmienna x=12.
// Najpierw oblicz wartość zmiennej i wybierz jedną z odpowiedzi (a, b, c, d), a dopiero później sprawdź wynik uruchamiając program.
static void Exercise_2_5()
{
	Console.WriteLine("Zadanie 2.5");
	int x = 2, y = 3;
	x *= y * 2;
	Console.WriteLine(x);
}

// Jaką wartość będzie miała zmienna x po wykonaniu instrukcji?
// int x, y = 4; x = (y -= 2); x = y++; x = y--;
// Najpierw oblicz wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
static void Exercise_2_6()
{
	Console.WriteLine("Zadanie 2.6");
	int x, y = 4;
	x = (y -= 2);
	x = y++;
	x = y--;
	Console.WriteLine($"x = {x}, y = {y}");
}

// Co wyświetli się na ekranie po wykonaniu poniższych instrukcji?
// int x, y = 5; x = ++y * 2; x = y++; x = y--; Console.WriteLine(++y);
// Najpierw oblicz wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
static void Exercise_2_7()
{
	Console.WriteLine("Zadanie 2.7");
	int x, y = 5;
	x = ++y * 2;
	x = y++;
	x = y--;
	Console.WriteLine(++y);
}

// Po wykonaniu poniższych linii programu:
// bool x; int y = 1, z = 1; x = (y == 1 && z++ == 1);
// zmienne przyjmą wartości:
// a) x=true, y=1, z=2 b) x=1, y=1, z=2 c) x=true, y=1, z=1 d) x=2, y=1, z=2.
// Najpierw oblicz wartości zmiennych i wybierz jedną z odpowiedzi (a, b, c, d), a dopiero później sprawdź wynik uruchamiając program.
static void Exercise_2_8()
{
	Console.WriteLine("Zadanie 2.8");
	bool x;
	int y = 1, z = 1;
	x = (y == 1 && z++ == 1);
	Console.WriteLine($"x = {x}, y = {y}, z = {z}");
}

/*
Jaką wartość przyjmą zmienne użyte w programie po wykonaniu poniższych instrukcji? Najpierw ustal wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
a)
int x = 1, y = 4, z = 2;
bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
b)
int x = 1, y = 4, z = 2;
bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
c)
int x = 1, y = 4, z = 2;
bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
d)
int x = 1, y = 3, z = 4;
bool wynik = (x == 1 || y++ > 2 || ++z > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
e)
int x = 1, y = 3, z = 4;
bool wynik = (x == 1 | y++ > 2 || ++z > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
f)
int x = 1, y = 3, z = 4;
bool wynik = (x == 1 | y++ > 2 | ++z > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
*/
static void Exercise_2_9()
{
	Console.WriteLine("Zadanie 2.9");
	int x = 1, y = 4, z = 2;
	bool result = (x++ > 1 && y++ == 4 && z-- > 0);
	Console.WriteLine("a) wynik={0} x={1} y={2} z={3}", result, x, y, z); // false, x=2, y=4, z=2

	x = 1; y = 4; z = 2;
	result = (x++ > 1 & y++ == 4 && z-- > 0);
	Console.WriteLine("b) wynik={0} x={1} y={2} z={3}", result, x, y, z); // false, x=2, y=5, z=2

	x = 1; y = 4; z = 2;
	result = (x++ > 1 & y++ == 4 & z-- > 0);
	Console.WriteLine("c) wynik={0} x={1} y={2} z={3}", result, x, y, z); // false, x=2, y=5, z=1

	x = 1; y = 3; z = 4;
	result = (x == 1 || y++ > 2 || ++z > 0);
	Console.WriteLine("d) wynik={0} x={1} y={2} z={3}", result, x, y, z); // true, x=1, y=3, z=4

	x = 1; y = 3; z = 4;
	result = (x == 1 | y++ > 2 || ++z > 0);
	Console.WriteLine("e) wynik={0} x={1} y={2} z={3}", result, x, y, z); // true, x=1, y=4, z=4

	x = 1; y = 3; z = 4;
	result = (x == 1 | y++ > 2 | ++z > 0);
	Console.WriteLine("f) wynik={0} x={1} y={2} z={3}", result, x, y, z); // true, x=1, y=4, z=5
}

// Po wykonaniu przedstawionego niżej kodu programu zmienna gestoscZaludnienia przyjmie wartość 0.
// Odpowiedz dlaczego i zmień program (w linii, gdzie jest obliczana zmienna gestoscZaludnienia) tak, aby wartość tej zmiennej wynosiła 0,1 (czyli 10/100):
// int area = 100, persons = 10; double populationDensity = persons/area; Console.WriteLine(populationDensity);
static void Exercise_2_10()
{
	Console.WriteLine("Zadanie 2.10");
	double area = 100, people = 10;
	double populationDensity = people / area;
	Console.WriteLine(populationDensity);
}