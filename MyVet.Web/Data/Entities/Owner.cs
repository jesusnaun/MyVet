using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }


        /*
        [Required(ErrorMessage ="The {0} field is mandatory.")]
        [MaxLength(10,ErrorMessage = "The {0} field can not have more than {1} characters." )]
        public string Document { get; set; }


        [Required(ErrorMessage = "The {0} field is mandatory.")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Firts Nane")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The {0} field is mandatory.")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Last Nane")]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string FixedPhone { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string CellPhone { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";
        */
        //LO DE ARRIBA SE REEMPLAZA A PARTIR QUE USAMOS IDENTITY USER
        public User User { get; set; }



        //RELACIONES

        public ICollection<Pet> Pets { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
