using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ThePosterOfConcerts.Models;

namespace ThePosterOfConcerts.DAL
{
    class PostInitializer : DropCreateDatabaseIfModelChanges<PostContext>
    {
        protected override void Seed(PostContext context)
        {
            var perfomers = new List<Performer>
            {
                new Performer { Name = "Queen", Country = "UK", Genre = "Rock"  },
                new Performer { Name = "Nickelback", Country = "USA", Genre = "Rock"  },
                new Performer { Name = "Byonce", Country = "USA", Genre = "POP"  }
            };
            perfomers.ForEach(p => context.Performer.Add(p));
            context.SaveChanges();

            var biography = new List<Biography>
            {
                new Biography { PerformerBiography = "COOL BIOGRAPHY" },
                new Biography { PerformerBiography = "BAD BIOGRAPHY" },
                new Biography { PerformerBiography = "So-so biography" }
            };
            biography.ForEach(b => context.Biography.Add(b));
            context.SaveChanges();

            var post = new List<Post>
            {
                new Post { PerformerID = 1, BiographyID = 1 },
                new Post { PerformerID = 2, BiographyID = 2 },
                new Post { PerformerID = 3, BiographyID = 3 }
            };
            
        }
    }
}
