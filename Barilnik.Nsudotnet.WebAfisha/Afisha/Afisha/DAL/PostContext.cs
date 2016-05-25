using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Afisha.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Afisha.DAL
{
    public class PostContext : DbContext
    {
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Post> Posts { get; set; }

        static PostContext()
        {
            Database.SetInitializer<PostContext>(new PostInitializer());
        }

        public PostContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
