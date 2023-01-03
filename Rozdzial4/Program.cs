// Rozdział 4

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
			Zadanie_4_1();
			break;
		case 2:
			// Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2 wyłącznie wartości dodatnie. 
			// Obie tablice mają być jednowymiarowe o rozmiarze równym 10 (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji tej tablicy.
			Zadanie_4_2();
			break;
		case 3:
			// Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy nelementowej:
			//- wartość i numer pozycji największego elementu,
			//- wartość i numer pozycji najmniejszego elementu,
			//- średnia wartości wszystkich elementów tablicy,
			//- liczba dodatnich elementów tablicy.
			Zadanie_4_3();
			break;
		case 4:
			// Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu int. Tablicę należy wypełnić losowymi wartościami. 
			// Wskazówka: Poniższy fragment programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych)
			// – w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie decydują argumenty podane w wywołaniu metody Next()43).
			// Random rand = new Random();
			// for (int i = 0; i < 100; i++)
			//	 Console.Write("{0,8}", rand.Next(1, 1000));
			Zadanie_4_4();
			break;
		case 5:
			// Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o jedną pozycje. 
			// To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod indeksem 2 itd. 
			// Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy docelowej.
			Zadanie_4_5();
			break;
		case 6:
			// Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb rzeczywistych o rozmiarze 5 x 5. 
			// Program ma wyświetlić elementy tablicy (wiersz po wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej tablicy 
			// (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).
			Zadanie_4_6();
			break;
		case 7:
			/*
			Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji. 
			Program ma wyświetlić macierz wynikową. Wskazówka: Dodawanie macierzy – macierz wynikowa C zawiera elementy, które stanowią sumę elementów macierzy A i B o odpowiednich indeksach, tzn.
			element w zerowym wierszu i zerowej kolumnie macierzy A jest dodawany do elementu o tych samych indeksach macierzy B, element A [0,1] do B [0,1]... itd.
			*/
			Zadanie_4_7();
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
			Zadanie_4_8();
			break;
		case 9:
			/*
			Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.
			*/
			Zadanie_4_9();
			break;
		case 10:
			/*
			Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze miesiąc i wyświetli jego nazwę słownie.
			*/
			Zadanie_4_10();
			break;
		case 11:
			/*
			Napisz program analizujący częstość występowania poszczególnych znaków w łańcuchu znaków wprowadzonym przez użytkownika. 
			Np. dla wprowadzonego tekstu „abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.
			*/
			Zadanie_4_11();
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
			Zadanie_4_12();
			break;
		case 13:
			/*
			Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego występowania słów w tekście. 
			Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek” 
			– program powinien wypisać raport o słowach powielonych w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy.
			*/
			Zadanie_4_13();
			break;
		case 14:
			/*
			W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz czterech cyfr. Te cztery cyfry to rok zakupu danego środka trwałego. 
			Przykładowe identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową tablicę typu string dla środków trwałych, 
			którą należy zainicjalizować przykładowymi identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałego podać liczbę lat, jakie upłynęły od jego zakupu.
			*/
			Zadanie_4_14();
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
			Zadanie_4_15();
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
static void Zadanie_4_1()
{
	Console.WriteLine("Zadanie 4.1");
	Console.Write("Podaj rozmiar tablicy: ");
	if (!int.TryParse(Console.ReadLine(), out int rozmiar))
		throw new ArgumentException("Nie wpisałeś liczby!");
	int[] tablica = new int[rozmiar];
	for (int i = 0; i < tablica.Length; i++)
	{
		Console.Write($"Podaj {i + 1} element tablicy: ");
		if (!int.TryParse(Console.ReadLine(), out int element))
			throw new ArgumentException("Nie wpisałeś liczby!");
		tablica[i] = element;
	}
	foreach (var item in tablica)
		Console.Write(item + " ");
	Console.WriteLine();
}

// Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2 wyłącznie wartości dodatnie. 
// Obie tablice mają być jednowymiarowe o rozmiarze równym 10 (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji tej tablicy.
static void Zadanie_4_2()
{
	Console.WriteLine("Zadanie 4.2");
	int[] tab1 = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5 };
	int[] tab2 = new int[tab1.Length];
	for (int i = 0, j = 0; i < tab1.Length; i++)
	{
		if (tab1[i] > 0)
		{
			tab2[j] = tab1[i];
			j++;
		}
	}
	foreach (var item in tab1)
		Console.Write(item + " ");
	Console.WriteLine();
	foreach (var item in tab2)
		Console.Write(item + " ");
	Console.WriteLine();
}

// Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy nelementowej:
//- wartość i numer pozycji największego elementu,
//- wartość i numer pozycji najmniejszego elementu,
//- średnia wartości wszystkich elementów tablicy,
//- liczba dodatnich elementów tablicy.
static void Zadanie_4_3()
{
	Console.Write("Podaj rozmiar tablicy: ");
	if (!int.TryParse(Console.ReadLine(), out int rozmiar))
		throw new ArgumentException("Nie wpisałeś liczby!");
	int[] tablica = new int[rozmiar];
	for (int i = 0; i < tablica.Length; i++)
	{
		Console.Write($"Podaj {i + 1} element tablicy: ");
		if (!int.TryParse(Console.ReadLine(), out int element))
			throw new ArgumentException("Nie wpisałeś liczby!");
		tablica[i] = element;
	}
	int max = tablica[0];
	int min = tablica[0];
	int maxPos = 0;
	int minPos = 0;
	int ileDodatnich = 0;
	double srednia = 0;
	for (int i = 0; i < tablica.Length; i++)
	{
		if (tablica[i] > max)
		{
			max = tablica[i];
			maxPos = i;
		}
		if (tablica[i] < min)
		{
			min = tablica[i];
			minPos = i;
		}
		if (tablica[i] > 0)
			ileDodatnich++;
		srednia += tablica[i];
	}
	srednia /= rozmiar;
	Console.WriteLine($"Max element = {max}, pozycja w tablicy = {maxPos}");
	Console.WriteLine($"Min element = {min}, pozycja w tablicy = {minPos}");
	Console.WriteLine($"Srednia wartość = {srednia}");
	Console.WriteLine($"Ile dodatnich = {ileDodatnich}");
}

// Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu int. Tablicę należy wypełnić losowymi wartościami. 
// Wskazówka: Poniższy fragment programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych)
// – w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie decydują argumenty podane w wywołaniu metody Next()43).
// Random rand = new Random();
// for (int i = 0; i < 100; i++)
//	 Console.Write("{0,8}", rand.Next(1, 1000));
static void Zadanie_4_4()
{
	Console.WriteLine("Zadanie 4.4");
	var rand = new Random();
	int[] tablica = new int[100];
	for (int i = 0; i < tablica.Length; i++)
		tablica[i] = rand.Next(1, 1000);
	List<int> pierwsze = new List<int>();
	foreach (var item in tablica)
	{
		if (CzyPierwsza(item))
			pierwsze.Add(item);
	}
	pierwsze.Sort();
	Console.WriteLine($"Ilość liczb pierwszych w zbiorze: {pierwsze.Count}");
	Console.WriteLine("Te liczby to: ");
	foreach (var item in pierwsze)
		Console.Write(item + " ");
	Console.WriteLine();

	bool CzyPierwsza(int item)
	{
		if (item < 2)
			return false;
		for (int i = 2; i < item; i++)
			if (item % i == 0)
				return false;
		return true;
	}
}

// Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o jedną pozycje. 
// To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod indeksem 2 itd. 
// Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy docelowej.
static void Zadanie_4_5()
{
	Console.WriteLine("Zadanie 4.5");
	Console.Write("Podaj rozmiar tablicy: ");
	if (!int.TryParse(Console.ReadLine(), out int rozmiar))
		throw new ArgumentException("Nie wpisałeś liczby!");
	Random rand = new Random();
	int[] tab1 = new int[rozmiar];
	for (int i = 0; i < tab1.Length; i++)
		tab1[i] = rand.Next(1, 1000);
	int[] tab2 = new int[tab1.Length];
	//for (int i = 0; i < tab1.Length; i++)
	//{
	//	if (i == tab1.Length - 1)
	//		tab2[0] = tab1[tab1.Length - 1];
	//	else
	//		tab2[i + 1] = tab1[i];
	//}

	tab2[0] = tab1[tab1.Length - 1];
	for (int i = 0; i < tab1.Length - 1; i++)
	{
		tab2[i + 1] = tab1[i];
	}

	foreach (var item in tab1)
		Console.Write(item + " ");
	Console.WriteLine();
	foreach (var item in tab2)
		Console.Write(item + " ");
	Console.WriteLine();
}

// Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb rzeczywistych o rozmiarze 5 x 5. 
// Program ma wyświetlić elementy tablicy (wiersz po wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej tablicy 
// (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).
static void Zadanie_4_6()
{
	Console.WriteLine("Zadanie 4.6");
	var tablica = new double[5, 5];
	var random = new Random();
	double suma = 0;
	for (int i = 0; i < tablica.GetLength(0); i++) // GetLength(0) pobiera rozmiar tablicy pierwszego wymiaru
		for (int j = 0; j < tablica.GetLength(1); j++) // GetLength(1) pobiera rozmiar tablicy drugiego wymiaru
		{
			tablica[i, j] = random.NextDouble() * random.Next(100);
			if (i == j)
				suma += tablica[i, j];
		}
	for (int i = 0; i < tablica.GetLength(0); i++)
	{
		for (int j = 0; j < tablica.GetLength(1); j++)
			Console.Write($"{tablica[i, j],6:0.00} "); // formatowanie tekstu, wyrównanie do 6 znaków, 2 miejsca po przecinku
		Console.WriteLine();
	}
	Console.WriteLine($"Suma elementów na głównej przekątnej = {suma:0.00}");
}

/*
Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji. 
Program ma wyświetlić macierz wynikową. Wskazówka: Dodawanie macierzy – macierz wynikowa C zawiera elementy, które stanowią sumę elementów macierzy A i B o odpowiednich indeksach, tzn.
element w zerowym wierszu i zerowej kolumnie macierzy A jest dodawany do elementu o tych samych indeksach macierzy B, element A[0,1] do B[0,1]... itd.
*/
static void Zadanie_4_7()
{
	Console.WriteLine("Zadanie 4.7");
	double[,] tabA = { { 1, 1, 1 }, { 2, 2, 2 } };
	double[,] tabB = { { 3, 3, 3 }, { 4, 4, 4 } };
	double[,] tabC = new double[2, 3];
	for (int i = 0; i < tabA.GetLength(0); i++)
		for (int j = 0; j < tabA.GetLength(1); j++)
			tabC[i, j] = tabA[i, j] + tabB[i, j];
	for (int i = 0; i < tabC.GetLength(0); i++)
	{
		for (int j = 0; j < tabC.GetLength(1); j++)
			Console.Write($"{tabC[i, j],6:0.00} ");
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
static void Zadanie_4_8()
{
	Console.WriteLine("Zadanie 4.8");
	string[,] dniTygodnia;
	dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
	dniTygodnia[0, 0] = "poniedzialek";
	dniTygodnia[1, 0] = "wtorek";
	dniTygodnia[2, 0] = "środa";
	dniTygodnia[3, 0] = "czwartek";
	dniTygodnia[4, 0] = "piątek";
	dniTygodnia[5, 0] = "sobota";
	dniTygodnia[6, 0] = "niedziela";

	dniTygodnia[0, 1] = "monday";
	dniTygodnia[1, 1] = "tuesday";
	dniTygodnia[2, 1] = "wednesday";
	dniTygodnia[3, 1] = "thursday";
	dniTygodnia[4, 1] = "friday";
	dniTygodnia[5, 1] = "saturday";
	dniTygodnia[6, 1] = "sunday";

	dniTygodnia[0, 2] = "montag";
	dniTygodnia[1, 2] = "dienstag";
	dniTygodnia[2, 2] = "mittwoch";
	dniTygodnia[3, 2] = "donnerstag";
	dniTygodnia[4, 2] = "freitag";
	dniTygodnia[5, 2] = "samstag";
	dniTygodnia[6, 2] = "sonntag ";

	for (int i = 0; i < 7; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			Console.Write(dniTygodnia[i, j] + " ");
		}
		Console.WriteLine();
	}
}

/*
Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.
*/
static void Zadanie_4_9()
{
	Console.WriteLine("Zadanie 4.9");
	Console.Write("Napisz jakies zdanie: ");
	string[] napisy = Console.ReadLine()!.Split(' ');
	Console.WriteLine($"Liczba podanych wyrazów = {napisy.Length}");
}

/*
Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze miesiąc i wyświetli jego nazwę słownie.
*/
static void Zadanie_4_10()
{
	Console.WriteLine("Zadanie 4.10");
	Console.Write("Napisz datę w formacie DD-MM-RRRR: ");
	string[] data = Console.ReadLine()!.Split('-');
	switch (data[1])
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
static void Zadanie_4_11()
{
	Console.WriteLine("Zadanie 4.11");
	Console.Write("Napisz jakiś wyraz: ");
	string napis = Console.ReadLine()!;
	Dictionary<char, int> litery = new();
	foreach (char item in napis)
	{
		if (litery.ContainsKey(item))
			litery[item]++;
		else
			litery[item] = 1;
	}
	foreach (var item in litery)
		Console.WriteLine($"{item.Key} - {item.Value}");
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
static void Zadanie_4_12()
{
	Console.WriteLine("Zadanie 4.12");
	string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
					"Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
					"To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
					"co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
					"wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
	Console.WriteLine(tekst);
	string[] wiersze = tekst.Split('\n');
	Console.WriteLine($"Liczba wierszy = {wiersze.Length}");
	int i = 1;
	foreach (var item in wiersze)
		Console.WriteLine($"wiersz {i++} - {item.Length} znaków");
}

/*
Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego występowania słów w tekście. 
Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek” 
– program powinien wypisać raport o słowach powielonych w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy.
*/
static void Zadanie_4_13()
{
	Console.WriteLine("Zadanie 4.13");
	Console.Write("Napisz jakieś zdanie: ");
	string[] wyrazy = Console.ReadLine()!.Split(' ');
	Dictionary<string, int> litery = new Dictionary<string, int>();
	foreach (string item in wyrazy)
	{
		if (litery.ContainsKey(item))
			litery[item]++;
		else
			litery[item] = 1;
	}
	foreach (var item in litery)
		Console.WriteLine($"{item.Key} - {item.Value}");
}

/*
W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz czterech cyfr. Te cztery cyfry to rok zakupu danego środka trwałego. 
Przykładowe identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową tablicę typu string dla środków trwałych, 
którą należy zainicjalizować przykładowymi identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałego podać liczbę lat, jakie upłynęły od jego zakupu.
*/
static void Zadanie_4_14()
{
	Console.WriteLine("Zadanie 4.14");
	string[] tab = { "KOMG-2002", "BH-2010", "ASD-2008", "QWER-2007", "UIOP-2007" };
	DateTime myDate = DateTime.Now;
	foreach (var item in tab)
	{
		int rok = int.Parse(item.Substring(item.IndexOf('-') + 1));
		Console.WriteLine($"Przedmiot {item} był kupiony {myDate.Year - rok} lat temu");
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
static void Zadanie_4_15()
{
	Console.WriteLine("Zadanie 4.15");
	Console.Write("Napisz jakiś wyraz: ");
	string napis = Console.ReadLine()!.ToUpper();
	string klucz = "GA-DE-RY-PO-LU-KI";
	string[] klucze = klucz.Split('-');
	string tekstZaszyfrowany = "";
	foreach (char item in napis)
	{
		if (klucz.Contains(item))
		{
			foreach (var paraKlucza in klucze)
				if (paraKlucza[0] == item)
					tekstZaszyfrowany += paraKlucza[1];
				else if (paraKlucza[1] == item)
					tekstZaszyfrowany += paraKlucza[0];
		}
		else
			tekstZaszyfrowany += item;
	}
	Console.WriteLine(tekstZaszyfrowany);
}