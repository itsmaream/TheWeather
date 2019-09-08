using System;
using System.Collections.Generic;
using System.Text;

namespace TheWather.Models
{
    public class Sys : BaseModel
    {
        public double Massage { set; get; }
        public string country { set; get; }
        public int Sunrise { set; get; }
        public int Sunset { set; get; }

    }
}
