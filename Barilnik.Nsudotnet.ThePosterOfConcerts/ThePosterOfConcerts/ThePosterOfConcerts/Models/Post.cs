using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePosterOfConcerts.Models
{
    class Post
    {
        public int PerformerID { get; set; }
        public int BiographyID { get; set; }
        public virtual Performer Performer { get; set; }
        public virtual Biography Biography { get; set; }
    }
}
