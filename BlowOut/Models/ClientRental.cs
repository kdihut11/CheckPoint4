using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class ClientRental
    {
        [Key]
        public int ClientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }

        [DisplayName("Instrument:")]
        public string InstrumentType { get; set; }

        [Required(ErrorMessage = "Please select rental type")]
        [DisplayName("Rental Type:")]
        public string NewOrUsed { get; set; }

        [DisplayName("Price:")]
        public int InstrumentPrice { get; set; }
    }
}