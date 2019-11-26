using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Display(Name = "Service Type")]
        [Required(ErrorMessage = "The {0} field is mandatory.")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Name { get; set; }


        //RELACIONES

        public ICollection<History> Histories { get; set; }

    }
}
