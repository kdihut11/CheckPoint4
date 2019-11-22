using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlowOut.DAL
{
    public class MusicRentalsContext : DbContext
    {
        public MusicRentalsContext() : base("MusicRentalsContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Instruments> Instruments { get; set; }
    }
}