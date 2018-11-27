using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeURL.Models
{
    public class Makale
    {
        public int Id { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }
        public DateTime tarih { get; set; }
        public kategori kategori { get; set; }
    }
}