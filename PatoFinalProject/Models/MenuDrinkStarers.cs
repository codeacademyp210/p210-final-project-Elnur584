using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Models
{
    public class MenuDrinkStarers
    {
        public int Id { get; set; }
        [Display(Name = "Food Kind")]
        public string FoodKind { get; set; }
        [Display(Name = "1) Food Name")]
        public string Food1Name { get; set; }
        [Display(Name = "1) Food Price")]
        public string Food1Price { get; set; }
        [Display(Name = "1) Food Content")]
        public string Food1Description { get; set; }
        [Display(Name = "2) Food Name")]
        public string Food2Name { get; set; }
        [Display(Name = "2) Food Price")]
        public string Food2Price { get; set; }
        [Display(Name = "2) Food Content")]
        public string Food2Description { get; set; }
        [Display(Name = "3) Food Name")]
        public string Food3Name { get; set; }
        [Display(Name = "3) Food Price")]
        public string Food3Price { get; set; }
        [Display(Name = "3) Food Content")]
        public string Food3Description { get; set; }
        [Display(Name = "4) Food Name")]
        public string Food4Name { get; set; }
        [Display(Name = "4) Food Price")]
        public string Food4Price { get; set; }
        [Display(Name = "4) Food Content")]
        public string Food4Description { get; set; }
    }
}