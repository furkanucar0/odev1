            

            
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            
            Console.Write("Lütfen pozitif bir değer giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen pozitif bir değer giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());

            {
                List<int> ciftler = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}. sayıyı giriniz: ", i+1);
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi % m == 0)
                    {
                        ciftler.Add(sayi);
                    }
                }

                foreach (var sayi in ciftler)
                {
                    Console.Write(sayi + " ");
                }

            }