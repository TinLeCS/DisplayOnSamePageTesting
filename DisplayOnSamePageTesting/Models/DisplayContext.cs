using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DisplayOnSamePageTesting.Models
{
    public class DisplayContext : DbContext
    {

        public DisplayContext() : base("DisplayContext")
        {
        }

        public DbSet<ItemWithProperties> Items { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}