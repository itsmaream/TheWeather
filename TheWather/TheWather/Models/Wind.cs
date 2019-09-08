using System;
using System.Collections.Generic;
using System.Text;

namespace TheWather.Models
{
   public class Wind : BaseModel
    {
        public double Speed { set; get; }
        public double Deg { set; get; }
    }
}
