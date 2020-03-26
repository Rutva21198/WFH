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
            Console.WriteLine("----------------Welcome in ToySelling Application-------------");
            while(carryon)
            {
                Console.WriteLine("\n1. Customer Registration\t2.Company Registration\n3. Toy Production\t 4. View Toys\n5. Add Shipping Address \t 6. Add Order In Cart\n7. View Cart Order  \t8. Place Order \n 9. View Invoice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Customer customer = new Customer();
                        Console.WriteLine("\nEnter Name :");
                        customer.Name = Console.ReadLine();
                        Console.WriteLine("\nEnter Mobile No :");
                        customer.MobileNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter City :");
                        customer.City = Console.ReadLine();
                        CustomerDomain customerDomain = new CustomerDomain();
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
                        CompanyDomain companyDomain = new CompanyDomain();
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
                            Console.WriteLine("ToyProductionId : " + toy.ToyProductionId);
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
                        CustomerAddress customerAddress = new CustomerAddress();
                        Console.WriteLine("\nEnter Name :");
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
                    case 6:
                        Order order = new Order();
                        Console.WriteLine("\nEnter Custermer Id :");
                        order.CustomerId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter ToyProduction Id :");
                        order.ToyProductionId = Convert.ToInt32(Console.ReadLine());
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
                    case 7:
                       
                        foreach (Order orders in orderDomain.GetOrders())
                        {
                            Console.WriteLine("Order Id : " + orders.OderId);
                            Console.WriteLine("ToyId : " + orders.CustomerId);
                            Console.WriteLine("ToyId : " + orders.ToyProductionId);
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
                    case 8:
                        orderDomain.GetOrderById();
                        Console.WriteLine("\nDo you want to continue? Press y for yes");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch.Equals('y') || ch.Equals('Y'))
                            carryon = true;
                        else
                            carryon = false;
                        break;
                    case 9:
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
