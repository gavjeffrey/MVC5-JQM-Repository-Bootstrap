using MVC5Bootstrap.Domain;
using System.Collections.Generic;

namespace MVC5Bootstrap.Infrastructure.Repository.Impl
{
    public sealed class InMemCustomerStore
    {
        private static readonly InMemCustomerStore instance = new InMemCustomerStore();

        public static List<Customer> Customers { get; set; }

        private InMemCustomerStore()
        {
            if (Customers == null)
                Customers = new List<Customer>();

            //Set up some dummy data
            Customers.Add(new Customer() { FirstName = "Jason", Surname = "Newsted" });
            Customers.Add(new Customer() { FirstName = "James", Surname = "Hetfield" });
            Customers.Add(new Customer() { FirstName = "Slash", Surname = "" });
            Customers.Add(new Customer() { FirstName = "James", Surname = "May" });
            Customers.Add(new Customer() { FirstName = "James", Surname = "Brown" });
            Customers.Add(new Customer() { FirstName = "Bob", Surname = "Marley" });
            Customers.Add(new Customer() { FirstName = "Jason", Surname = "Bourne" });
        }

        public static InMemCustomerStore Instance
        {
            get
            {
                return instance;
            }
        }
    }
}