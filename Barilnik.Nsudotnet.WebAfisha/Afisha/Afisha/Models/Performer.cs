using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Afisha.Models
{
    public class Performer
    {
        [Key]
        public int PerformerID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [Required]
        [StringLength(1024)]
        [Display(Name = "Biography")]
        public Biography Biography { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Country")]
        public String Country { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Genre")]
        public String Genre { get; set; }
    }
}
