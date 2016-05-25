using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Afisha.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int PerformerID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Place")]
        public string Place { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        //public int BiographyID { get; set; }
        public virtual Performer Performer { get; set; }
        //public virtual Biography Biography { get; set; }
    }
}
