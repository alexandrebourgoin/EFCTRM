using EFCTRM_EF6_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EFCTRM_EF6_MVC.DAL
{
    public class ParametersContext : DbContext
    {
        public  ParametersContext() : base("ParametersContext")
        {
        }

        public DbSet<Market> Markets { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}