using System;

namespace Denemelerr
{
    class Program
    {
        static void Main(string[] args)
        {

            

            forklift forklift1 = new forklift();
            forklift1.Adi = "Linde";
            forklift1.SeriNo = 12345;
            forklift1.UretimYili = 2020;
            forklift1.Tonaj = 2000;
            forklift1.Fiyat = 50.00;

            forklift forklift2 = new forklift();
            forklift2.Adi = "TCM";
            forklift2.SeriNo = 123456;
            forklift2.UretimYili = 2013;
            forklift2.Tonaj = 3000;
            forklift2.Fiyat = 40.00;

            forklift forklift3 = new forklift();
            forklift3.Adi = "Jungheınrıch";
            forklift3.SeriNo = 123456789;
            forklift3.UretimYili = 2004;
            forklift3.Tonaj = 1500;
            forklift3.Fiyat = 20.00;

            forklift[] forkliftler = new forklift[] {forklift1,forklift2,forklift3 };

            foreach (forklift Forklift in forkliftler)
            {
                Console.WriteLine("Marka:"+Forklift.Adi);
                Console.WriteLine("Fiyat:"+Forklift.Fiyat);
                Console.WriteLine("Seri Numara:"+Forklift.SeriNo);
                Console.WriteLine("Üretim Yılı:"+Forklift.UretimYili);
                Console.WriteLine("--------------");
            }

            MakineManager makineManager = new MakineManager();
            makineManager.Ekle(forklift1);
            makineManager.Ekle(forklift2);
            makineManager.Ekle(forklift3);
            Console.WriteLine("-----------------------------------");
            makineManager.Çıkar(forklift2);
            Console.WriteLine("-----------------------------------");

            int sayi1 = 15;
            string urun;
            switch (sayi1)
            {
                case 15:
                    Console.WriteLine("Urun Sayınız:" + sayi1);
                    break;
                case 20:
                    Console.WriteLine("Urun Sayınız:" + sayi1);
                    break;
                   
            }


            int sayi2 = 1000;
            while (sayi2>=0)
            {
                Console.WriteLine(sayi2);
                break; 
            }






        }
        
    }
}