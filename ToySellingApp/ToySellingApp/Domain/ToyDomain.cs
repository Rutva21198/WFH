using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToySellingApp.Context;
using ToySellingApp.Model;

namespace ToySellingApp.Domain
{
    class ToyDomain : MainContext
    {
        public void AddToy(Toys toy)
        {
            try
            {
                var db = new MainContext();
                db.toys.Add(toy);
                int result=db.SaveChanges();
                if (result > 0)
                    Console.WriteLine("Toy Added....");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Offer> GetOffers()
        {
            return offers.ToList();
        }
    }
}
