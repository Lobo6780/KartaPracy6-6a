/*1. (Very Easy) Sprawdź czy wpisany przez użytkownika ciąg 3 liczb jest arytmetyczny / geometryczny /
rosnący / malejący. Ciąg jest arytmetyczny, gdy istnieje stała różnica między wyrazami: np. 3 5 7; 10 25
40; 13 10 7.Ciąg jest geometryczny, gdy istnieje stały iloraz między wyrazami: np. 2 4 8; 5 25 125; 9 3
1; 7 7 7.Pojęcie ciągu rosnącego i malejącego jest oczywiste.
WE: a, b, c
WY: arytmetyczny−TAK/NIE; geometryczny−TAK/NIE; rosnacy−TAK/NIE; malejacy−TAK/NIE*/

/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (b - a == c - b) Console.WriteLine("arytmetyczny - TAK");
else Console.WriteLine("arytmetyczny - NIE");
if (a * a == b & a * b == c) Console.WriteLine("geometryczny - TAK");
else Console.WriteLine("geometryczny - NIE");
if (a < b & b < c) Console.WriteLine("rosnący - TAK\nmalejący - NIE");
else Console.WriteLine("rosnący - NIE\nmalejący - TAK");
*/


/*2. (Easy) Oblicz sumę liczb trzycyfrowych podzielnych przez 8 i niepodzielnych przez 16
WE: -
WY: suma*/

/*
int suma = 0;
for (int i = 100; i < 1000; i++)
{
    if (i % 8 == 0 & i % 16 > 0) suma += i;
}
Console.WriteLine(suma);
*/

/*3. (Easy) Oblicz ilość liczb cztrocyfrowych będącymi wielokrotnościami największej liczby dwucyfrowej po-
dzielnej przez 7. Wielokrotność, będącą podstawą rozwiązania tego zadania, znajdź za pomocą pętli.
WE: -
WY: ilosc*/

/*int najw = 0;
int ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if (i % 17 == 0) najw = i;
}
int tmp = 0;
for (int i = 1; i < 100; i++)
{
    tmp = i * najw;
    for (int j = 0; j < ilosc; j++)
    {
        tmp = tmp / 10;
        ilosc++;
    }
}
Console.WriteLine(ilosc);
*/

/*4. (Medium) Oblicz ilość liczb dwucyfrowych, w kórych cyfra dziesiątek jest przynajmniej dwa razy większa
od cyfry jedności
WE: -
WY: ilosc*/

/*
int d = 0, j = 0, ilosc = 0;
for (int i = 10; i < 100; i++)
{
    j = i / 10;
    d = i % 10;
    if (d * 2 > j) ilosc++;
}
Console.WriteLine(ilosc);
*/

/*5. (Medium) Oblicz sumę i ilość liczb trzycyfrowych, w których cyfra setek jest większa od sumy cyfr dzie-
siątek i jedności
WE: -
WY: suma, ilosc*/

/*
int j = 0, d = 0, s = 0, ilosc = 0, suma = 0;
for (int i = 100; i < 1000; i++)
{
    j = i / 100;
    d = i / 10;
    d %= 10;
    s = i % 10;
    //if (d * 2 > j) ilosc++;
    if (s > j + d)
    {
        ilosc++;
        suma += i;
    }
}
Console.WriteLine($"Ilość cyfr: {ilosc} a suma {suma}.");
*/

/*6. (Medium) Oblicz sumę n najmniejszych liczb dwucyfowych podzielnych przez 19
WE: -n
WY: suma*/

int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 10; i < 100; i++)
{
    
}
