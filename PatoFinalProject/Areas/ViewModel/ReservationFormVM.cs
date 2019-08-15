using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class ReservationFormVM
    {
        public List<ReservationForm> ReservationFormsList { get; set; }
        public ReservationForm reservationFormSingle { get; set; }
        public string Action { get; set; }
    }
}