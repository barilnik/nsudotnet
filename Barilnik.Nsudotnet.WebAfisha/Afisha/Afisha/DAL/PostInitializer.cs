using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Afisha.Models;

namespace Afisha.DAL
{
    class PostInitializer : DropCreateDatabaseIfModelChanges<PostContext>
    {
        protected override void Seed(PostContext context)
        {
            var biography = new List<Biography>
            {
                new Biography { PerformerBiography = "COOL BIOGRAPHY" },
                new Biography { PerformerBiography = "BAD BIOGRAPHY" },
                new Biography { PerformerBiography = "So-so biography" }
            };
            biography.ForEach(b => context.Biographies.Add(b));
            context.SaveChanges();

            var perfomers = new List<Performer>
            {
                new Performer { Name = "Queen", Country = "UK", Genre = "Rock" , Biography = biography[0] },
                new Performer { Name = "Nickelback", Country = "USA", Genre = "Rock" , Biography = biography[1] },
                new Performer { Name = "Byonce", Country = "USA", Genre = "POP" , Biography = biography[2] }
            };
            perfomers.ForEach(p => context.Performers.Add(p));
            context.SaveChanges();

            var post = new List<Post>
            {
                new Post { PerformerID = 1, Name = perfomers[0].Name, Date = new DateTime(2016, 6, 1, 7, 47, 0)  },
                new Post { PerformerID = 2,  Name = perfomers[1].Name, Date = new DateTime(2016, 6, 1, 7, 47, 0)  },
                new Post { PerformerID = 3,  Name = perfomers[2].Name, Date = new DateTime(2016, 6, 1, 7, 47, 0)  }
            };
            post.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();
        }
    }
}
