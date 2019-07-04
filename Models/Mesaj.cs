using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CFZiyaretciDefteri.Models
{
    [Table("Mesajlar")]
    public class Mesaj
    {
        [Key]
        public int Id { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }

        [ForeignKey("YazanUye")]
        public int UyeId { get; set; }

        public virtual Uye YazanUye { get; set; }

        [NotMapped]
        public string YazilmaZamani
        {
            get
            {
                TimeSpan sure = DateTime.Now - Tarih;
                if (sure.TotalDays < 1)
                    return sure.Hours + " sa " + sure.Minutes + " dk önce";
                else
                    return sure.Days + " gün önce";
            }
        }
        //Mesaj m = new Mesaj();
        public Mesaj()
        {
            Tarih = DateTime.Now;
        }
    }
}