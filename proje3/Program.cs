//  Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.Write("Lütfen bir değer giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] kelimeler = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write("{0}. Kelimeyi giriniz: ", i + 1);
    kelimeler[i] = Convert.ToString(Console.ReadLine());
}
for (int a = n; a > 0; a--) { Console.WriteLine(kelimeler[a-1]); }