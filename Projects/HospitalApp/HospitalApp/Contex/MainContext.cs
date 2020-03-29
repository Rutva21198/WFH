using HospitalApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HospitalApp.Contex
{
    class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JDM9BBH\SQLEXPRESS;initial catalog=HospitalDb;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
       
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Departments> departments { get; set; }
        public DbSet<DrugAllocation> drugAllocations { get; set; }

    }
}
