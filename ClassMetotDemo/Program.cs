using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Aleyna";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Adres = "İstanbul";
            musteri1.TelNo = 5555555555;
            musteri1.KacAdet = 10;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Dilan";
            musteri2.Soyadi = "Yıldırım";
            musteri2.Adres = "Ankara";
            musteri2.TelNo = 5544444444;
            musteri2.KacAdet = 12;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Merve";
            musteri3.Soyadi = "Yurt";
            musteri3.Adres = "İstanbul";
            musteri3.TelNo = 5333333333;
            musteri3.KacAdet = 8;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine();

            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusteriSilme(musteri3);
            Console.WriteLine();

            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriListeleme(musteri2);
            musteriManager.MusteriListeleme(musteri3);
            Console.WriteLine();

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı:"+musteri.Adi);
                Console.WriteLine("Müşteri Soyadı:" + musteri.Soyadi);
                Console.WriteLine("Müşteri Adresi:" + musteri.Adres);
                Console.WriteLine("Müşteri Telefon:" + musteri.TelNo);
                Console.WriteLine("Müşteri İstek Sayısı:" + musteri.KacAdet);
                Console.WriteLine();
            }

           
        }
    }
}
