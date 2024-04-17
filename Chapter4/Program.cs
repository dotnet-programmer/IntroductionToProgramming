// Chapter 4

try
{
	Console.Write("Podaj numer zadania 1 - 15: ");
	int number;
	while ((!int.TryParse(Console.ReadLine(), out number)) || (number < 1 || number > 15))
	{
		Console.WriteLine("Nie wpisałeś liczby lub liczba jest poza zakresem!");
		Console.Write("Podaj numer zadania 1 - 15: ");
	}

	switch (number)
	{
		case 1:
			// Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb całkowitych wartościami podanymi przez użytkownika.
			// Na początku działania programu użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej elementów.
			// Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli.
			Exercise_4_1();
			break;
		case 2:
			// Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2 wyłącznie wartości dodatnie.
			// Obie tablice mają być jednowymiarowe o rozmiarze równym 10 (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji tej tablicy.
			Exercise_4_2();
			break;
		case 3:
			// Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy nelementowej:
			//- wartość i numer pozycji największego elementu,
			//- wartość i numer pozycji najmniejszego elementu,
			//- średnia wartości wszystkich elementów tablicy,
			//- liczba dodatnich elementów tablicy.
			Exercise_4_3();
			break;
		case 4:
			// Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu int. Tablicę należy wypełnić losowymi wartościami.
			// Wskazówka: Poniższy fragment programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych)
			// – w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie decydują argumenty podane w wywołaniu metody Next()43).
			// Random rand = new Random();
			// for (int i = 0; i < 100; i++)
			//	 Console.Write("{0,8}", rand.Next(1, 1000));
			Exercise_4_4();
			break;
		case 5:
			// Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o jedną pozycje.
			// To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod indeksem 2 itd.
			// Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy docelowej.
			Exercise_4_5();
			break;
		case 6:
			// Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb rzeczywistych o rozmiarze 5 x 5.
			// Program ma wyświetlić elementy tablicy (wiersz po wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej tablicy
			// (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).
			Exercise_4_6();
			break;
		case 7:
			/*
			Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji.
			Program ma wyświetlić macierz wynikową. Wskazówka: Dodawanie macierzy – macierz wynikowa C zawiera elementy, które stanowią sumę elementów macierzy A i B o odpowiednich indeksach, tzn.
			element w zerowym wierszu i zerowej kolumnie macierzy A jest dodawany do elementu o tych samych indeksach macierzy B, element A [0,1] do B [0,1]... itd.
			*/
			Exercise_4_7();
			break;
		case 8:
			/*
			Uzupełnij poniższy kod programu o wszystkie dni tygodnia i przy użyciu pętli wyświetl zawartość tablicy: w każdym wierszu dany dzień tygodnia w trzech językach (polskim, angielskim, niemieckim).
			string[,] dniTygodnia;
			dniTygodnia = new string[2, 3]; // pamiętaj o zmianie rozmiaru tablicy
			dniTygodnia[0, 0] = "poniedzialek";
			dniTygodnia[1, 0] = "wtorek";
			dniTygodnia[0, 1] = "monday";
			dniTygodnia[1, 1] = "tuesday";
			dniTygodnia[0, 2] = "montag";
			dniTygodnia[1, 2] = "dienstag";
			*/
			Exercise_4_8();
			break;
		case 9:
			/*
			Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.
			*/
			Exercise_4_9();
			break;
		case 10:
			/*
			Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze miesiąc i wyświetli jego nazwę słownie.
			*/
			Exercise_4_10();
			break;
		case 11:
			/*
			Napisz program analizujący częstość występowania poszczególnych znaków w łańcuchu znaków wprowadzonym przez użytkownika.
			Np. dla wprowadzonego tekstu „abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.
			*/
			Exercise_4_11();
			break;
		case 12:
			/*
			Napisz program, który dla zadeklarowanej niżej zmiennej łańcuchowej wyświetli jej zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu.
			// fragment powieści A. A. Milne, "Kubuś Puchatek"
			string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
			"Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
			"To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
			"co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
			"wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
			*/
			Exercise_4_12();
			break;
		case 13:
			/*
			Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego występowania słów w tekście.
			Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek”
			– program powinien wypisać raport o słowach powielonych w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy.
			*/
			Exercise_4_13();
			break;
		case 14:
			/*
			W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz czterech cyfr. Te cztery cyfry to rok zakupu danego środka trwałego.
			Przykładowe identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową tablicę typu string dla środków trwałych,
			którą należy zainicjalizować przykładowymi identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałego podać liczbę lat, jakie upłynęły od jego zakupu.
			*/
			Exercise_4_14();
			break;
		case 15:
			/*
			Napisz program, który szyfruje podany przez użytkownika tekst prostym szyfrem podstawieniowym zwanym „gaderypoluki”. Nazwa pochodzi od jednego z najczęściej używanych kluczy GA-DE-RY-PO-LU-KI.
			Klucz ten zawiera pary znakowych zamienników umieszczonych między myślnikami. Litery, których nie ma w kluczu pozostawia się w szyfrowanym tekście bez zmian.
			Przykładowo tekst „DRZEWO” po zaszyfrowaniu ma postać „EYZDWP”.
			0 1 2 3 4 5 6 7 8 9 10 11
			G A D E R Y P O L U K  I
			Wskazówki: Można zastosować w programie klucz z pominięciem myślników (GADERYPOLUKI). Wówczas można przyjąć, że znaki na parzystych pozycjach (numerując od 0) mają zamiennik po prawej stronie,
			a znaki na nieparzystych pozycjach mają swój zamiennik z lewej strony (np. litera O jest na pozycji numer 7 i ma swój zamiennik z lewej strony, czyli P).
			Zostaje zatem sprawdzenie, czy dany znak szyfrowanego tekstu występuje w kluczu, a jeśli tak to, na której pozycji klucza – parzystej czy nieparzystej.
			W tym celu możesz wykorzystać poznaną w tym rozdziale metodę IndexOf(). Dla zaszyfrowanego tekstu najlepiej będzie zadeklarować nową zmienną łańcuchową i zainicjalizować ją wartością pustą.
			Zalecamy, aby zrobić to przy pomocy statycznego pola publicznego String.Empty zawierającego łańcuch pusty (czyli ""), np.: string tekstZaszyfrowany = String.Empty;.
			A następnie w pętli dodawać kolejny znak z tekstu źródłowego – ten sam lub zamieniony zgodnie z kluczem (jeśli jest w kluczu).
			*/
			Exercise_4_15();
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

// Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb całkowitych wartościami podanymi przez użytkownika.
// Na początku działania programu użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej elementów.
// Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli.
static void Exercise_4_1()
{
	Console.WriteLine("Zadanie 4.1");
	Console.Write("Podaj rozmiar tablicy: ");
	if (!int.TryParse(Console.ReadLine(), out int size))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	int[] numbers = new int[size];
	for (int i = 0; i < numbers.Length; i++)
	{
		Console.Write($"Podaj {i + 1} element tablicy: ");
		if (!int.TryParse(Console.ReadLine(), out int element))
		{
			throw new ArgumentException("Nie wpisałeś liczby!");
		}

		numbers[i] = element;
	}
	foreach (var item in numbers)
	{
		Console.Write(item + " ");
	}

	Console.WriteLine();
}

// Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2 wyłącznie wartości dodatnie.
// Obie tablice mają być jednowymiarowe o rozmiarze równym 10 (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji tej tablicy.
static void Exercise_4_2()
{
	Console.WriteLine("Zadanie 4.2");
	int[] numbers1 = [1, -1, 2, -2, 3, -3, 4, -4, 5, -5];
	int[] numbers2 = new int[numbers1.Length];
	for (int i = 0, j = 0; i < numbers1.Length; i++)
	{
		if (numbers1[i] > 0)
		{
			numbers2[j] = numbers1[i];
			j++;
		}
	}
	foreach (var item in numbers1)
	{
		Console.Write(item + " ");
	}

	Console.WriteLine();
	foreach (var item in numbers2)
	{
		Console.Write(item + " ");
	}

	Console.WriteLine();
}

// Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy nelementowej:
//- wartość i numer pozycji największego elementu,
//- wartość i numer pozycji najmniejszego elementu,
//- średnia wartości wszystkich elementów tablicy,
//- liczba dodatnich elementów tablicy.
static void Exercise_4_3()
{
	Console.Write("Podaj rozmiar tablicy: ");
	if (!int.TryParse(Console.ReadLine(), out int size))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	int[] numbers = new int[size];
	for (int i = 0; i < numbers.Length; i++)
	{
		Console.Write($"Podaj {i + 1} element tablicy: ");
		if (!int.TryParse(Console.ReadLine(), out int element))
		{
			throw new ArgumentException("Nie wpisałeś liczby!");
		}

		numbers[i] = element;
	}

	int max = numbers[0];
	int min = numbers[0];
	int maxPos = 0;
	int minPos = 0;
	int positiveNumbers = 0;
	double avg = 0;

	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] > max)
		{
			max = numbers[i];
			maxPos = i;
		}
		if (numbers[i] < min)
		{
			min = numbers[i];
			minPos = i;
		}
		if (numbers[i] > 0)
		{
			positiveNumbers++;
		}

		avg += numbers[i];
	}
	avg /= size;
	Console.WriteLine($"Max element = {max}, pozycja w tablicy = {maxPos}");
	Console.WriteLine($"Min element = {min}, pozycja w tablicy = {minPos}");
	Console.WriteLine($"Srednia wartość = {avg}");
	Console.WriteLine($"Ile dodatnich = {positiveNumbers}");
}

// Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu int. Tablicę należy wypełnić losowymi wartościami.
// Wskazówka: Poniższy fragment programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych)
// – w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie decydują argumenty podane w wywołaniu metody Next()43).
// Random rand = new Random();
// for (int i = 0; i < 100; i++)
//	 Console.Write("{0,8}", rand.Next(1, 1000));
static void Exercise_4_4()
{
	Console.WriteLine("Zadanie 4.4");
	var rand = new Random();
	int[] numbers = new int[100];
	for (int i = 0; i < numbers.Length; i++)
	{
		numbers[i] = rand.Next(1, 1000);
	}

	List<int> primes = [];
	foreach (var item in numbers)
	{
		if (IsPrime(item))
		{
			primes.Add(item);
		}
	}
	primes.Sort();
	Console.WriteLine($"Ilość liczb pierwszych w zbiorze: {primes.Count}");
	Console.WriteLine("Te liczby to: ");
	foreach (var item in primes)
	{
		Console.Write(item + " ");
	}

	Console.WriteLine();

	static bool IsPrime(int item)
	{
		if (item < 2)
		{
			return false;
		}

		for (int i = 2; i < item; i++)
		{
			if (item % i == 0)
			{
				return false;
			}
		}

		return true;
	}
}

// Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o jedną pozycje.
// To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod indeksem 2 itd.
// Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy docelowej.
static void Exercise_4_5()
{
	Console.WriteLine("Zadanie 4.5");
	Console.Write("Podaj rozmiar tablicy: ");
	if (!int.TryParse(Console.ReadLine(), out int size))
	{
		throw new ArgumentException("Nie wpisałeś liczby!");
	}

	Random rand = new();
	int[] numbers1 = new int[size];
	for (int i = 0; i < numbers1.Length; i++)
	{
		numbers1[i] = rand.Next(1, 1000);
	}

	int[] numbers2 = new int[numbers1.Length];
	//for (int i = 0; i < tab1.Length; i++)
	//{
	//	if (i == tab1.Length - 1)
	//		tab2[0] = tab1[tab1.Length - 1];
	//	else
	//		tab2[i + 1] = tab1[i];
	//}

	numbers2[0] = numbers1[numbers1.Length - 1];
	for (int i = 0; i < numbers1.Length - 1; i++)
	{
		numbers2[i + 1] = numbers1[i];
	}

	foreach (var item in numbers1)
	{
		Console.Write(item + " ");
	}

	Console.WriteLine();
	foreach (var item in numbers2)
	{
		Console.Write(item + " ");
	}

	Console.WriteLine();
}

// Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb rzeczywistych o rozmiarze 5 x 5.
// Program ma wyświetlić elementy tablicy (wiersz po wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej tablicy
// (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).
static void Exercise_4_6()
{
	Console.WriteLine("Zadanie 4.6");
	var array = new double[5, 5];
	var random = new Random();
	double sum = 0;
	for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) pobiera rozmiar tablicy pierwszego wymiaru
	{
		for (int j = 0; j < array.GetLength(1); j++) // GetLength(1) pobiera rozmiar tablicy drugiego wymiaru
		{
			array[i, j] = random.NextDouble() * random.Next(100);
			if (i == j)
			{
				sum += array[i, j];
			}
		}
	}

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j],6:0.00} "); // formatowanie tekstu, wyrównanie do 6 znaków, 2 miejsca po przecinku
		}

		Console.WriteLine();
	}
	Console.WriteLine($"Suma elementów na głównej przekątnej = {sum:0.00}");
}

/*
Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji.
Program ma wyświetlić macierz wynikową. Wskazówka: Dodawanie macierzy – macierz wynikowa C zawiera elementy, które stanowią sumę elementów macierzy A i B o odpowiednich indeksach, tzn.
element w zerowym wierszu i zerowej kolumnie macierzy A jest dodawany do elementu o tych samych indeksach macierzy B, element A[0,1] do B[0,1]... itd.
*/
static void Exercise_4_7()
{
	Console.WriteLine("Zadanie 4.7");
	double[,] arrayA = { { 1, 1, 1 }, { 2, 2, 2 } };
	double[,] arrayB = { { 3, 3, 3 }, { 4, 4, 4 } };
	double[,] arrayC = new double[2, 3];
	for (int i = 0; i < arrayA.GetLength(0); i++)
	{
		for (int j = 0; j < arrayA.GetLength(1); j++)
		{
			arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
		}
	}

	for (int i = 0; i < arrayC.GetLength(0); i++)
	{
		for (int j = 0; j < arrayC.GetLength(1); j++)
		{
			Console.Write($"{arrayC[i, j],6:0.00} ");
		}

		Console.WriteLine();
	}
}

/*
Uzupełnij poniższy kod programu o wszystkie dni tygodnia i przy użyciu pętli wyświetl zawartość tablicy: w każdym wierszu dany dzień tygodnia w trzech językach (polskim, angielskim, niemieckim).
string[,] dniTygodnia;
dniTygodnia = new string[2, 3]; // pamiętaj o zmianie rozmiaru tablicy
dniTygodnia[0, 0] = "poniedzialek";
dniTygodnia[1, 0] = "wtorek";
dniTygodnia[0, 1] = "monday";
dniTygodnia[1, 1] = "tuesday";
dniTygodnia[0, 2] = "montag";
dniTygodnia[1, 2] = "dienstag";
*/
static void Exercise_4_8()
{
	Console.WriteLine("Zadanie 4.8");
	string[,] daysOfTheWeek;
	daysOfTheWeek = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
	daysOfTheWeek[0, 0] = "poniedzialek";
	daysOfTheWeek[1, 0] = "wtorek";
	daysOfTheWeek[2, 0] = "środa";
	daysOfTheWeek[3, 0] = "czwartek";
	daysOfTheWeek[4, 0] = "piątek";
	daysOfTheWeek[5, 0] = "sobota";
	daysOfTheWeek[6, 0] = "niedziela";

	daysOfTheWeek[0, 1] = "monday";
	daysOfTheWeek[1, 1] = "tuesday";
	daysOfTheWeek[2, 1] = "wednesday";
	daysOfTheWeek[3, 1] = "thursday";
	daysOfTheWeek[4, 1] = "friday";
	daysOfTheWeek[5, 1] = "saturday";
	daysOfTheWeek[6, 1] = "sunday";

	daysOfTheWeek[0, 2] = "montag";
	daysOfTheWeek[1, 2] = "dienstag";
	daysOfTheWeek[2, 2] = "mittwoch";
	daysOfTheWeek[3, 2] = "donnerstag";
	daysOfTheWeek[4, 2] = "freitag";
	daysOfTheWeek[5, 2] = "samstag";
	daysOfTheWeek[6, 2] = "sonntag ";

	for (int i = 0; i < 7; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			Console.Write(daysOfTheWeek[i, j] + " ");
		}
		Console.WriteLine();
	}
}

/*
Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.
*/
static void Exercise_4_9()
{
	Console.WriteLine("Zadanie 4.9");
	Console.Write("Napisz jakies zdanie: ");
	string[] sentence = Console.ReadLine().Split(' ');
	Console.WriteLine($"Liczba podanych wyrazów = {sentence.Length}");
}

/*
Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze miesiąc i wyświetli jego nazwę słownie.
*/
static void Exercise_4_10()
{
	Console.WriteLine("Zadanie 4.10");
	Console.Write("Napisz datę w formacie DD-MM-RRRR: ");
	string[] date = Console.ReadLine().Split('-');
	switch (date[1])
	{
		case "01":
			Console.WriteLine("Styczeń");
			break;
		case "02":
			Console.WriteLine("Luty");
			break;
		case "03":
			Console.WriteLine("Marzec");
			break;
		case "04":
			Console.WriteLine("Kwiecień");
			break;
		case "05":
			Console.WriteLine("Maj");
			break;
		case "06":
			Console.WriteLine("Czerwiec");
			break;
		case "07":
			Console.WriteLine("Lipiec");
			break;
		case "08":
			Console.WriteLine("Sierpień");
			break;
		case "09":
			Console.WriteLine("Wrzesień");
			break;
		case "10":
			Console.WriteLine("Październik");
			break;
		case "11":
			Console.WriteLine("Listopad");
			break;
		case "12":
			Console.WriteLine("Grudzień");
			break;
		default:
			throw new ArgumentException("Nie ma takiego miesiąca!");
	}
}

/*
Napisz program analizujący częstość występowania poszczególnych znaków w łańcuchu znaków wprowadzonym przez użytkownika.
Np. dla wprowadzonego tekstu „abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.
*/
static void Exercise_4_11()
{
	Console.WriteLine("Zadanie 4.11");
	Console.Write("Napisz jakiś wyraz: ");
	string sentence = Console.ReadLine();
	Dictionary<char, int> letters = [];
	foreach (char item in sentence)
	{
		if (letters.ContainsKey(item))
		{
			letters[item]++;
		}
		else
		{
			letters[item] = 1;
		}
	}
	foreach (var item in letters)
	{
		Console.WriteLine($"{item.Key} - {item.Value}");
	}
}

/*
Napisz program, który dla zadeklarowanej niżej zmiennej łańcuchowej wyświetli jej zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu.
// fragment powieści A. A. Milne, "Kubuś Puchatek"
string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
"Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
"To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
"co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
"wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
*/
static void Exercise_4_12()
{
	Console.WriteLine("Zadanie 4.12");
	string sentence = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
					"Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
					"To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
					"co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
					"wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
	Console.WriteLine(sentence);
	string[] rows = sentence.Split('\n');
	Console.WriteLine($"Liczba wierszy = {rows.Length}");
	int i = 1;
	foreach (var item in rows)
	{
		Console.WriteLine($"wiersz {i++} - {item.Length} znaków");
	}
}

/*
Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego występowania słów w tekście.
Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek”
– program powinien wypisać raport o słowach powielonych w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy.
*/
static void Exercise_4_13()
{
	Console.WriteLine("Zadanie 4.13");
	Console.Write("Napisz jakieś zdanie: ");
	string[] sentence = Console.ReadLine().Split(' ');
	Dictionary<string, int> letters = [];
	foreach (string item in sentence)
	{
		if (letters.ContainsKey(item))
		{
			letters[item]++;
		}
		else
		{
			letters[item] = 1;
		}
	}
	foreach (var item in letters)
	{
		Console.WriteLine($"{item.Key} - {item.Value}");
	}
}

/*
W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz czterech cyfr. Te cztery cyfry to rok zakupu danego środka trwałego.
Przykładowe identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową tablicę typu string dla środków trwałych,
którą należy zainicjalizować przykładowymi identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałego podać liczbę lat, jakie upłynęły od jego zakupu.
*/
static void Exercise_4_14()
{
	Console.WriteLine("Zadanie 4.14");
	string[] tab = ["KOMG-2002", "BH-2010", "ASD-2008", "QWER-2007", "UIOP-2007"];
	DateTime myDate = DateTime.Now;
	foreach (var item in tab)
	{
		int year = int.Parse(item[(item.IndexOf('-') + 1)..]);
		Console.WriteLine($"Przedmiot {item} był kupiony {myDate.Year - year} lat temu");
	}
}

/*
Napisz program, który szyfruje podany przez użytkownika tekst prostym szyfrem podstawieniowym zwanym „gaderypoluki”. Nazwa pochodzi od jednego z najczęściej używanych kluczy GA-DE-RY-PO-LU-KI.
Klucz ten zawiera pary znakowych zamienników umieszczonych między myślnikami. Litery, których nie ma w kluczu pozostawia się w szyfrowanym tekście bez zmian.
Przykładowo tekst „DRZEWO” po zaszyfrowaniu ma postać „EYZDWP”.
0 1 2 3 4 5 6 7 8 9 10 11
G A D E R Y P O L U K  I
Wskazówki: Można zastosować w programie klucz z pominięciem myślników (GADERYPOLUKI). Wówczas można przyjąć, że znaki na parzystych pozycjach (numerując od 0) mają zamiennik po prawej stronie,
a znaki na nieparzystych pozycjach mają swój zamiennik z lewej strony (np. litera O jest na pozycji numer 7 i ma swój zamiennik z lewej strony, czyli P).
Zostaje zatem sprawdzenie, czy dany znak szyfrowanego tekstu występuje w kluczu, a jeśli tak to, na której pozycji klucza – parzystej czy nieparzystej.
W tym celu możesz wykorzystać poznaną w tym rozdziale metodę IndexOf(). Dla zaszyfrowanego tekstu najlepiej będzie zadeklarować nową zmienną łańcuchową i zainicjalizować ją wartością pustą.
Zalecamy, aby zrobić to przy pomocy statycznego pola publicznego String.Empty zawierającego łańcuch pusty (czyli ""), np.: string tekstZaszyfrowany = String.Empty;.
A następnie w pętli dodawać kolejny znak z tekstu źródłowego – ten sam lub zamieniony zgodnie z kluczem (jeśli jest w kluczu).
*/
static void Exercise_4_15()
{
	Console.WriteLine("Zadanie 4.15");
	Console.Write("Napisz jakiś wyraz: ");
	string sentence = Console.ReadLine().ToUpper();
	string key = "GA-DE-RY-PO-LU-KI";
	string[] keys = key.Split('-');
	string textEncrypted = "";
	foreach (char item in sentence)
	{
		if (key.Contains(item))
		{
			foreach (var pair in keys)
			{
				if (pair[0] == item)
				{
					textEncrypted += pair[1];
				}
				else if (pair[1] == item)
				{
					textEncrypted += pair[0];
				}
			}
		}
		else
		{
			textEncrypted += item;
		}
	}
	Console.WriteLine(textEncrypted);
}