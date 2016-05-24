using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Afisha.Models
{
    public class Biography
    {
        public int BiographyID { get; set; }
        public int PerformerID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biography")]
        public String PerformerBiography { get; set; }
    }
}
