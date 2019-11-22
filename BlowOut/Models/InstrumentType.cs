using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class InstrumentType
    {
        public static List<InstrumentType> Types = new List<InstrumentType>
        {
            new InstrumentType{Name = "Trumpet", NewPrice = 55, UsedPrice = 25, Picture = "trumpet"},
            new InstrumentType{Name = "Trombone", NewPrice = 60, UsedPrice = 35, Picture = "trombone"},
            new InstrumentType{Name = "Tuba", NewPrice = 70, UsedPrice = 50, Picture = "tuba"},
            new InstrumentType{Name = "Flute", NewPrice = 40, UsedPrice = 25, Picture = "flute"},
            new InstrumentType{Name = "Clarinet", NewPrice = 35, UsedPrice = 27, Picture = "clarinet"},
            new InstrumentType{Name = "Saxophone", NewPrice = 42, UsedPrice = 30, Picture = "saxophone"}
        };

        public string Name { get; set; }
        public int NewPrice { get; set; }
        public int UsedPrice { get; set; }
        public string Picture { get; set; }
    }
}