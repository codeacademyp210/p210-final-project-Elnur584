using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Models
{
    public class ReservationForm
    {
        public int Id { get; set; }
        [Display(Name="Date")]
        public string ReservDate { get; set; }
        [Display(Name = "Time")]
        public string ReservTime { get; set; }
        [Display(Name = "People")]
        public string ReservPeople { get; set; }
        [Display(Name = "Phone")]
        [Required(ErrorMessage = "You must provide a phone number")]
        
        public string ReservPhone { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Required")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Invalid First Name")]
        [Display(Name = "Name")]
        public string ReservName { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
       
        [Display(Name = "Email")]
        public string ReservEmail { get; set; }

    }
}