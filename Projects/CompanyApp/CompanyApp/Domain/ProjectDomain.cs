using CompanyApp.Context;
using CompanyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Domain
{
    class ProjectDomain : MainContext
    {
        MainContext db = new MainContext();
        public void AddProject(Project project)
        {
            try
            {
                db.Projects.Add(project);
                db.SaveChanges();
                Console.WriteLine("Record Inserted.....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Project> GetProjects()
        {
            return Projects.ToList();
        }
        public void AlllocateProject(ProjectAllocation projectAllocation)
        {
            try
            {
                db.ProjectAllocations.Add(projectAllocation);
                db.SaveChanges();
                Console.WriteLine("Record Inserted.....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<vProjectAllocationDetail> GetProjectAllocationDetails()
        {
            return vProjectAllocationDetails.ToList();
        }
    }
}
