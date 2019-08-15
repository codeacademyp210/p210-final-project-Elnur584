using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class SettingFtrImgVM
    {
        public List<SettingFtGaleryimg> settingFtGaleryimgsList { get; set; }
        public SettingFtGaleryimg settingFtGaleryimgSingle { get; set; }
        public string Action { get; set; }
    }
}