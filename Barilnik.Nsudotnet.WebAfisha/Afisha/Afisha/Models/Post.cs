using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int PerformerID { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        //public int BiographyID { get; set; }
        public virtual Performer Performer { get; set; }
        //public virtual Biography Biography { get; set; }
    }
}
