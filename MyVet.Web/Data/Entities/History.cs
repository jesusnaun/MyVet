using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class History
    {

        public int Id { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "The {0} field is mandatory.")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Description { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The {0} field is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true )]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime(); 


        //RELACIONES

        public ServiceType ServiceType { get; set; }

        public Pet Pet { get; set; }

    }
}
