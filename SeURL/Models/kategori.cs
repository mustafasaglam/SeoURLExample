using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeURL.Models
{
    public class kategori
    {
        public int Id { get; set; }
        public string ad { get; set; }
        public ICollection<Makale> Makale { get; set; }
    }
}