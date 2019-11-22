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

        [ForeignKey("Client")]
        public int ClientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
    }
}