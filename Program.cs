namespace millionaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kim Milyoner Olmak İster - V1
            Console.WriteLine("Kim Milyoner Olmak İster\n");
            Console.Write("İsim Giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Soyisim Giriniz: ");
            string soyisim = Console.ReadLine();


            Console.Write("\n1.Telefon Jokerinizi Giriniz: ");
            string telefonJoker1 = Console.ReadLine();
            Console.Write("2.Telefon Jokerinizi Giriniz: ");
            string telefonJoker2 = Console.ReadLine();
            Console.Write("3.Telefon Jokerinizi Giriniz: ");
            string telefonJoker3 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hoşgeldiniz " + isim + " " + soyisim);

            Console.Write("Kuralları Biliyor Musunuz? : ");
            char kuralCevap = char.Parse(Console.ReadLine().ToUpper());

            if (kuralCevap != 'E')
            {
                // TODO: Kurallar eklenecek.
                Console.WriteLine("Kurallar: asdfasdaads");
            }

            Console.Write("Hazır Mısınız? : ");
            char hazirCevap = char.Parse(Console.ReadLine().ToUpper());


            if (hazirCevap != 'E')
            {
                Console.WriteLine("Hazır olmananız bekleniyor.");
                Console.WriteLine("Hazır olduğunuzda Enter'a Basın");
                Console.ReadLine();
            }

            bool seyirciHak = true, yuzdeHak = true, telefonHak = true;
            int kasa = 0;

            int soruNo = 1, odul, baraj;
            int seyirciYuzdeA, seyirciYuzdeB, seyirciYuzdeC, seyirciYuzdeD;
            bool gizleA, gizleB, gizleC, gizleD;
            string soru, a, b, c, d;
            char cevap;

            #region Soru Bilgileri
            soruNo = 1;
            soru = "Türkiyenin Başkenti Neresidir?";
            a = "Ankara";
            b = "Bursa";
            c = "Van";
            d = "Denizli";
            cevap = 'A';
            odul = 1000;
            baraj = 0;// TODO: SoruNo ile baraj ilişkisi.

            // TODO: SoruNo ile ilişkili olarak Rastgele değerler olması lazım.
            seyirciYuzdeA = 80; seyirciYuzdeB = 10;
            seyirciYuzdeC = 5; seyirciYuzdeD = 5;

            // TODO: Daha iyi olabirlir mi? Her seferinde bunu tekrarlamaya gerek yok gibi.
            gizleA = false; gizleB = false;
            gizleC = false; gizleD = false;
        #endregion
        #region Soru Kalıbı
        soruNoktasi:
            Console.Clear();
            Console.WriteLine(soruNo + "-)" + soru);
            Console.WriteLine("A) " + (!gizleA ? a : ""));
            Console.WriteLine("B) " + (!gizleB ? b : ""));
            Console.WriteLine("C) " + (!gizleC ? c : ""));
            Console.WriteLine("D) " + (!gizleD ? d : ""));

        yanitNoktasi:
            bool jokerHak = seyirciHak || yuzdeHak || telefonHak;

            Console.Write("Cevabınızı Giriniz veya");
            if (jokerHak) Console.Write(" Joker için J'ye,");
            Console.Write(" Çekilmek için R'ye Basınız: ");
            char secim = char.Parse(Console.ReadLine().ToUpper());
            #endregion

        }
    }
}