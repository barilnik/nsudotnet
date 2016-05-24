using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePosterOfConcerts.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ThePosterOfConcerts.DAL
{
    class PostContext : DbContext
    {
        public DbSet<Performer> Performer { get; set; }
        public DbSet<Biography> Biography { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
