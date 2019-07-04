using CFZiyaretciDefteri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CFZiyaretciDefteri
{
    public partial class Default1 : System.Web.UI.Page
    {
        public List<Mesaj> Mesajlar { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ZiyaretContext ctx = new ZiyaretContext();
            /*Repeater1.DataSource = ctx.Mesajlar
                .OrderByDescending(x => x.Tarih)
                .Take(5)
                .ToList()
                .Select(x => new MesajViewModel()
                {
                    UyeId = x.YazanUye.Id,
                    AdSoyad = x.YazanUye.AdSoyad,
                    Icerik = x.Icerik,
                    YazilmaZamani = x.YazilmaZamani,
                    Id = x.Id
                }).ToList();
            Repeater1.DataBind();
            */
            Mesajlar = ctx.Mesajlar
                .OrderByDescending(x=>x.Tarih).Take(5).ToList();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Mesaj m = new Mesaj();
            m.Icerik = Mesaj.Text;
            m.UyeId = (int)Session["GirisYapanID"];

            ZiyaretContext ctx = new ZiyaretContext();
            ctx.Mesajlar.Add(m);
            ctx.SaveChanges();
            Response.Redirect("/");
        }

        
    }
}