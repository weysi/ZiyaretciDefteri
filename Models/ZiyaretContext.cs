using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CFZiyaretciDefteri.Models
{
    public class ZiyaretContext : DbContext
    {
        public virtual DbSet<Uye> Uyeler { get; set; }
        public virtual DbSet<Mesaj> Mesajlar { get; set; }
    }
}