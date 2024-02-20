string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";

//Array - dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı",
    "Programlamaya başlangıç için temel kurs",
    "Java", "Python", "C#" };


for (int i = 0; i<kurslar.Length; i++) 
    
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For bitti");
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);  
}

Console.WriteLine("sayfa sonu  - footer");