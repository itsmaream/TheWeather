using System;
using System.Collections.Generic;
using System.Text;

namespace TheWather.Models
{
    public class Coord : BaseModel
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }
}
