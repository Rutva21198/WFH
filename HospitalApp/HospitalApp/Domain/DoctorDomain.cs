using HospitalApp.Contex;
using HospitalApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HospitalApp.Domain
{
    class DoctorDomain : MainContext
    {
        public void AddDoctor(Doctor dr)
        {
            try
            {
                var db = new MainContext();
                db.doctors.Add(dr);
                db.SaveChanges();
                int res = db.SaveChanges();
                if (res > 0)
                    Console.WriteLine("Docor Add Successfully....");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Doctor> GetDoctors()
        {
            return doctors.ToList();
        }
        public List<Departments> GetDepartments()
        {
            return departments.ToList();
        }
    }
}
