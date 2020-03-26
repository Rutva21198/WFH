using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToySellingApp.Context;
using ToySellingApp.Model;

namespace ToySellingApp.Domain
{
    class OrderDomain : MainContext
    {
        public List<vOrderDetail> orders1 = new List<vOrderDetail>();
        Invoice invoice = new Invoice();
        float price = 0;
        
        public void AddOrder(Order order)
        {
            try
            {
                var db = new MainContext();
                db.orders.Add(order);
                int result = db.SaveChanges();
                if (result > 0)
                    Console.WriteLine("Order Added....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Order> GetOrders()
        {
            return orders.ToList();
        }
        public void GetOrderById()
        {
            vOrderDetail vod = new vOrderDetail();
            Console.WriteLine("Your Order Confirmed Please Enter Order Id : ");
            invoice.OrderId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Id : ");
            vod.OderId = invoice.OrderId;
            var db = new MainContext();
            vOrderDetail a = new vOrderDetail();
            a=db.vOrderDetails.Find(vod);
                price = (price + a.Price) * a.Quantity;
            invoice.Price = price;
            AddInvoice();
           // return a;
        }
        public void AddInvoice()
        {
            
            float discount = 0;
            var a=offers.ToList();
            foreach ( Offer o in a)
            {
                if(o.MinAmount<price)
                {
                    discount = o.Discount;
                    invoice.OfferId = o.OfferId;
                }
            }
            float discountAmount = price * discount;
            invoice.FinalPrice = price - discountAmount;
            var db = new MainContext();
            
            db.invoices.Add(invoice);
        }
        public Invoice GetInvoiceById()
        {
            Console.WriteLine("\nEnter Order Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            return invoices.Find(invoice.OrderId=id);
        }
    }
}