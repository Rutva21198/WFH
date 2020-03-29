using HospitalApp.Contex;
using HospitalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp.Domain
{
    class DrugDomain : MainContext
    {
        public void DrugAllocation(DrugAllocation drugs)
        {
            try {
                var db = new MainContext();
                db.drugAllocations.Add(drugs);
                int res = db.SaveChanges();
                if (res > 0)
                    Console.WriteLine("Drugs Allocate To Patient Successfully....");
             }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
