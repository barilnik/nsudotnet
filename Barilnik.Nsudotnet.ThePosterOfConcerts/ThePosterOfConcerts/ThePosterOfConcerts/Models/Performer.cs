using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePosterOfConcerts.Models
{
    class Performer
    {
        public int PerformerID { get; set; }
        public String Name { get; set; }
        public Biography biography { get; set; }
        public String Country { get; set; }
        public String Genre { get; set; }
    }
}
