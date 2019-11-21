using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class Rental
    {
        [DisplayName("Instrument:")]
        public string InstrumentType { get; set; }

        [Required(ErrorMessage = "Please select rental type")]
        [DisplayName("Rental Type:")]
        public string NewOrUsed { get; set; }

        [DisplayName("Price:")]
        public int InstrumentPrice { get; set; }

    }
}