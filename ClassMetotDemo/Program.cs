using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Ahmet";
            customer.Surname = "Kara";
            customer.Age = 18;
            customer.CardID = 1234;

            Customer customer1 = new Customer();
            customer1.Name = "İsa";
            customer1.Surname = "Kara";
            customer1.Age = 26;
            customer1.CardID = 12345;

            Customer customer2 = new Customer();
            customer2.Name = "Yeşim";
            customer2.Surname = "Kara";
            customer2.Age = 24;
            customer2.CardID = 123456;

            Customer[] customers = new Customer[] {customer,customer1,customer2 };

            foreach (var Customer in customers)
            {
                Console.WriteLine("Customer Name:" +Customer.Name);
                
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer);
            customerManager.List(customers);
        }
    }
}
