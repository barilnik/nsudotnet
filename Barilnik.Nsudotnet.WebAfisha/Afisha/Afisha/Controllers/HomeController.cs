using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Afisha.DAL;
using Afisha.Models;

namespace Afisha.Controllers
{
    public class HomeController : Controller
    {
        private PostContext db = new PostContext();

        public ActionResult Index()
        {
            //return View();
            /*var performers = from p in db.Performers select p;
            return View(performers);*/


            
            var biography = new List<Biography>
            {
                new Biography { PerformerBiography = "COOL BIOGRAPHY" },
                new Biography { PerformerBiography = "BAD BIOGRAPHY" },
                new Biography { PerformerBiography = "So-so biography" }
            };
            var performers = new List<Performer>
            {
                new Performer { Name = "Queen", Country = "UK", Genre = "Rock" , Biography = biography[0] },
                new Performer { Name = "Nickelback", Country = "USA", Genre = "Rock" , Biography = biography[1] },
                new Performer { Name = "Byonce", Country = "USA", Genre = "POP" , Biography = biography[2] }
            };

            var posts = new List<Post>
            {
                new Post { PerformerID = 1, Name = performers[0].Name, Date = new DateTime(2016, 6, 1, 7, 47, 0), Place = "Moscow"  },
                new Post { PerformerID = 2,  Name = performers[1].Name, Date = new DateTime(2016, 6, 1, 7, 47, 0), Place = "Novosibirsk"  },
                new Post { PerformerID = 3,  Name = performers[2].Name, Date = new DateTime(2016, 6, 1, 7, 47, 0), Place = "Slavgorod"  }
            };

            return View(posts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}