namespace CompanyApp.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CompanyApp.Model;

    public partial class MainContext : DbContext
    {
        public MainContext()
            : base("name=DbMainContext")
        {
        }

        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ProjectAllocation> ProjectAllocations { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<vEmployeeLeave> vEmployeeLeaves { get; set; }
        public virtual DbSet<vProjectAllocationDetail> vProjectAllocationDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeLeave>()
                .Property(e => e.LeaveReason)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeLeave>()
                .Property(e => e.StartDate)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeLeave>()
                .Property(e => e.EndDate)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.DateOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ProjectAllocation>()
                .Property(e => e.Task)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.StartDate)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.EndDate)
                .IsUnicode(false);

            modelBuilder.Entity<vEmployeeLeave>()
                .Property(e => e.LeaveReason)
                .IsUnicode(false);

            modelBuilder.Entity<vEmployeeLeave>()
                .Property(e => e.StartDate)
                .IsUnicode(false);

            modelBuilder.Entity<vEmployeeLeave>()
                .Property(e => e.EndDate)
                .IsUnicode(false);

            modelBuilder.Entity<vEmployeeLeave>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<vProjectAllocationDetail>()
                .Property(e => e.Business)
                .IsUnicode(false);

            modelBuilder.Entity<vProjectAllocationDetail>()
                .Property(e => e.Employee)
                .IsUnicode(false);

            modelBuilder.Entity<vProjectAllocationDetail>()
                .Property(e => e.Task)
                .IsUnicode(false);

            modelBuilder.Entity<vProjectAllocationDetail>()
                .Property(e => e.StartDate)
                .IsUnicode(false);

            modelBuilder.Entity<vProjectAllocationDetail>()
                .Property(e => e.EndDate)
                .IsUnicode(false);
        }
    }
}
