using CompanyApp.Context;
using CompanyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Domain
{
    class EmployeeDomain : MainContext
    {
         MainContext db = new MainContext();
       /* Employee emp = new Employee();*/
        public void AddEmployee(Employee emp)
        {
            try
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                Console.WriteLine("Record Inserted.....");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Employee> GetEmployees()
        {
            return Employees.ToList();
        }
        public void AddEmployeeLeave(EmployeeLeave employeeLeave)
        {
            try
            {
                db.EmployeeLeaves.Add(employeeLeave);
                db.SaveChanges();
                Console.WriteLine("Record Inserted.....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public List<vEmployeeLeave> GetEmployeeLeaves()
        {
            return vEmployeeLeaves.ToList();
        }
        public  vEmployeeLeave GetLeaveByEmployeeId(int id)
        {

            vEmployeeLeave ve = new vEmployeeLeave();
            return vEmployeeLeaves.Find(ve.EmployeeId == id);
        }
    }
}
