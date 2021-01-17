using System;
using System.Collections.Generic;
using System.Text;

namespace Denemelerr
{
    class MakineManager
    {
        public void Ekle(forklift forklift)
        {
            Console.WriteLine("Ürün Sepete Eklenmiştir:" + forklift.Adi);

        }

        public void Çıkar(forklift forklift)
        {
            Console.WriteLine("Ürün Sepetten Çıkarılmıştır:" + forklift.Adi);
        }
    }
}
