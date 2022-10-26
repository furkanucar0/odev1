//Kullanıcıdan alınan N sayısı kadar girdiği sayıların çift olanlarını konsola yazdırma 

            
            
            Console.Write("Lütfen pozitif bir değer giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            
                List<int> ciftler = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}. sayıyı giriniz: ", i+1);
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi % 2 == 0)
                    {
                        ciftler.Add(sayi);
                    }
                }

                foreach (var sayi in ciftler)
                {
                    Console.Write(sayi + " ");
                }

            