//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.Write("Lütfen bir cümle giriniz: ");
string cümle = Convert.ToString(Console.ReadLine());
string[] kelimeler = cümle.Split(" ");
Console.WriteLine("Kelime Sayısı :"+kelimeler.Length);
Console.WriteLine("Yukarıdaki  ifade toplam {0} karakter içerir.", cümle.Length);
