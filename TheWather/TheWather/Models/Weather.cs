using System;
using System.Collections.Generic;
using System.Text;

namespace TheWather.Models
{
    public class Weather : BaseModel
    {
        public string Main { get; set; }
        public string Descripion { get; set; }
        public string Icon { get; set; }
    }
}
