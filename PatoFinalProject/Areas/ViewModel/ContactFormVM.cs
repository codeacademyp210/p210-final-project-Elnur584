using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class ContactFormVM
    {
        public List<ContactForm> contactFormsList { get; set; }
        public ContactForm contactFormSingle { get; set; }
        public string Action { get; set; }
    }
}