using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Agenda
    {

        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The {0} field is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Is Available?") ]
        public bool IsAvailable { get; set; }


        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime DateLocal => Date.ToLocalTime();


        //RELACIONES

        public Owner Owner { get; set; }

        public Pet Pet { get; set; }

    }
}
