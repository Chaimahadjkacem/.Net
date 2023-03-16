using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Section
    {

        // ne respecte pas les regles lezem esm classe + Id ou bien Id kahw o hne aandi IdSection ghalta lezem SectionId donc lezem [Key]
        [Key] 
        public int IdSection { get; set; }
        [Required(ErrorMessage ="Name Obligatoire")]
        [MinLength(1)]
        public string Name { get; set; }

        public virtual List<Seat> Seats { get; set; }

    }
}
