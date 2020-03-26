using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToySellingApp.Context;
using ToySellingApp.Model;

namespace ToySellingApp.Domain
{
    class CompanyDomain : MainContext
    {
        public void AddCompany(Company company)
        {
            try
            {
                var db = new MainContext();
                db.companies.Add(company);
                int result = db.SaveChanges();
                if (result > 0)
                    Console.WriteLine("Company Registered....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddToyProduction(ToyProduction toy)
        {
            try
            {
                var db = new MainContext();
                db.toyProductions.Add(toy);
                int result = db.SaveChanges();
                if (result > 0)
                    Console.WriteLine("Toy Product Ready For Order....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<ToyProduction> GetToyProduction()
        {
            return toyProductions.ToList();
        }
    }
}

