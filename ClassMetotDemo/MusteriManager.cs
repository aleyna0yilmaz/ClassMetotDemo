using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: "+ musteri.Adi);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi- "+musteri.Adi);
        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi: " + musteri.Adi);
        }
    }
}
