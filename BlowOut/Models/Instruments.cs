using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Instruments")]
    public class Instruments
    {
        [Key]
        public int InstID { get; set; }
        public string InstDesc { get; set; }
        public string InstType { get; set; }
        public int InstPrice { get; set; }
        public int ClientID { get; set; }

        public static Dictionary<string, int> NewPrices = new Dictionary<string, int>
        {
            { "Trumpet", 55 },
            { "Trombone", 60 },
            { "Tuba", 70 },
            { "Flute", 40 },
            { "Clarinet", 35 },
            { "Saxophone", 42 }
        };
        public static Dictionary<string, int> UsedPrices = new Dictionary<string, int>
        {
            { "Trumpet", 25 },
            { "Trombone", 35 },
            { "Tuba", 50 },
            { "Flute", 25 },
            { "Clarinet", 27 },
            { "Saxophone", 30 }
        };
        public static Dictionary<string, string> InstrumentPictures = new Dictionary<string, string>
        {
            { "Trumpet", "trumpet" },
            { "Trombone", "trombone" },
            { "Tuba", "tuba" },
            { "Flute", "flute" },
            { "Clarinet", "clarinet" },
            { "Saxophone", "saxophone" }
        };
    }
}