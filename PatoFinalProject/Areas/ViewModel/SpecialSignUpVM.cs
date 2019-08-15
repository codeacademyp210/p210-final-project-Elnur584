using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class SpecialSignUpVM
    {
        public List<SpecialSignUp> specialSignUpsList { get; set; }
        public SpecialSignUp specialSignUpSingle { get; set; }
        public string Action { get; set; }
    }
}