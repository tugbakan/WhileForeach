//While
Console.WriteLine("***While Döngüsü***");
//1'den başlayarak consoledan girilen bir sayıya kadar(sayı da dahil) ortalamasını ekrana yazdıran program

Console.Write("Lütfen bir sayı giriniz.");
int sayi= int.Parse(Console.ReadLine());
int sayac=1;
int toplam=0;

while (sayac<=sayi)
{
    toplam+=sayac;    
    sayac++;
}
Console.WriteLine(toplam/sayi);

// a'dan z'ye kadar tüm harfleri konsola yazdıran program.

char character = 'a';
while (character <= 'z') 
{
    Console.Write(character + " ");
    character++;
}
Console.WriteLine("");

//Foreach Döngüsü

Console.WriteLine("***Foreach Döngüsü***");

string[] arabalar= {"BMW", "Ford" , "Volkswagen", "Toyota", "Nissan"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
    
}