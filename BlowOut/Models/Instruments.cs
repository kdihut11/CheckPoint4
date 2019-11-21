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
        public String InstDesc { get; set; }
        public String InstType { get; set; }
        public int InstPrice { get; set; }
        public int ClientID { get; set; }
    }
}