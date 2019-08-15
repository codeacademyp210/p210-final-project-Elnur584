using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Models
{
    public class User
    {
        [Required(ErrorMessage = "Username ve ya Email Yanlisdir")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Email { get; set; }
        public string Password { get; set; }
       
    }
}