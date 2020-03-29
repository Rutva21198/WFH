using CompanyApp.Context;
using CompanyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Domain
{
    class BusinessDomain : MainContext
    {
        MainContext db = new MainContext();
        public void AddBusiness(Business business)
        {
            try
            {
                db.Businesses.Add(business);
                db.SaveChanges();
                Console.WriteLine("Record Inserted.....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public List<Business> GetBusinesses()
        {
            return Businesses.ToList();
        }
    }
}
