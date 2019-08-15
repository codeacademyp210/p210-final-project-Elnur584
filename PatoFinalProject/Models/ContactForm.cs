using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Models
{
    public class ContactForm
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Required")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Invalid First Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}