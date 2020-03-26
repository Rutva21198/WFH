using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToySellingApp.Model;

namespace ToySellingApp.Context
{
    class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JDM9BBH\SQLEXPRESS;initial catalog=ToyDb;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Toys> toys { get; set; }
        public DbSet<CustomerAddress> customerAddresses { get; set; }
        public DbSet<Invoice> invoices { get; set; }
        public DbSet<ToyProduction> toyProductions { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<vOrderDetail> vOrderDetails { get; set; }
        public DbSet<Offer> offers { get; set; }

    }
}
