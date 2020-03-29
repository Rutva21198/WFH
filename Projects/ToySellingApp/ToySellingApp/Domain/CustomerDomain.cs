using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToySellingApp.Context;
using ToySellingApp.Model;

namespace ToySellingApp.Domain
{
    class CustomerDomain : MainContext
    {
        public void AddCustomer(Customer customer)
        {
            try
            {
                var db = new MainContext();
                db.customers.Add(customer);
                int result = db.SaveChanges();
                if (result > 0)
                    Console.WriteLine("Registration Successfully....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddAddress(CustomerAddress customer)
        {
            try
            {
                var db = new MainContext();
                db.customerAddresses.Add(customer);
                int result = db.SaveChanges();
                if (result > 0)
                    Console.WriteLine("Address Added....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Customer> GetCustomers()
        {
            return customers.ToList();
        }
        public List<CustomerAddress> GetCustomerAddresses(CustomerAddress customerAddress)
        {
            var db = new MainContext();
            List<CustomerAddress> ca = new List<CustomerAddress>();
            ca.Add(db.customerAddresses.Find(customerAddress));
            return ca ;
        }
    }
}
