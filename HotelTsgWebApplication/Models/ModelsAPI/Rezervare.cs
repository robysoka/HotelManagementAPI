using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelTsgWebApplication.Models
{
    public class Rezervare
    {
        public Nullable<int> nr_persoane { get; set; }
        public Nullable<System.DateTime> data_check_in { get; set; }
        public Nullable<System.DateTime> data_check_out { get; set; }
        public Nullable<System.DateTime> data_rezervare { get; set; }
    }
}