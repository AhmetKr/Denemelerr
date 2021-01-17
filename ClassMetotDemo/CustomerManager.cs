using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Succesful added in system:" + customer.Name + "  " + customer.Surname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Succesful deleted in system:" + customer.Name + " " + customer.Surname);
        }

        public void List(Customer[] customer)
        {
            foreach (Customer item in customer)
            {
                Console.WriteLine("Customers List:" + item.Name);
            }
        }
    }
}
