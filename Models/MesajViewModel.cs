using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFZiyaretciDefteri.Models
{
    public class MesajViewModel
    {
        public int UyeId{ get; set; }
        public string AdSoyad { get; set; }
        public string Icerik { get; set; }
        public string YazilmaZamani { get; set; }
        public int Id { get; set; }
    }
}