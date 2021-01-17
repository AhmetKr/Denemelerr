using System;

namespace _2.GünÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Ceket";
            product.ProductId = 4568;
            product.Price = 45.50;
            product.Comment = "Kalın Ceket";

            Product product1 = new Product();
            product1.Name = "Kazak";
            product1.ProductId = 9546;
            product1.Price = 50;
            product1.Comment = "Yünlü Kazak";

            Product product2 = new Product();
            product2.Name = "Pantalon";
            product2.ProductId = 7516;
            product2.Price = 80;
            product2.Comment = "Jogger Pantalon";

            Product[] products = new Product[] {product,product1,product2 };

            //for (int i = 0; i <products.Length; i++)
            //{
            //    Console.WriteLine(products[i]);
            //}

            foreach (Product Product in products)
            {
                Console.WriteLine("ÜRÜN ADI:"+product1.Name);
                break;
            }

            for (int i = 0; i <products.Length; i++)
            {
                Console.WriteLine("ÜRÜN NO:"+product1.ProductId);
                break;
            }

            int a = 0;
            while (a <products.Length)
            {
                Console.WriteLine("ÜRÜN FİYAT:" + product1.Price);
                break;
                
            }

        }
    }
}
