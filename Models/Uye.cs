using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CFZiyaretciDefteri.Models
{
    [Table("Uyeler")] //db'deki tablo adı
    public class Uye
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required] //not null
        public string AdSoyad { get; set; }

        [MaxLength(300)]
        [Column("Eposta")] //db'deki sütun adı
        public string Email { get; set; }

        [MaxLength(16)] //uzunluk nvarchar(16)
        public string Sifre { get; set; }

        [NotMapped] //db'ye gitmeyecek alan
        public string Oylesine { get; set; }
    }
}