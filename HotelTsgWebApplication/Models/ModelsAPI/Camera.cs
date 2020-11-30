using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelAPIfinal.Models
{
    public class Camera
    {
        public int nr_camera { get; set; }
        public Nullable<int> capacitate { get; set; }
        public Nullable<int> pret { get; set; }
    }
}