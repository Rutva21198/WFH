using CompanyApp.Domain;
using CompanyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp
{
    class FunctionChoice
    {
        Employee emp = new Employee();
        EmployeeLeave empleave = new EmployeeLeave();
        vEmployeeLeave vempleave = new vEmployeeLeave();
        EmployeeDomain empDomain = new EmployeeDomain();
        Business business = new Business();
        BusinessDomain businessDomain = new BusinessDomain();
        Project project = new Project();
        ProjectAllocation pa = new ProjectAllocation();
        vProjectAllocationDetail vpa = new vProjectAllocationDetail();
        ProjectDomain projectDomain = new ProjectDomain();
       public FunctionChoice()
        {
            bool carryon = true;
            Console.WriteLine("-----------------Welcome In Project Allocation Company-------------");
            while(carryon)
            {
                Console.WriteLine("1. Add Employee\t2. Add Business \t3. Add Project \t 4. Take Leave" +
                    "\n5.View Employee\t6. View Business\t7. View Project\t8. View Leave" +
                    "\n9. Project Allocate\t10. View Allocate Projects\n\nEnter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter Name :");
                        emp.Name = Console.ReadLine();
                        Console.WriteLine("Enter Gender :");
                        var Gender = Console.ReadLine();
                        if (Gender.Equals("Female") || Gender.Equals("female"))
                            emp.Gender = true;
                        if (Gender.Equals("Male") || Gender.Equals("male"))
                            emp.Gender = false;
                        Console.WriteLine("Enter Date Of Birth :");
                        emp.DateOfBirth = Convert.ToDateTime(Console.ReadLine()).ToString();
                        Console.WriteLine("Enter City : ");
                        emp.City = Console.ReadLine();

                        empDomain.AddEmployee(emp);
                        carryon = ContinueApp();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter Business Name : ");
                        business.BusinessName = Console.ReadLine();
                        Console.WriteLine("Enter City : ");
                        business.City = Console.ReadLine();

                        businessDomain.AddBusiness(business);
                        carryon = ContinueApp();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter Project Title : ");
                        project.ProjectTitle =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Start Date :");
                        project.StartDate = Convert.ToDateTime(Console.ReadLine()).ToString();
                        Console.WriteLine("Enter End Date :");
                        project.EndDate = Convert.ToDateTime(Console.ReadLine()).ToString();

                        projectDomain.AddProject(project);
                        carryon = ContinueApp();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter Employee Id : ");
                        empleave.EmployeeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Leave Reason :");
                        empleave.LeaveReason = Console.ReadLine();
                        Console.WriteLine("Leave Start Date :");
                        empleave.StartDate = Convert.ToDateTime(Console.ReadLine()).ToString();
                        Console.WriteLine("Leave End Date :");
                        empleave.EndDate = Convert.ToDateTime(Console.ReadLine()).ToString();

                        empDomain.AddEmployeeLeave(empleave);
                        carryon = ContinueApp();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("---------View Employee------------");
                        Console.WriteLine("Id Name\tGender\tDateOfBirth\t  \tCity");
                        foreach( Employee em in empDomain.GetEmployees())
                        {
                            if(em.Gender)
                                Console.WriteLine("\t"+em.EmployeeId+"  "+em.Name+"  \tFemale\t"+em.DateOfBirth+"\t"+em.City);
                            else
                                Console.WriteLine("\t" + em.EmployeeId + "  " + em.Name + "  \tMale  \t" + em.DateOfBirth + "\t" + em.City);
                        }
                        carryon = ContinueApp();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("---------View Business------------");
                        Console.WriteLine("\tId BusinessName \tCity");
                        foreach (Business bs in businessDomain.GetBusinesses())
                        {
                            Console.WriteLine("\t" + bs.BusinessId+"  "+bs.BusinessName + "    \t" + bs.City);
                        }
                        carryon = ContinueApp();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("---------View Project------------");
                        Console.WriteLine("\tId ProjectTitle\tStart Date \t \t End Date ");
                        foreach (Project p in projectDomain.GetProjects())
                        {
                            Console.WriteLine("\t" +p.ProjectId + "  "+p.ProjectTitle+"\t" + p.StartDate + "  " + p.EndDate);
                        }
                        carryon = ContinueApp();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("---------View Employee Leave Vacation------------");
                        Console.WriteLine("LeaveId EmpId Name\tReason\tStartDate\t\t  EndDate");
                        foreach (vEmployeeLeave vem in empDomain.GetEmployeeLeaves())
                        {
                                Console.WriteLine("\t" + vem.EmployeeId + "  " + vem.Name + "  \t"+vem.LeaveReason+"\t" + vem.StartDate + "  " + vem.EndDate);
                        }
                            carryon = ContinueApp();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Enter Project Id : ");
                        pa.ProjectId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Business Id : ");
                        pa.BusinessId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Id : ");
                        pa.EmployeeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Task : ");
                        pa.Task = Console.ReadLine();

                        projectDomain.AlllocateProject(pa);
                        carryon = ContinueApp();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("---------View Employee Leave Vacation------------");
                        Console.WriteLine("LeaveId EmpId Name\tReason\tStartDate\t\t  EndDate");
                        foreach (vEmployeeLeave vem in empDomain.GetEmployeeLeaves())
                        {
                            Console.WriteLine("\t" + vem.EmployeeId + "  " + vem.Name + "  \t" + vem.LeaveReason + "\t" + vem.StartDate + "  " + vem.EndDate);
                        }
                        carryon = ContinueApp();
                        break;
                    default:
                        Console.WriteLine("You Enter Invalid Choice...");
                        carryon = ContinueApp();
                        break;
                }
                
            }
        }
        public Boolean ContinueApp()
        {
            Console.WriteLine(" Do You Want To Continue ?? If Yes Press Y\nEnter Choice :");
            char c = Convert.ToChar(Console.ReadLine());
            if (c.Equals('y') || c.Equals('Y'))
            {
                return  true;
            }
            else
                return false;
        }
    }
}
