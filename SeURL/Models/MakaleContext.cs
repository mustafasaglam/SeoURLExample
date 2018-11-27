using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeURL.Models
{
    public class MakaleContext:DbContext
    {
        public MakaleContext():base("MakaleContext")
        {

        }

        public DbSet<Makale> Makale { get; set; }
        public DbSet<kategori> Kategori { get; set; }
    }
}