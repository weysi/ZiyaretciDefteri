using CFZiyaretciDefteri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CFZiyaretciDefteri
{
    public partial class Giris : System.Web.UI.Page
    {
        public bool hataVarMi = false;
        //Page Life Cycle
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) {  //sayfa post edildiğinde yapılacaklar 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ZiyaretContext ctx = new ZiyaretContext();
            var u = ctx.Uyeler.Where(x => x.Email == Eposta.Text
                                    && x.Sifre == Sifre.Text)
                                    .FirstOrDefault();

            if(u == null)
                hataVarMi = true;
            else
            {
                Session["GirisYapanID"] = u.Id;
                Session["GirisYapanAd"] = u.AdSoyad;
                Response.Redirect("/");
            }
        }
    }
}