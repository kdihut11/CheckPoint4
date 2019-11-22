using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlowOut.DAL
{
    public class NBAContext : DbContext
    {
        public NBAContext() : base("InstrumentContext")
        {

        }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}