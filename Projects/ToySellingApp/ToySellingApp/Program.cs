using System;
using ToySellingApp.Domain;
using ToySellingApp.Model;

namespace ToySellingApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool carryon = true;
            char ch;
            int i;
            OrderDomain orderDomain = new OrderDomain();
            CustomerDomain customerDomain = new CustomerDomain();
            CompanyDomain companyDomain = new CompanyDomain();

            Console.WriteLine("----------------Welcome in ToySelling Application-------------");
            while(carryon)
            {
                Console.WriteLine("\n1. Customer Registration\t2.Company Registration\n3. Add Toy In Production\t 4. View Toys\n5. View Customers \n6 . Add Shipping Address\t7. Show Address \n 8. Add Order In Cart\t9. View Cart Order  \n10. Place Order \t 11. View Invoice\n\nEnter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Customer customer = new Customer();
                        Console.WriteLine("\nEnter Name :");
                        customer.Name = Console.ReadLine();
                        Console.WriteLine("\nEnter Mobile No :");
                        customer.MobileNo = Convert.ToInt32(Console.ReadLine()).ToString();
                        Console.WriteLine("\nEnter City :");
                        customer.City = Console.ReadLine();
                        
                        customerDomain.AddCustomer(customer);
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;
                        break;
                    case 2:
                        Company company = new Company();
                        Console.WriteLine("\nEnter Name :");
                        company.CompanyName = Console.ReadLine();
                        Console.WriteLine("\nEnter City :");
                        company.City = Console.ReadLine();
                        
                        companyDomain.AddCompany(company);
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;
                        break;
                    case 3:
                        ToyProduction toyProduction = new ToyProduction();
                        Console.WriteLine("\nEnter Toy Id :");
                        toyProduction.ToyId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter CompanyId :");
                        toyProduction.CompanyId =Convert.ToInt32( Console.ReadLine());
                        Console.WriteLine("\nEnter Price :");
                        toyProduction.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter Quantity :");
                        toyProduction.Quantity = Convert.ToInt32(Console.ReadLine());
                        CompanyDomain companyDomain1 = new CompanyDomain();
                        companyDomain1.AddToyProduction(toyProduction);
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;
                        break;
                    case 4:
                        CompanyDomain cd = new CompanyDomain();
                        i = 1;
                        foreach (ToyProduction toy in cd.GetToyProduction())
                        {
                            Console.WriteLine("Toy - " + i);
                            Console.WriteLine("ToyProductionId : " + toy.ProductionId);
                            Console.WriteLine("ToyId : " + toy.ToyId);
                            Console.WriteLine("CompanyId : " + toy.CompanyId);
                            Console.WriteLine("Price : " + toy.Price);
                            Console.WriteLine("Total Toy : " + toy.Quantity);
                            Console.WriteLine("------------------------------------------------");
                        }
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;

                        break;
                    case 5:
                        foreach (Customer customer1 in customerDomain.GetCustomers())
                        {
                            Console.WriteLine("Customer Id : " + customer1.CustomerId);
                            Console.WriteLine("Name : " + customer1.Name);
                            Console.WriteLine("Mobile No : " + customer1.MobileNo);
                            Console.WriteLine("Ciry : " + customer1.City);
                            Console.WriteLine("------------------------------------------------");
                        }
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;

                        break;

                    case 6:
                        CustomerAddress customerAddress = new CustomerAddress();
                        Console.WriteLine("\nEnter Address :");
                        customerAddress.Address = Console.ReadLine();
                        Console.WriteLine("\nEnter Custermer Id :");
                        customerAddress.CustomerId = Convert.ToInt32(Console.ReadLine());
                        CustomerDomain cust = new CustomerDomain();
                        cust.AddAddress(customerAddress);
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;

                        break;
                    case 7:
                        CustomerAddress ca = new CustomerAddress();
                        Console.WriteLine("Enter Customer Id :");
                        ca.CustomerId = Convert.ToInt32(Console.ReadLine());
                        foreach (CustomerAddress customer1 in customerDomain.GetCustomerAddresses(ca))
                        {
                            Console.WriteLine("Customer Id : " + customer1.CustomerId);
                            Console.WriteLine("Address Id : " + customer1.AddressId);
                            Console.WriteLine("Address : " + customer1.Address);
                            Console.WriteLine("------------------------------------------------");
                        }
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;

                        break;
                    case 8:
                        Order order = new Order();
                        Console.WriteLine("\nEnter Custermer Id :");
                        order.CustomerId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter ToyProduction Id :");
                        order.ProductionId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter Quantity :");
                        order.Quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter Shipping Address Id :");
                        order.AddressId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter Order Date :");
                        order.OrderDate = Convert.ToDateTime(Console.ReadLine());
                        
                        orderDomain.AddOrder(order);
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;

                        break;
                    case 9:
                        foreach (Order orders in orderDomain.GetOrders())
                        {
                            Console.WriteLine("Order Id : " + orders.OderId);
                            Console.WriteLine("ToyId : " + orders.CustomerId);
                            Console.WriteLine("ToyId : " + orders.ProductionId);
                            Console.WriteLine("AddressId : " + orders.AddressId);
                            Console.WriteLine("------------------------------------------------");
                        }
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;

                        break;
                    case 10:
                        orderDomain.GetOrderById();
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;
                        break;
                    case 11:
                        Invoice invoice = new Invoice();
                        invoice = orderDomain.GetInvoiceById();
                        Console.WriteLine("Invoice Id :" + invoice.InvoiceId);
                        Console.WriteLine("Order Id :" + invoice.OrderId);
                        Console.WriteLine("Price :" + invoice.Price);
                        Console.WriteLine("Offer Id :" + invoice.OfferId);
                        Console.WriteLine("Final Price :" + invoice.FinalPrice);
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;
                        break;

                    default:
                        carryon = false;
                        break;
                }
            }
        }
        
    }
}
